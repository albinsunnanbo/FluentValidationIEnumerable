using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidation_Issue_349_IEnumerableModels.Models
{
    public class MyModelValidator : AbstractValidator<MyModel>
    {
        public MyModelValidator()
        {
            RuleFor(x => x.MyProperty).Length(100, int.MaxValue);
        }
    }
}
