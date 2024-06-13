using Microsoft.EntityFrameworkCore;
using Polyglot.Server.Infrastructure;
using Polyglot.Server.models;

namespace Polyglot.Server.services
{
    public interface IPolyglotRepository
    {
        Task<IEnumerable<WordItem>> GetWords();
        Task UpdateStudyStatus(int id);
    }
    public class PolyglotRepository : IPolyglotRepository
    {
        private readonly PolyglotDbContext _polyglotDbContext;

        public PolyglotRepository(PolyglotDbContext polyglotDbContext)
        {
            this._polyglotDbContext = polyglotDbContext;
        }

        public async Task<IEnumerable<WordItem>> GetWords()
        {
            return await _polyglotDbContext.WordItems.ToListAsync();

        }

        public async Task UpdateStudyStatus(int id)
        {
            var result = _polyglotDbContext.ExecuteStudyStatusProcedureAsync(id);
        }
    }
}
