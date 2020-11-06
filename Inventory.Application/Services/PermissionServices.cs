using Inventory.Application.Interface;
using Inventory.Application.Mapping;
using Inventory.Application.Requests;
using Inventory.Domain.Interface;
using Inventory.Domain.Models;
using LoggerService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Services
{
    public class PermissionServices : IPermissionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IPermissionMapper _permissionMapper;
        public PermissionServices(IRepositoryManager repository, ILoggerManager logger, IPermissionMapper permissionmapper)
        {
            _repository = repository;
            _logger = logger;
            _permissionMapper = permissionmapper;
        }
        public async Task Add(AddPermission request)
        {
            var item = _permissionMapper.Map(request);
            _repository.Permission.AddPermission(item);
            await _repository.SaveAsync();
        }

        public async Task Update(EditPermission request)
        {
            var itemToChange = _permissionMapper.Map(request);
            _repository.Permission.EditPermission(itemToChange);
            await _repository.SaveAsync();
        }
    }
}
