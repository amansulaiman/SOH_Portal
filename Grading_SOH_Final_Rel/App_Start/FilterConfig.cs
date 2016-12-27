using System.Web;
using System.Web.Mvc;

namespace Grading_SOH_Final_Rel
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
