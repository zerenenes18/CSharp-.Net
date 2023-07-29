using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JopApplicationLibrary.Services
{
    public class IdentityValidator : IIdentityValidator
    {
        public bool IsValid(string identityNumber)
        {
            if(identityNumber == "123") return false;
            return true;
        }
    }
}
