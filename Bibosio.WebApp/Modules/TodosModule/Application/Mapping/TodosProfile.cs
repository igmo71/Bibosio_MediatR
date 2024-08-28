using AutoMapper;
using Bibosio.WebApp.Common.Interfaces;
using Bibosio.WebApp.Modules.TodosModule.Application.Commands.Create;
using Bibosio.WebApp.Modules.TodosModule.Application.Dto;
using Bibosio.WebApp.Modules.TodosModule.Domain;

namespace Bibosio.WebApp.Modules.TodosModule.Application.Mapping
{
    public class TodosProfile : Profile
    {
        //private readonly ICurrentUserService _currentUserService;

        public TodosProfile(/*ICurrentUserService currentUserService*/)
        {
            //_currentUserService = currentUserService;

            //CreateMap<CreateTodoDto, CreateTodoCommand>()
            //    .ForMember(command => command.Name, opt => opt.MapFrom(dto => dto.Name))
            //    .ForMember(command => command.Description, opt => opt.MapFrom(dto => dto.Description))
            //    .ForMember(command => command.UserId, opt => opt.MapFrom<CurrentUserResolver>())
            //    //.ForMember(command => command.CreateDateTime, opt => opt.MapFrom(DateTime.Now))
            //    ;
            CreateMap<UpdateTodoDto, Todo>();
        }
    }
}
