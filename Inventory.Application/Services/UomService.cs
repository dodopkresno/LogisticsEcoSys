using Inventory.Application.Interface;
using Inventory.Application.Requests.Uom;
using Inventory.Application.Responses.Uom;
using Inventory.Domain.Enums;
using Inventory.Domain.Interface;
using Inventory.Exception;
using LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Application.Services
{
    public class UomService : IUomService
    {
        private readonly IRepositoryManager _repository;
        private readonly IUomMapper _uomMapper;
        private readonly ILoggerManager _logger;

        public UomService(IRepositoryManager repository, IUomMapper uomMapper, ILoggerManager logger)
        {
            _repository = repository;
            _uomMapper = uomMapper;
            _logger = logger;
        }

        public async Task<UomResponse> AddUomAsync(AddUom request)
        {
            var item = _uomMapper.Map(request);
            var objToSearch = await _repository.Uom.GetDataByType(request.UomCategoryId, trackChanges: false);

            if (objToSearch is null)
            {
                _repository.Uom.AddUom(item);
                await _repository.SaveAsync();
                _logger.LogInfo($"Data {item.UoMId} - {item.name} has been successfully inserted by {item.CreatedBy}.");
            }
            else
            {
                throw new InventoryException($"Uom category : {item.UomCategory.name} should only have one reference unit of measure");
            }
            return _uomMapper.Map(item);
        }

        public async Task<UomResponse> EditUomAsync(EditUom request)
        {
            var objToCheck = await _repository.Uom.GetDataAsync(request.UID, trackChanges: false);
            if (objToCheck is null)
            {
                throw new InventoryException($"Entity with {request.UID} is not present");
            }
            var item = _uomMapper.Map(request, objToCheck);
            var objToSearch = await _repository.Uom.GetDataByType(request.UomCategoryId, trackChanges: false);

            if (objToSearch is null || objToSearch.UoMId == request.UID)
            {
                _repository.Uom.UpdateUom(item);
                await _repository.SaveAsync();
                _logger.LogInfo($"Data {item.UoMCategoryId} - {item.name} has been successfully updated by {item.LastModifiedBy}.");
            }
            else
            {
                throw new InventoryException($"Uom category : {item.UomCategory.name} should only have one reference unit of measure");
            }

            return _uomMapper.Map(item);
        }

        public async Task<IEnumerable<UomResponse>> GetAllAsync()
        {
            var result = await _repository.Uom.GetAllAsync(trackChanges: false);
            return result.Select(i => _uomMapper.Map(i));
        }

        public async Task<UomResponse> GetDataAsync(UomGetData request)
        {
            if (request?.Id == null) throw new ArgumentNullException();
            var result = await _repository.Uom.GetDataAsync(request.Id, trackChanges: false);

            if (result == null)
                throw new InventoryException($"Entity with id: { request.Id } doesn't exist.");

            return _uomMapper.Map(result);
            
        }

        public async Task<UomResponse> DeleteAsync(UpdateStatusUom request)
        {
            var objTobeChanged = await _repository.Uom.GetDataAsync(request.uid, trackChanges: false);
            
            objTobeChanged.setObjStatus(request.userBy, request.isActive);

            _repository.Uom.UpdateUom(objTobeChanged);
            await _repository.SaveAsync();
            _logger.LogInfo($"Data {objTobeChanged.UoMCategoryId} - {objTobeChanged.name} has been successfully deleted by {request.userBy}. " +
                $"Status from { objTobeChanged.IsActive } to { request.isActive }");

            return _uomMapper.Map(objTobeChanged);
        }

        public IEnumerable<UomType> GetUomType()
        {
            var result = UomType.List();
            return result;
        }
    }
}
