using Domain.Core.Bus;
using Inventory.Application.Events;
using Inventory.Application.Interface;
using Inventory.Application.Requests;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.EventHandlers
{
    public class CreateOrUpdateEventHandler : IEventHandler<CreatedOrUpdatedEvent>
    {
        private readonly IPermissionService _permissionService;
        public CreateOrUpdateEventHandler(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        public Task Handle(CreatedOrUpdatedEvent @event)
        {
            if (@event.isnew == true)
            {
                var request = new AddPermission
                {
                    RoleId = @event.roleid,
                    MenuId = @event.menuid,
                    canCreate = @event.cancreate,
                    canUpdate = @event.canupdate,
                    canDelete = @event.candelete
                };
                _permissionService.Add(request);
            }
            else {
                var request = new EditPermission
                {
                    Id = @event.id,
                    RoleId = @event.roleid,
                    MenuId = @event.menuid,
                    canCreate = @event.cancreate,
                    canUpdate = @event.canupdate,
                    canDelete = @event.candelete
                };
                _permissionService.Update(request);
            }

            return Task.CompletedTask;
        }
    }
}
