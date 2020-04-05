using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TRS.Core.Models.Module;

namespace TRS.Web.Models.Module
{
    public class ListViewModel
    {
        public List<ModuleDto> Modules { get; set; }

        public ListViewModel()
        {
            Modules = new List<ModuleDto>();
        }
    }
}