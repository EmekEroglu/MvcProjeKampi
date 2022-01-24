using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //tüm katmanlardan veya sınıflardan erişim sağlayabilmek için public acsses modifayer kullanılır.
    public class Writer //Writer / Yazar sınıfı, veritabanındaki Writer / Yazar tablosunun karşılık gelen kısmıdır.
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurName { get; set; }
        [StringLength(100)]
        public string WriterImage { get; set; }
        [StringLength(50)]
        public string WriterMail { get; set; }
        [StringLength(20)]
        public string WriterPassword { get; set; }

        #region Bire Çok İlişki // İlişkili tablo
        public ICollection<Heading> Headings { get; set; }

        public ICollection<Content> Contents { get; set; }
        #endregion


    }
}
