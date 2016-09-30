using System.Web;
using System.Web.Mvc;

namespace Agency
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //Enforcing HTTPS 
            //filters.Add(new RequireHttpsAttribute());
        }
    }
}
