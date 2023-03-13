using System.Web;
using System.Web.Mvc;

namespace _2080600711_ANHTHU_THBUOI3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
