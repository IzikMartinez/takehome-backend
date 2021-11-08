using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
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
            return new QuoteDto
            {
                Price = quote.Price
            };
        }
    }
}