﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

using Core.Entities.Concrete;

using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla on ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limit aşıldığı için yeni ütün eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Kayıt oldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Hatalı parola";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Giriş anahtarı oluşturuldu";
    }
}
