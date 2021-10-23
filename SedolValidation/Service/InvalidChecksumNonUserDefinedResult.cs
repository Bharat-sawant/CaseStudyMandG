using SedolValidation.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SedolValidation.Service
{
    public class InvalidChecksumNonUserDefinedResult : ISedolValidationResult
    {
        readonly string input;
        public InvalidChecksumNonUserDefinedResult(string input)
        {
            this.input = input;
        }
        public string InputString => input;

        public bool IsValidSedol => false;

        public bool IsUserDefined => false;

        public string ValidationDetails => "Checksum digit does not agree with the rest of the input";
    }
}
