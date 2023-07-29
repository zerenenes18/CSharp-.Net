using JopApplicationLibrary.Models;
using JopApplicationLibrary.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JopApplicationLibrary
{
    public class ApplicationEvaluator
    {
        private const int minAge = 18;
        private List<string>? techStackList = new() { "C#", "RabbitMQ", "Microservice", "Visual Studio",".NET" };
        private IIdentityValidator _identityValidator;
        private string identityNumber;
        public ApplicationEvaluator(IIdentityValidator identityValidator)
        {
            _identityValidator = identityValidator;
        }

        public ApplicationResult Evaluate(JobApplication form)
        {
            var rate = GetTechStackSmilarityRate(form.TechStackList);
            var identityNumber = form.Applicant.IdentityNumber;

            if (form.Applicant.Age < minAge)
                return ApplicationResult.AutoRejected;
            else if (rate < 50)
                return ApplicationResult.AutoRejected;  
            else if (!_identityValidator.IsValid(identityNumber))
                return ApplicationResult.TransferredToHR;

            else
            return ApplicationResult.REPEAT;
        }

        private int GetTechStackSmilarityRate(List<string> techStacks)
        {
            var matchedCount = techStacks.Where(i=> techStackList.Contains(i, StringComparer.OrdinalIgnoreCase)).Count();

            return (int)((double)matchedCount / matchedCount) * 100; 
        }




    }


    public enum ApplicationResult
    {
        AutoRejected,
        TransferredToHR,
        TransferredToLead,
        TransferredToCTO,
        AutoAccepted,
        REPEAT
    }
}
