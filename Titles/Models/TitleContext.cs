using System.Data.Entity;

namespace Titles.Models
{
    public class TitleContext : DbContext
    {
        public TitleContext() : base("data source = localhost; initial catalog = Titles; integrated security = True; MultipleActiveResultSets=True;App=EntityFramework")
        {

        }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<OtherName> OtherNames { get; set; }
        public DbSet<TitleGenre> TitleGenres { get; set; }
        public DbSet<TitleParticipant> TitleParticipants { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<StoryLine> StoryLines { get; set; }
    }
}