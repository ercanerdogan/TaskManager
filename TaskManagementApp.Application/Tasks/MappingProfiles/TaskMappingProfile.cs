﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagementApp.Application.Tasks.Commands;
using TaskManagementApp.Application.Tasks.Dto;
using TaskManagementApp.Core.Entities;

namespace TaskManagementApp.Application.Tasks.MappingProfiles
{
    public class TaskMappingProfile : Profile
    {
        public TaskMappingProfile()
        {
            CreateMap<CreateTaskCommand, Task>();
            CreateMap<UpdateTaskCommand, Task>();
            CreateMap<Task, TaskDto>();
        }
    }
}
