using System;
using System.Threading.Tasks;
using takehome.Entities;

namespace takehome.Repositories
{
    public class QuoteRepository 
    {
        /// <summary>
        /// This calcuates an insurance premium based on the JSON payload sent to the POST endpoint
        /// Switch statements assign the values of stateFactor and businessFactor, while basePremium is derived from
        /// the applicant's revenue.
        /// </summary>
        /// <param name="applicant">An entity containing revenue, state and bussiness </param>
        /// <returns></returns>
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

        /// <summary>
        /// This function sends the payload containing the applicant data, and returns a payload containing the
        /// premium
        /// </summary>
        /// <param name="applicant">Applicant entity sent from the controller</param>
        /// <returns></returns>
        public async Task<Quote> CreateApplicantAsync(Applicant applicant)
        {
            var quote = calculateQuote(applicant);
            return await Task.FromResult(quote);
        }
    }
}