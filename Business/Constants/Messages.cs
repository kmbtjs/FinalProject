using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride max 10 ürün olabilir.";
        public static string ProductNameRepeatedError = "Aynı ürün isminde ürün ekleyemezsiniz.";
        public static string CategoryLimitExceeded = "Toplam kategori sayısı 15'i geçemez.";
    }
}
