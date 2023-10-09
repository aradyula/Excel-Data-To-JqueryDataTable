using System.Web;
using System.Web.Mvc;

namespace Excel_Data_To_JqueryDataTable
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
