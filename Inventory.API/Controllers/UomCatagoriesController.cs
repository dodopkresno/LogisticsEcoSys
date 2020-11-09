using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Application.Interface;
using Inventory.Application.Requests.UomCategory;
using Inventory.Exception;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    [Route("api/uomcatagories")]
    [ApiController]
    public class UomCatagoriesController : ControllerBase
    {
        private readonly IUomCategoryService _uomCategService;
        private readonly ILoggerManager _logger;

        public UomCatagoriesController(IUomCategoryService uomCategoryService, ILoggerManager logger)
        {
            _uomCategService = uomCategoryService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetCatagories()
        {
            var categories = await _uomCategService.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetCategory(Guid id)
        {
            var category = await _uomCategService.GetDataAsync(new GetDataRequest
            { Id = id});
            return Ok(category);
        }
    }
}
