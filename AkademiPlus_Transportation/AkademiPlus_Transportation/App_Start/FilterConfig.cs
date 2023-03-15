using System.Web;
using System.Web.Mvc;

namespace AkademiPlus_Transportation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
