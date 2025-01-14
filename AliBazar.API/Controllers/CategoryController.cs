﻿using AliBazar.Application.Services.CategoryServices;
using AliBazar.Application.ViewModels;
using AliBazar.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AliBazar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> PostCategory([FromForm] CategoryDTO categoryDTO)
        {
            var result = await _categoryService.CreateCategory(categoryDTO);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(long id, [FromForm] CategoryDTO categoryDTO)
        {
            var result = await _categoryService.UpdateCategoryById(id, categoryDTO);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAllCategories();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await _categoryService.GetCategoryById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCategory(long id)
        {
            var result = await _categoryService.DeleteCategoryById(id);

            if (result == false)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
