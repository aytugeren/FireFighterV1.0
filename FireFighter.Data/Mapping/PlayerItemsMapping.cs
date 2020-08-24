using FireFighter.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Data.Mapping
{
    public class PlayerItemsMapping : EntityTypeConfiguration<PlayerItems>
    {
        #region Ctor
        public PlayerItemsMapping()
        {
            this.HasKey(x => new { x.PlayerId, x.ItemId });

            this.HasRequired<Player>(x => x.Player)
                .WithMany(x => x.PlayerItems)
                .HasForeignKey(x => x.PlayerId);

            this.HasRequired<Item>(x => x.Item)
                .WithMany(x => x.PlayerItems)
                .HasForeignKey(x => x.ItemId);
        }
        #endregion
    }
}
