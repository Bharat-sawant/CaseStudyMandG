using Microsoft.AspNetCore.Http;
using SedolValidation.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SedolValidation.Service
{
    public class ChracterValidationResult : ISedolValidationResult
    {
        readonly string input;
        public ChracterValidationResult(string input)
        {
            this.input = input;
        }
        public string InputString => input;

        public bool IsValidSedol => false;

        public bool IsUserDefined => false;

        public string ValidationDetails => "Input string was not 7-characters long";// we can make it constant
    }
}
