using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Configurations
{
    public class ResumeConfiguration : EntityTypeConfiguration<Resume>
    {
        public ResumeConfiguration()
        {
            HasKey(e => e.Id);

            HasOptional(e => e.Address);
        }
    }
}
