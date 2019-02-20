using System.Web;
using System.Web.Mvc;

namespace _2_19Lab23Scaffold
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
