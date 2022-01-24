using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //tüm katmanlardan veya sınıflardan erişim sağlayabilmek için public acsses modifayer kullanılır.S
    public class Category //Category / Kategori sınıfı, veritabanındaki Category / Kategori tablosunun karşılık gelen kısmıdır.
    {
        [Key]
        public int CategoryID { get; set; } //Veritabanındaki Category Iydentity'e karşılık gelir.
        [StringLength(50)]
        public string CategoryName { get; set; } //Veritabanındaki Category İsmine karşılık gelir.
        [StringLength(200)]
        public string CategryDesription { get; set; } //Veritabanındaki Category açıklamasına karşılık gelir.
        public bool CategoryStatus { get; set; } //Veritabanındaki Category Durumuna (aktif yada pasif) karşılık gelir.
        #region Bir Çok İlişki // İlişkili tablo
        public ICollection<Heading> Heading { get; set; }
        #endregion

    }
}
