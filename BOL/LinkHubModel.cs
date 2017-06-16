namespace BOL
{
    using System.Data.Entity;

    public partial class LinkHubModel : DbContext
    {
        public LinkHubModel()
            : base("name=LinkHubDbModel")
        {
        }

        public virtual DbSet<tbl_category> tbl_category { get; set; }
        public virtual DbSet<tbl_url> tbl_url { get; set; }
        public virtual DbSet<tbl_user> tbl_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_user>()
                .Property(e => e.Role)
                .IsFixedLength();
        }
    }
}
