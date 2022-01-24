using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }
        public void CategoryAddBusinessLayer(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length<=3 || p.CategryDesription=="" || p.CategoryName.Length>=51)
            {
                //eğer yukarıdaki if bloğunda sağlanan şartlardan birisine takıldığımızda hata mesajı göndermek için kodu yazacağız.

            }
            else
            {
                repo.Insert(p);
            }
        }

    }
}
