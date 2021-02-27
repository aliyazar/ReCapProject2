using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages//static olduğu için newlenmeden kullanılabilir
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarModified = "Araç Güncellendi";
        public static string DailyPrice = "Kiralama Fiyatı Sıfır olamaz";
        public static string CompanyClosed = "Şirket Kapalı ";
        public static string CarListed = "Araçlar Listelendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandListed = "Markalar Listelendi";
        public static string ColorListed = "Araç Renkleri Listelendi";
        public static string CarColorAdded = "Bu renk zaten var";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserModified = "Kullanıcı Güncellendi";
        public static string UserListed = "Kullanıcı Listelendi";
        public static string UserDeleted = "Kullanıcı Silindi";

        public static string RentalAdded = "Kiralama Eklendi";
        public static string RentalModified = "Kiralama Güncellendi";
        public static string RentalListed = "Kiralama Listelendi";
        public static string RentalDeleted = "Kiralama Silindi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerModified = "Müşteri Güncellendi";
        public static string CustomerListed = "Müşteri Listelendi";
        public static string CustomerDeleted = "Müşteri Silindi";
    }
}
