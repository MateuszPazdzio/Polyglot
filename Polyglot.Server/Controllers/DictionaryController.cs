using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Polyglot.Server.Infrastructure;
using Polyglot.Server.models;
using Polyglot.Server.services;

namespace Polyglot.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DictionaryController : ControllerBase
    {
        private readonly ILogger<DictionaryController> _logger;
        private readonly IPolyglotRepository _polyglotRepository;

        public DictionaryController(ILogger<DictionaryController> logger,
            IPolyglotRepository polyglotRepository)
        {
            _logger = logger;
            this._polyglotRepository = polyglotRepository;
        }

        [HttpGet(Name = "GetWordsFromDictionary")]
        public async Task<ActionResult<IEnumerable<Word>>> Get()
        {
            var result = await _polyglotRepository.GetWords();
            if (result!=null && result.Count() > 0)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("UpdateStudyStatus/{id}")]
        public async Task<ActionResult> UpdateStudyStatus(int id,[FromBody] bool needToBeStudied)
        {
            var result = _polyglotRepository.UpdateStudyStatus(id);
            if(result.IsCompleted)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
