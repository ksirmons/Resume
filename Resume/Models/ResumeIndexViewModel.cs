using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Web.Models
{
    public class ResumeIndexViewModel
    {
        public IEnumerable<ResumeIndexItemViewModel> ResumeItems { get; set; }
    }
}