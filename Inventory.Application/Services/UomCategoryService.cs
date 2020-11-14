using Inventory.Application.Interface;
using Inventory.Application.Requests.UomCategory;
using Inventory.Application.Responses.UomCategory;
using Inventory.Domain.Enums;
using Inventory.Domain.Interface;
using Inventory.Exception;
using LoggerService;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Application.Services
{
    public class UomCategoryService : IUomCategoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly IUomCategoryMapper _uomCategoryMapper;
        private readonly ILoggerManager _logger;
        public UomCategoryService(IRepositoryManager repository, IUomCategoryMapper UomCategoryMapper, ILoggerManager logger)
        {
            _repository = repository;
            _uomCategoryMapper = UomCategoryMapper;
            _logger = logger;
        }

        public async Task<DataResponse> AddUomCategoryAsync(AddUoMCategory request)
        {
            var item = _uomCategoryMapper.Map(request);
            var objToSearch = await _repository.UoMCategory.GetDataByType(request.Id, trackChanges: false);

            if (objToSearch is null)
            {
                _repository.UoMCategory.AddUomCategory(item);
                await _repository.SaveAsync();
                _logger.LogInfo($"Data {item.UoMCategoryId} has been successfully inserted by {item.CreatedBy}.");
            }
            else {
                throw new InventoryException($"Double measure type { MeasureType.From(item.Id) } has been detected. Duplicate type with { item.name }.");
            }
            return _uomCategoryMapper.Map(item);
        }
        public async Task<DataResponse> EditUomCategoryAsync(EditUomCategory request)
        {
            var objToCheck = await _repository.UoMCategory.GetDataAsync(request.UCID, trackChanges: false);
            if (objToCheck is null)
            {
                throw new InventoryException($"Entity with {request.UCID} is not present");
            }
            var item = _uomCategoryMapper.Map(request, objToCheck);
            var objToSearch = await _repository.UoMCategory.GetDataByType(request.Id, trackChanges: false);

            if (objToSearch is null || objToSearch.UoMCategoryId == request.UCID)
            {
                _repository.UoMCategory.UpdateUomCategory(item);
                await _repository.SaveAsync();
            }
            else
            {
                throw new InventoryException($"Entity ID {request.UCID} with MeasureType Code {request.Id} already exists");
            }

            return _uomCategoryMapper.Map(item);
        }
        public async Task DeleteUomCategoryAsync(DeleteUomCategory request)
        {
            var objToDelete = await _repository.UoMCategory.GetDataAsync(request.UCID, trackChanges: false);
            if (objToDelete is null)
            {
                throw new InventoryException($"Entity with {request.UCID} is not present");
            }

            _repository.UoMCategory.DeleteUomCategory(objToDelete);
            await _repository.SaveAsync();
        }
        public async Task<DataResponse> GetDataAsync(GetDataRequest request)
        {
            if (request?.Id == null) throw new ArgumentNullException();
            var result = await _repository.UoMCategory.GetDataAsync(request.Id, trackChanges: false);

            if (result == null)
            {
                return null;
                throw new InventoryException($"Entity with id: { request.Id } doesn't exist.");
            }
            else
            {
                return _uomCategoryMapper.Map(result);
            }
        }
        public async Task<IEnumerable<DataResponse>> GetDataListByTypeAsync(GetDataByType request)
        {
            if (request?.Id == null) throw new ArgumentNullException();
            var result = await _repository.UoMCategory.GetDataListByType(request.Id, trackChanges: false);

            if (result == null)
            {
                return null;
            }
            else
            {
                return result.Select(i => _uomCategoryMapper.Map(i));
            }
        }
        public async Task<IEnumerable<DataResponse>> GetAllAsync()
        {
            var result = await _repository.UoMCategory.GetAllAsync(trackChanges: false);
            return result.Select(i => _uomCategoryMapper.Map(i));
        }
        public IEnumerable<MeasureType> GetMeasureType()
        {
            var result = MeasureType.List();
            return result;
        }
        public async Task<DataResponse> SetObjStatusAsync(UpdateStatusUomCategory request)
        {
            var objTobeChanged = await _repository.UoMCategory.GetDataAsync(request.ucid, trackChanges: false);
            objTobeChanged.setObjStatus(request.userBy, request.isActive);

            try
            {
                await _repository.SaveAsync();
            }
            catch
            {
                throw new InventoryException("Failure update status");
            }

            return _uomCategoryMapper.Map(objTobeChanged);
        }
    }
}
