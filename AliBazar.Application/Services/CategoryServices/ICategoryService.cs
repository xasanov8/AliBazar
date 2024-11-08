﻿using AliBazar.Application.ViewModels;
using AliBazar.Domain.Entities;
using AliBazar.Domain.ViewModels;
using System.Xml.Linq;

namespace AliBazar.Application.Services.CategoryServices
{
    public interface ICategoryService
    {

        public Task<ResponseModel> CreateCategory(CategoryDTO categoryDTO);
        public Task<ResponseModel> UpdateCategoryById(long id, CategoryDTO categoryDTO);
        public Task<bool> DeleteCategoryById(long id);
        public Task<Category> GetCategoryById(long id);
        public Task<IEnumerable<Category>> GetAllCategories();
    }
}