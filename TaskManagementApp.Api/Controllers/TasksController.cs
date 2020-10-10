using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManagementApp.Application.Tasks.Commands;
using TaskManagementApp.Application.Tasks.Dto;
using TaskManagementApp.Application.Tasks.Queries;

namespace TaskManagementApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateTaskCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<List<TaskDto>>> GetAll()
        {
            return await Mediator.Send(new GetAllTasksQuery());

        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<TaskDto>> Get(int id)
        {
            return await Mediator.Send(new GettaskByIdQuery { Id = id });
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateTaskCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(int id)
        {
            return await Mediator.Send(new DeleteTaskCommand { Id = id });
        }


    }
}