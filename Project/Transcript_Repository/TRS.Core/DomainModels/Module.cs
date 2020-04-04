using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.Core.DomainModels
{
    public class Module
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string ModuleTitle { get; set; }
        public int ModuleResult { get; set; }
        public string ModuleTrimester { get; set; }
        public string ModuleComment { get; set; }
    }
}
