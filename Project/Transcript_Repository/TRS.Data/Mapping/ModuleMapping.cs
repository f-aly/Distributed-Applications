using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRS.Core.DomainModels;

namespace TRS.Data.Mapping
{
    public class ModuleMapping : EntityTypeConfiguration<Module>
    {
        public ModuleMapping()
        {
            HasKey(x => x.Id);

            Property(x => x.ModuleId).IsRequired();

            Property(x => x.ModuleTitle).IsRequired();

            Property(x => x.ModuleTrimester).IsRequired();

        }
    }
}
