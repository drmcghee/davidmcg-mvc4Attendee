using System.Web;
using System.Web.Mvc;

namespace davidmcg_mvc4Attendee
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}