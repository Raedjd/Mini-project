using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice_DotNET.Core.Aggregates.ProductAggregate.Commands.AddProduct
{
public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator() {
            RuleFor(p => p.Title)
                   .NotEmpty()
                   .NotNull()
                   .MaximumLength(100);
        }  
    }
}
