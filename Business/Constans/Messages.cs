using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Veriler Eklendi";
        public static string CarUpdated = "Veriler Güncellendi";
        public static string CarDeleted = "Veriler Silindi";
        public static string CarDescriptionInvalid = "Açıklama Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarsListed = "Veriler Listelendi";
        public static string ImagesAdded = "resim eklendi";
        public static string FailAddedImageLimit = "Resim limitine erişildi!";
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Zaten Var";
        public static string AccessTokenCreated = "Erişim Token'ı oluşturuldu";

        public static string RegisterSuccess = "Kayıt Başarılı";
        public static string PasswordWrong = "Parola Hatalı";
        public static string LoginSuccess = "Giriş Başarılı";
        public static string UserExists = "Kullanıcı Zaten Var";
        public static string TokenCreated = "Erişim Token'ı oluşturuldu";
        public static string FailedCarImageAdd = "Araç Resmi Eklenemedi";

        public static string ReturnedRental = "Araç Teslim Edildi";

        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserListed = "Kullanıcılar Listelendi";

        public static string CreditCardAdded { get; internal set; }
        public static string PaymentError { get; internal set; }
        public static string PaymentSuccess { get; internal set; }
        public static string FindeksError { get; internal set; }
        public static string FindeksSuccess { get; internal set; }
        public static string CustomerListed { get; internal set; }
    }
}
