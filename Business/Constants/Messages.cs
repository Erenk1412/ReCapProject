﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarDeleted ="Araç Silindi";
        public static string ErrorBrandId ="Aracın BrandId sıfır olamaz";
        public static string GetSuccess ="Listeleme tamamlandı";
        public static string GetError = "Ürünler Listelenirken bir hata oluştu";
        public static string MaintenanceTime = "Sistem bakım saati.Lütfen 24.00 dan sonra deneyiniz";
        public static string CarUpdated ="Araç güncellendi";
        public static string CarImageLimitExceeded="Bir aracın 5'ten fazla resmi olamaz";
        public static string ImageAdded="Resim Ekleme Başarılı";
        public static string ImageDeleted="Resim Silindi";
        public static string ImageUpdated="Resim Güncelleme Başarılı";
    }
}
