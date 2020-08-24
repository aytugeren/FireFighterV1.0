using FireFighter.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Data.Mapping
{
    public class PlaceMapping : EntityTypeConfiguration<Place>
    {
        #region Ctor
        public PlaceMapping()
        {
            this.HasKey(x => x.Id);
        }
        #endregion
    }
}
