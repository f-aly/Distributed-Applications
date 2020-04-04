using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRS.Core.DomainModels;

namespace TRS.Data.Mapping
{
    public class CourseMapping : EntityTypeConfiguration<Course>
    {
        public CourseMapping()
        {
            HasKey(x => x.Id);

            Property(x => x.CourseId).IsRequired();

            Property(x => x.CourseLength).IsRequired();

            Property(x => x.CourseName).IsRequired();

            Property(x => x.CourseQualification).IsRequired();
        }
    }
}
