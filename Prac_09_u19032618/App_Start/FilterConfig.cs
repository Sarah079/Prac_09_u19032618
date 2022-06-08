using System.Web;
using System.Web.Mvc;

namespace Prac_09_u19032618
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
