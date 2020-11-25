using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Application.Interface;
using Inventory.Application.Requests.Uom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UomController : ControllerBase
    {
        private readonly IUomService _uomService;
        public UomController(IUomService uomService)
        {
            _uomService = uomService;
        }

        public async Task<IActionResult> GetUoms()
        {
            var categories = await _uomService.GetAllAsync();
            return Ok(categories);
        }

        [Route("typelist")]
        [HttpGet]
        public IActionResult GetMeasureType()
        {
            var UomType = _uomService.GetUomType();
            return Ok(UomType);
        }

        [HttpGet("id/{id:guid}", Name = "UomById")]
        public async Task<IActionResult> GetCategory(Guid id)
        {
            var uom = await _uomService.GetDataAsync(new UomGetData
            { Id = id });
            return Ok(uom);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUom([FromBody] AddUom request)
        {
            var result = await _uomService.AddUomAsync(request);
            return CreatedAtRoute("UomById", new { id = result.UoMId }, result);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateUom(Guid id, [FromBody] EditUom request)
        {
            request.UID = id;
            var result = await _uomService.EditUomAsync(request);
            return Ok(result);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteUom(Guid id, [FromBody] UpdateStatusUom request)
        {
            request.uid = id;
            await _uomService.DeleteAsync(request);

            return NoContent();
        }
    }
}
