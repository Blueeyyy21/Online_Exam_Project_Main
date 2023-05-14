//using System.Web.Mvc;
//using System.Web.Routing;

//namespace Online_Exam_Project_Main.Authentication
//{
//    internal class Authentication : ActionFilterAttribute
//    {
//        public override void OnActionExecuting(ActionExecutingContext context)
//        {
//            if(context.HttpContext.Session.GetString("admin_name") == null)
//            {
//                context.Result = new RedirectToRouteResult(new RouteValueDictionary
//                {
//                    {
//                        "Controller", "Admin"
//                    },
//                    {
//                        "Action" , "Index"
//                    }

//                });
//            }
//        }
//    }
//}