﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductListed = "Ürün listelendi";
        public static string ProductCountCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten baska bir ürün var";
        public static string CategoryLimitExceded="Kategori limiti asildigi için yeni ürün eklenemiyor";
    }
}
