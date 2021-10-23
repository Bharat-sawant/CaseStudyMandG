using Microsoft.AspNetCore.Http;
using SedolValidation.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SedolValidation.Service
{
    public class ValidChecksumUserDefinedResult : ISedolValidationResult
    {
        readonly string input;
        public ValidChecksumUserDefinedResult(string input)
        {
            this.input = input;
        }

        public string InputString => input;
        public bool IsValidSedol => true;

        public bool IsUserDefined => true;

        public string ValidationDetails => default(string);
    }
}
