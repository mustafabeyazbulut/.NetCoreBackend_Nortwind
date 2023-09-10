using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        
        public static string ProductAdded = "Ürün başarıyla eklendi.";
        public static string ProductDeleted = "Ürün başarıyla silindi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";

        public static string SuccessfulLogin = "Kullanıcı başarıyla giriş yaptı.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Kullanıcı şifresi hatalı.";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut.";
        public static string UserRegistered = "Kullanıcı kayıt edildi.";

        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu.";
    }
}
