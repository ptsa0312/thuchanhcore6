using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace book
{
    public class CustomerFilter
    {
        public class ValidateModelAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext context)
            {
                if (context.ModelState.IsValid == false)
                {
                    context.Result = new BadRequestResult();
                }
            }
        }
    }
}
