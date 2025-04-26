using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //Is kodlari
            return _categoryDal.GetAll();
        }

        public Category GetId(int categoryId)
        {
            //Select * from Categories where CategoryId = 3
            return _categoryDal.Get(c=>c.CategoryId == categoryId);
        }
    }
}
