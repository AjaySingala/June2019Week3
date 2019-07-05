using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01WebApp.Filters
{
    public class GlobalAttribute : ResultFilterAttribute
    {
        private readonly string _name;
        private readonly string _value;

        public GlobalAttribute(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add(_name, new string[] { _value });
            base.OnResultExecuting(context);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }
    }
}
