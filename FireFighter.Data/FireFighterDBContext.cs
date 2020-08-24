using FireFighter.Core.Domain;
using FireFighter.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Data
{
    public class FireFighterDBContext : DbContext
    {
        #region Ctor
        public FireFighterDBContext() : base(@"Server = DESKTOP-VD01PB5\SQLEXPRESS; Database=FireFighters;Trusted_Connection=True")
        {

        }
        #endregion

        #region MappingIncluded
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PlayerMapping());
            modelBuilder.Configurations.Add(new ItemMapping());
            modelBuilder.Configurations.Add(new AnimalMapping());
            modelBuilder.Configurations.Add(new AwardMapping());
            modelBuilder.Configurations.Add(new PlaceAnimalMapping());
            modelBuilder.Configurations.Add(new PlayerItemsMapping());
            modelBuilder.Configurations.Add(new PlaceMapping());
            modelBuilder.Configurations.Add(new PlayerAwardMapping());
        }
        #endregion

        #region DbSets

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<PlaceAnimal> PlaceAnimals { get; set; }
        public DbSet<PlayerItems> PlaceItems { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerAward> PlayerAwards { get; set; }
        public DbSet<AskedQuestion> AskedQuestions { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }

        #endregion

    }
}
