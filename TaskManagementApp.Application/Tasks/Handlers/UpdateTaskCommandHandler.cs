using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskManagementApp.Application.Interfaces;
using TaskManagementApp.Application.Tasks.Commands;

namespace TaskManagementApp.Application.Tasks.Handlers
{
    public class UpdateTaskCommandHandler : IRequestHandler<UpdateTaskCommand, int>
    {
        private readonly IUnitOfWork _unifOfWork;
        private readonly IMapper _mapper;

        public UpdateTaskCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unifOfWork = unitOfWork;
            _mapper = mapper;

        }
        public async Task<int> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var result = await _unifOfWork.Tasks.Update(_mapper.Map<TaskManagementApp.Core.Entities.Task>(request));
            return result;
        }
    }
}
