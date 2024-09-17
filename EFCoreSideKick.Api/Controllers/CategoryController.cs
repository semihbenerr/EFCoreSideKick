using EFCoreSideKick.Api;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreSideKick.Api
{
    [ApiController]
    [EntityValidation]
    [Route("api/[controller]/[action]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<Category?> GetAsync([FromQuery] int id)
        {
            return _service.GetAsync(id, HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<IEnumerable<Category>> GetListAsync()
        {
            return _service.GetListAsync(HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<PagedResult<Category>> GetPageAsync([FromQuery] PageParameter page)
        {
            return _service.GetPageAsync(page, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddAsync([FromBody] Category category)
        {
            return _service.AddAsync(category, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddRangeAsync([FromBody] IEnumerable<Category> categories)
        {
            return _service.AddRangeAsync(categories, HttpContext.RequestAborted);
        }

        [HttpPut]
        public Task<bool> UpdateAsync([FromBody] Category category)
        {
            return _service.UpdateAsync(category, HttpContext.RequestAborted);
        }

        [HttpDelete]
        public Task<bool> DeleteAsync([FromQuery] int id)
        {
            return _service.DeleteAsync(id, HttpContext.RequestAborted);
        }
    }
}
