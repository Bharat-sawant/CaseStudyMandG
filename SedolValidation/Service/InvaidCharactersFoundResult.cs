using SedolValidation.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SedolValidation.Service
{
    public class InvaidCharactersFoundResult : ISedolValidationResult
    {
        readonly string input;
        public InvaidCharactersFoundResult(string input)
        {
            this.input = input;
        }
        public string InputString => input;

        public bool IsValidSedol => false;

        public bool IsUserDefined => false;

        public string ValidationDetails => "SEDOL contains invalid characters";// we can make it constant
    }
}
