using System.Web;
using System.Web.Mvc;

namespace asp.net_mvc_pagging_angularjs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
