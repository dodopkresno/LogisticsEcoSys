using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Application.Interface;
using Inventory.Application.Requests.UomCategory;

using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    [Route("api/uomcatagories/[action]")]
    [ApiController]
    public class UomCatagoriesController : ControllerBase
    {
        private readonly IUomCategoryService _uomCategService;

        public UomCatagoriesController(IUomCategoryService uomCategoryService)
        {
            _uomCategService = uomCategoryService;
        }

        [HttpGet]
        [ActionName("all")]
        public async Task<IActionResult> GetCatagories()
        {
            var categories = await _uomCategService.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet]
        [ActionName("typelist")]
        public IActionResult GetMeasureType()
        {
            var measureType = _uomCategService.GetMeasureType();
            return Ok(measureType);
        }

        [HttpGet("{id:guid}", Name = "CategoryById")]
        //[HttpGet("{id:guid}")]
        [ActionName("categorybyid")]
        public async Task<IActionResult> GetCategory(Guid id)
        {
            var category = await _uomCategService.GetDataAsync(new GetDataRequest
            { Id = id });
            return Ok(category);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetCategorybytype(int id)
        //{
        //    var categorybytype = await _uomCategService.GetDataListByTypeAsync(new GetDataByType
        //    { Id = id });
        //    return Ok(categorybytype);
        //}

        [HttpPost]
        [ActionName("add")]
        public async Task<IActionResult> CreateUomCategory([FromBody] AddUoMCategory request)
        {
            var result = await _uomCategService.AddUomCategoryAsync(request);
            return CreatedAtRoute("CategoryById", new { id = result.UoMCategoryId }, result);
        }

        //[HttpPut("id:guid")]
        //public async Task<IActionResult> UpdateUomCategory(Guid id, [FromBody] EditUomCategory request)
        //{
        //    request.UCID = id;
        //    var result = await _uomCategService.EditUomCategoryAsync(request);
        //    return Ok(result);
        //}
    }
}
