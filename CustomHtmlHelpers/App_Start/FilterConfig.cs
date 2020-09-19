using System.Web;
using System.Web.Mvc;

namespace CustomHtmlHelpers
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
