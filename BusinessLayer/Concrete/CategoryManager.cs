using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //CategoryRepository categoryRepository = new CategoryRepository();
        //GenericRepository<Category> repo = new GenericRepository<Category>();
        //EfCategoryRepository efCategoryRepository;
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //public CategoryManager()
        //{
        //    efCategoryRepository= new EfCategoryRepository();
        //}

        public void CategoryAdd(Category category)
        {

            _categoryDal.Insert(category);


            //if(category.CategoryName!= "" && category.CategoryDescription !="" && category.CategoryName.Length >=5 && category.CategoryStatus == true)
            //{
            //    categoryRepository.AddCategory(category);
            //}
            //else
            //{
            //    //hata mesajı 
            //}

        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
            //if(category.CategoryID != 0)
            //{
            //    repo.Delete(category);
            //}

            throw new NotImplementedException();
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
            throw new NotImplementedException();
        }
    }
}
