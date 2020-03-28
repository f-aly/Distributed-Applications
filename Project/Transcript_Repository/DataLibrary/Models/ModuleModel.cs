using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

/// <summary>
///  For Back-End: Abotu what the data wants to store.
///  We'll get data from other model to load them here. 
/// </summary>
/// 
namespace DataLibrary.Models
{
    public class ModuleModel
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string ModuleTitle { get; set; }
        public int ModuleResult { get; set; }
        public string ModuleTrimester { get; set; }
        public string ModuleComment { get; set; }
    }

    public class ModuleDbContext : DbContext
    {
        public DbSet<ModuleModel> Modules { get; set; }
    }
}
