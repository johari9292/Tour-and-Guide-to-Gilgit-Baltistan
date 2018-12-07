using System.Web;
using System.Web.Mvc;

namespace Tour_and_Guide_to_GilgitBaltistan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
