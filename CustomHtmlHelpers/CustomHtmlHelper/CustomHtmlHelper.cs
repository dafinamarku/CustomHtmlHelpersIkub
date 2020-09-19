using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHtmlHelpers.CustomHtmlHelper
{
  public static class CustomHtmlHelper
  {
    //Create  a custom html helper for an image  tag like this: <imgsrc="/Image/img.jpg" alt=“Test" />
    public static MvcHtmlString Image(this HtmlHelper heleper, string bootstrapClass)
    {
      TagBuilder imagetag = new TagBuilder("img");
      imagetag.MergeAttribute("src", "/Image/img.jpg");
      imagetag.MergeAttribute("alt", "Test");
      imagetag.MergeAttribute("class", bootstrapClass);
      return MvcHtmlString.Create(imagetag.ToString(TagRenderMode.SelfClosing));
    }
  }
}