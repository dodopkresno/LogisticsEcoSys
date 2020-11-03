using Inventory.Application.Interface;
using Inventory.Application.Mapping;
using Inventory.Application.Requests;
using Inventory.Domain.Enums;
using Inventory.Domain.Interface;
using Inventory.Domain.Models;
using Inventory.Exception;
using LoggerService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Application.Services
{
    public class UomCategoryService : IUomCategoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IUomCategoryMapper _uomCategoryMapper;
        public UomCategoryService(IRepositoryManager repository, ILoggerManager logger, IUomCategoryMapper UomCategoryMapper)
        {
            _repository = repository;
            _logger = logger;
            _uomCategoryMapper = UomCategoryMapper;
        }

        public async Task<UomCategory> AddUomCategory(AddUoMCategory request)
        {
            var item = _uomCategoryMapper.Map(request);
            var objToSearch = await _repository.UoMCategory.GetDataByType(request.Id, trackChanges: false);

            if (objToSearch == null)
            {
                _repository.UoMCategory.AddUomCategory(item);
                await _repository.SaveAsync();
            }
            else { 
                _logger.LogError($"Telah ada measure type serupa"); //draft
                throw new InventoryException("Telah ada measure type serupa");
            }

            return item;
        }
        public async Task<UomCategory> EditUomCategory(EditUomCategory request)
        {
            var objToCheck = await _repository.UoMCategory.GetDataAsync(request.UCID, trackChanges: false);
            if (objToCheck == null)
            {
                _logger.LogError($"Entity with {request.UCID} is not present");
                throw new InventoryException($"Entity with {request.UCID} is not present");
            }
            var item = _uomCategoryMapper.Map(request);
            var objToSearch = await _repository.UoMCategory.GetDataByType(request.Id, trackChanges: false);

            if (objToSearch == null)
            {
                _repository.UoMCategory.UpdateUomCategory(item);
                await _repository.SaveAsync();
            }
            else
            {
                _logger.LogError($"Entity ID {request.UCID} with MeasureType Code {request.Id} already exists");
                throw new InventoryException($"Entity ID {request.UCID} with MeasureType Code {request.Id} already exists");
            }

            return item;
        }

        public async Task<IEnumerable<UomCategory>> GetAllAsync()
        {
            try
            {
                var result = await _repository.UoMCategory.GetAllAsync(trackChanges: false);
                return result;
            }
            catch (ApplicationException e)
            {
                _logger.LogError($"Failure Get Data for UoM Category: { e.Message}");
                throw new InventoryException("Failure Get Data for UoM Category");
            }
        }
        public IEnumerable<MeasureType> GetMeasureType()
        {
            var result = MeasureType.List();
            return result;
        }
        public async Task<UomCategory> SetObjStatus(UpdateStatusUomCategory request)
        {
            var objTobeChanged = await _repository.UoMCategory.GetDataAsync(request.ucid, trackChanges: false);
            objTobeChanged.setObjStatus(request.userBy, request.isActive);

            try
            {
                await _repository.SaveAsync();
            }
            catch (ApplicationException e)
            {
                _logger.LogError($"Failure update status: { e.Message}");
                throw new InventoryException("Failure update status");
            }

            return objTobeChanged;
        }

    }
}
