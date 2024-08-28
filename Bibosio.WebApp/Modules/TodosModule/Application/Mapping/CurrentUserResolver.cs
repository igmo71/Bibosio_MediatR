using AutoMapper;
using Bibosio.WebApp.Common.Interfaces;
using Bibosio.WebApp.Modules.TodosModule.Application.Commands.Create;
using Bibosio.WebApp.Modules.TodosModule.Application.Dto;

namespace Bibosio.WebApp.Modules.TodosModule.Application.Mapping
{
    public class CurrentUserResolver : IValueResolver<CreateTodoDto, CreateTodoCommand, Guid>
    {
        private readonly ICurrentUserService _currentUserService;

        public CurrentUserResolver(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        public Guid Resolve(CreateTodoDto source, CreateTodoCommand destination, Guid destMember, ResolutionContext context)
        {
            return Guid.Parse("79CBE68E-898D-479A-BC7A-A266CBD45670"); //_currentUserService.Id;
        }
    }
}
