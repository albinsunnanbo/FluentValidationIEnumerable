using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidation_Issue_349_IEnumerableModels.Models
{
    public class MyModel
    {
        [MinLength(100)]
        public string MyProperty { get; set; }
    }
}
