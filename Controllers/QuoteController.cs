using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using takehome.DTOs;
using takehome.Entities;
using takehome.Repositories;

namespace takehome.Controllers
{
        [ApiController]
        [Route("quote")]
    public class QuoteController : ControllerBase
    {
        private readonly QuoteRepository _quoteRepository;
        public QuoteController(QuoteRepository quoteRepository)
        {
            this._quoteRepository = quoteRepository;
        }
        
        
        /// <summary>
        /// This function handles POST endpoints. It receives a payload, which is assigned to a new applicant entity
        /// that entity is sent to the repository, where a quote entity is returned, containing the applicant's
        /// insurance premium
        /// </summary>
        /// <param name="applicantNew">Variable containing POST payload </param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<QuoteDto>> CreateApplicantAsync(Applicant applicantNew)
        {
            Applicant applicant = new()
            {
                Business = applicantNew.Business,
                Revenue = applicantNew.Revenue,
                State = applicantNew.State
            };
            var quote= await _quoteRepository.CreateApplicantAsync(applicant);
            if (quote.Price == 0)
            {
                return NotFound();
            }
            return new QuoteDto
            {
                Premium= quote.Price
            };
        }
    }
}