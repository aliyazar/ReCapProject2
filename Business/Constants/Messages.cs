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
    }
}
