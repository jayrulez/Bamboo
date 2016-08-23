using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bamboo.ViewModels.Extensions
{
    public static partial class Extensions
    {
        public static string GetFirstError(this ModelStateDictionary source)
        {
            if(source != null)
            {
                foreach (var modelState in source)
                {
                    foreach (var error in modelState.Value.Errors)
                    {
                        return error.ErrorMessage;
                    }
                }
            }

            return string.Empty;
        }
    }
}
