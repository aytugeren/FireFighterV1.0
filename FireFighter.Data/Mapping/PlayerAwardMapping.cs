using FireFighter.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Data.Mapping
{
    public class PlayerAwardMapping : EntityTypeConfiguration<PlayerAward>
    {
        #region ctor
        public PlayerAwardMapping()
        {
            this.HasKey(x => new { x.AwardId, x.PlayerId });

            this.HasRequired<Award>(x => x.Award)
                .WithMany(x => x.PlayerAwards)
                .HasForeignKey(x => x.AwardId);
            
            this.HasRequired<Player>(x => x.Player)
                .WithMany(x => x.PlayerAwards)
                .HasForeignKey(x => x.PlayerId);
        }
        #endregion
    }
}
