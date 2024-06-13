using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Polyglot.Server.models;

namespace Polyglot.Server.Infrastructure
{
    public class PolyglotDbContext : DbContext
    {
        public PolyglotDbContext(DbContextOptions<PolyglotDbContext> options) : base(options)
        {
        }

        public virtual DbSet<WordItem> WordItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WordItem>()
                .OwnsOne<Word>(w=>w.Word);
        }
        public async Task<List<WordItem>> ExecuteStudyStatusProcedureAsync(int parameter)
        {
            try
            {
            var wordIdParameter = new SqlParameter("@id", parameter);

            var result = WordItems.FromSqlRaw("EXEC StudyStatusUpdate @id", wordIdParameter).AsAsyncEnumerable();

            }
            catch (Exception)
            {

                throw;
            }
            //var r= await WordItems.FromSqlRaw("EXEC StudyStatusUpdate @Parameter", parameter)
            //                            .SingleOrDefaultAsync();
            return null;
        }
    }
}
