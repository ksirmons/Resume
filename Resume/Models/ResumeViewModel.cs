using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class ResumeViewModel
    {
        public string Name { get; set; }

        public string AddressStreet { get; set; }

        public string AddressCity { get; set; }

        public string AddressState { get; set; }

        public string AddressZip { get; set; }

    }
}