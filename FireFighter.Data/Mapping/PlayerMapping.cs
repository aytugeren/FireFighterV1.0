using FireFighter.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Data.Mapping
{
    public class PlayerMapping : EntityTypeConfiguration<Player>
    {
        #region Ctor
        public PlayerMapping()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Username).IsRequired().HasMaxLength(50);
            this.Property(x => x.Password).IsRequired().HasMaxLength(50);
        }
        #endregion
    }
}
