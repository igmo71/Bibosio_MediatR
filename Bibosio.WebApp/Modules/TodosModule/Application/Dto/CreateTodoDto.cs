﻿namespace Bibosio.WebApp.Modules.TodosModule.Application.Dto
{
    public class CreateTodoDto
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}