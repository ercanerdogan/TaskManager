using System;
using System.Collections.Generic;
using System.Text;
using TaskManagementApp.Application.Interfaces;

namespace TaskManagementApp.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public ITaskRepository Tasks { get; }
        public UnitOfWork(ITaskRepository taskRepository)
        {
            Tasks = taskRepository;

        }
    }
}
