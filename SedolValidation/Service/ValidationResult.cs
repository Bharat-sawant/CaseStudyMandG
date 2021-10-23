using SedolValidation.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SedolValidation.Service
{
    public class ValidationResult : ISedolValidationResult
    {
        readonly string _input;
        readonly bool _IsValidSedol;
        readonly bool _IsUserDefined;
        readonly string _ValidationDetails;
        public ValidationResult(string input, bool IsValidSedol, bool IsUserDefined,string ValidationDetails)
        {
            this._input = input;
            this._IsValidSedol = IsValidSedol;
            this._IsUserDefined = IsUserDefined;
            this._ValidationDetails = ValidationDetails;

        }
        public string InputString => _input;

        public bool IsValidSedol => _IsValidSedol;

        public bool IsUserDefined => _IsUserDefined;

        public string ValidationDetails => _ValidationDetails;
    }
}
