using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomHtmlHelpers.Models
{
  public class StudentClass
  {
    [Display(Name ="Id")]
    public int id { get; set; }
    [Display(Name = "Name")]
    public string name { get; set; }
    public IEnumerable<Student> students { get; set; }
  }
}