using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //tüm katmanlardan veya sınıflardan erişim sağlayabilmek için public acsses modifayer kullanılır.
    public class About //About / Hakkımızda sınıfı, veritabanındaki About / Hakkımızda tablosunun karşılık gelen kısmıdır.
    {
        [Key]
        public int AboutID { get; set; } //Veritabanındaki About Iydentity'e karşılık gelir.
        [StringLength(1000)]
        public string AboutDetails1 { get; set; } //Veritabanındaki About Detay1'e karşılık gelir.
        [StringLength(1000)]
        public string AboutDetails2 { get; set; } //Veritabanındaki About Detay2'ye karşılık gelir.
        [StringLength(100)]
        public string AboutImage1 { get; set; } //Veritabanındaki About Image1'e karşılık gelir.
        [StringLength(100)]
        public string AboutImage2 { get; set; } //Veritabanındaki About Image2'ye karşılık gelir.
    }
}
