using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages//static olduğu için new'lemeyiz
    {
        public static string ProductAdded = "Ürün eklendi";//public field büyük harfle başlar
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime="Sistem bakımda";
        internal static string ProductsListed="Ürünler listelendi";
    }
}
