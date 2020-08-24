using FireFighter.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Data.Mapping
{
    public class AwardMapping : EntityTypeConfiguration<Award>
    {
        #region ctor
        public AwardMapping()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Name).HasMaxLength(100).IsRequired();
            this.Property(x => x.Description).IsOptional();
            this.Property(x => x.Point).IsRequired();
        }
        #endregion
    }
}
