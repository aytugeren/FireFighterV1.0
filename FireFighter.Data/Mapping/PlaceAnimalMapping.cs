using FireFighter.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Data.Mapping
{
    public class PlaceAnimalMapping : EntityTypeConfiguration<PlaceAnimal>
    {
        #region Ctor
        public PlaceAnimalMapping()
        {
            this.HasKey(x => new { x.AnimalId, x.PlaceId });

            this.HasRequired<Place>(x => x.Place)
                .WithMany(x => x.PlaceAnimals)
                .HasForeignKey(x => x.PlaceId);
        }
        #endregion
    }
}
