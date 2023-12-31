﻿using AutoMapper;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Blog.Model.Entities.Enums;
using Blog.Web.Areas.Member.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "member")]
    public class AppUserController : Controller
    {
        private readonly SignInManager<Appuser> _signInManager;
        private readonly UserManager<Appuser> _userManager;
        private readonly IMapper _mapper;
        private readonly IAppUserRepository _appUserRepository;
        private readonly IUsedPasswordRepository _usedPasswordRepository;
        public AppUserController(SignInManager<Appuser> signInManager, UserManager<Appuser> userManager, IMapper mapper, IAppUserRepository appUserRepository, IUsedPasswordRepository usedPasswordRepository)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
            _appUserRepository = appUserRepository;
            _usedPasswordRepository = usedPasswordRepository;
        } 
        public async Task<IActionResult> Index(int? categoryId)
        {
            ViewBag.CategoryId = 0;
            Appuser appuser = await _userManager.GetUserAsync(User);
            ViewBag.CategoryAppUserId = appuser.Id;
            if (categoryId.HasValue)
            {
                ViewBag.CategoryId = categoryId;
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");      // redirectoaction("index","home");
        }

        public async Task<IActionResult> Update()
        {
            //Sisteme giriş yapmış kullanıcının bilgileri appuser değişkenine alınır
            Appuser appuser = await _userManager.GetUserAsync(User); 
            var register= _mapper.Map<RegisterUpdateDTO>(appuser); 
            return View(register);
        }
        [HttpPost]
        public IActionResult Update(RegisterUpdateDTO dto)
        {
            // şifre değişti mi değişkeni
            bool isChangedPass=false;
            
            if (ModelState.IsValid)
            { 
                var updateUser = _userManager.Users.FirstOrDefault(I => I.Id == dto.Id);

                //Kullanıcının silme butonuna bastığını yakalamak için yapıldı.
                if (dto.DmlType=="Sil")
                {
                    _appUserRepository.Delete(updateUser);
                    return RedirectToAction("LogOut");
                }

                if ( dto.Image!=null)
                {
                    if(!String.IsNullOrEmpty(updateUser.ImagePath)) 
                        System.IO.File.Delete($"wwwroot/{updateUser.ImagePath}");
                    using var image = Image.Load(dto.Image.OpenReadStream());
                    image.Mutate(a => a.Resize(80, 80));
                    image.Save($"wwwroot/images/{dto.UserName}.jpg");
                    updateUser.ImagePath = $"/images/{dto.UserName}.jpg";
                } 
                 
                updateUser.FirstName = dto.FirstName;
                updateUser.LastName = dto.LastName;
                updateUser.UserName = dto.UserName;
                updateUser.NormalizedUserName =  dto.UserName.ToUpper();
                updateUser.Email = dto.Email;
                updateUser.NormalizedEmail = TurkishCharacterToEnglish (dto.Email.ToUpper());

                //Şifre değişikliğinde hash yapılmadığı için sadece password alanı değişiyordu. bu yüzden login de şifre hatası veriyordu.
                PasswordHasher <Appuser> ph = new PasswordHasher<Appuser>(); 
                updateUser.PasswordHash = ph.HashPassword(updateUser, dto.Password);

                //Eğer bir şifre değiştirme işlemi olduysa son 3 şifreden farklı olması kontrolüne girilir.
                if (updateUser.Password != dto.Password)
                {
                    if (_usedPasswordRepository.IsPreviousPassword(updateUser, dto.Password))
                    {
                        ModelState.AddModelError("", "Girmiş olduğunuz şifre son 3 şifreden farklı olmalıdır."); 
                        return View(dto);
                    }

                    isChangedPass = true;
                } 

                updateUser.Password = dto.Password;

                int affectedRows =_appUserRepository.Update(updateUser);

                //Update işlemi başarılı olduysa ve şifre değiştirme işlemi de yapıldıysa.UsedPassword tablomuza yeni şifre de insert edilir. 
                if (affectedRows > 0 && isChangedPass)
                {
                    _usedPasswordRepository.Create(new UsedPassword(){AppUserID = updateUser.Id,Statu = Statu.Active,PasswordHash = updateUser.PasswordHash});
                }

                ViewBag.Message = "Kayıt Başarılı Bir Şekilde Güncellendi";
            }
            return View(dto);
        } 
        public IActionResult UserDetail(string appUserId)
        {
            ViewBag.AppUserId = appUserId;
            return View();
        }
        public  string TurkishCharacterToEnglish(string text)
        {
            char[] turkishChars = { 'ı', 'ğ', 'İ', 'Ğ', 'ç', 'Ç', 'ş', 'Ş', 'ö', 'Ö', 'ü', 'Ü' };
            char[] englishChars = { 'i', 'g', 'I', 'G', 'c', 'C', 's', 'S', 'o', 'O', 'u', 'U' };

            for (int i = 0; i < turkishChars.Length; i++)
                text = text.Replace(turkishChars[i], englishChars[i]);



            return text;
        }

    }
}
