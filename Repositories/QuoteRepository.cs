using System;
using System.Threading.Tasks;
using takehome.Entities;

namespace takehome.Repositories
{
    public class QuoteRepository 
    {
        private Quote calculateQuote(Applicant applicant)
        {
            var stateFactor = applicant.State switch
            {
                "OH" => 1,
                "FL" => 1.2,
                "TX" => 0.943,
                _ => 0
            };
            var bussinessFactor = applicant.Business switch
            {
                "Architect" => 1,
                "Plumber" => 0.5,
                "Programmer" => 1.25,
                _ => 0
            };
            var basePremium = Math.Ceiling(applicant.Revenue / 1000);
            const decimal hazardFactor = 4;
            
            Quote q1 = new() { Price = (decimal)(stateFactor * bussinessFactor * (double)basePremium * (double)hazardFactor) };
            return q1;
        }

        public async Task<Quote> CreateApplicantAsync(Applicant applicant)
        {
            var quote = calculateQuote(applicant);
            return await Task.FromResult(quote);
        }
    }
}