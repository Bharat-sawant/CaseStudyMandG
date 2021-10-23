using SedolValidation.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SedolValidation.Service
{
    public class InvalidChecksumUserDefinedResult : ISedolValidationResult
    {
        readonly string input;
        public InvalidChecksumUserDefinedResult(string input)
        {
            this.input = input;
        }
        public string InputString => input;

        public bool IsValidSedol => false;

        public bool IsUserDefined => true;

        public string ValidationDetails => "Checksum digit does not agree with the rest of the input"; 
    }
}
