using SedolValidation.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SedolValidation.Service
{
    public class ValidChecksumNonUserDefineResult : ISedolValidationResult
    {
        readonly string input;
        public ValidChecksumNonUserDefineResult(string input)
        {
            this.input = input;
        }
        public string InputString => input;

        public bool IsValidSedol => true;

        public bool IsUserDefined => false;

        public string ValidationDetails => default(string);
    }
}
