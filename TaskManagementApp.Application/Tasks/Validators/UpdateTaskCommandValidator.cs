using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagementApp.Application.Tasks.Commands;

namespace TaskManagementApp.Application.Tasks.Validators
{
    public class UpdateTaskCommandValidator : AbstractValidator<UpdateTaskCommand>
    {
        public UpdateTaskCommandValidator()
        {
            RuleFor(t => t.Name).NotEmpty();
            RuleFor(t => t.Description).NotEmpty();
            RuleFor(t => t.Status).NotEmpty();
            RuleFor(t => t.DueDate).NotEmpty();

        }
    }
}
