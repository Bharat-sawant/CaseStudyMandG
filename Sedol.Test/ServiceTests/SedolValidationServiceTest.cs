using SedolValidation.IService;
using SedolValidation.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Sedol.Test.ServiceTests
{
    public class SedolValidationServiceTest
    {
        private readonly SedolValidator _SedolValidator;
        public SedolValidationServiceTest()
        {
            _SedolValidator = new SedolValidator();            
        }
        [Fact]
        public void   NULLInputTest()
        {
            string input=null;
            var ExpctedResult = new ChracterValidationResult(input);
            //act
            var result =  _SedolValidator.ValidateSedol(input);

            //assert
            Assert.Equal(result.InputString, ExpctedResult.InputString);
            Assert.Equal(result.IsValidSedol, ExpctedResult.IsValidSedol);
            Assert.Equal(result.IsUserDefined, ExpctedResult.IsUserDefined);
            Assert.Equal(result.ValidationDetails, ExpctedResult.ValidationDetails);
        }

        [Fact]
        public void EmptyInputTest()
        {
            string input = string.Empty;
            var ExpctedResult = new ChracterValidationResult(input);
            //act
            var result = _SedolValidator.ValidateSedol(input);

            //assert
            Assert.Equal(result.InputString, ExpctedResult.InputString);
            Assert.Equal(result.IsValidSedol, ExpctedResult.IsValidSedol);
            Assert.Equal(result.IsUserDefined, ExpctedResult.IsUserDefined);
            Assert.Equal(result.ValidationDetails, ExpctedResult.ValidationDetails);
        }
        [Fact]
        public void LengthLessThanSevenCharacterInputTest()
        {
            string input = "12";
            var ExpctedResult = new ChracterValidationResult(input);
            //act
            var result = _SedolValidator.ValidateSedol(input);

            //assert
            Assert.Equal(result.InputString, ExpctedResult.InputString);
            Assert.Equal(result.IsValidSedol, ExpctedResult.IsValidSedol);
            Assert.Equal(result.IsUserDefined, ExpctedResult.IsUserDefined);
            Assert.Equal(result.ValidationDetails, ExpctedResult.ValidationDetails);
        }
        [Fact]
        public void LengthMoreThanSevenCharacterInputTest()
        {
            string input = "123456789";
            var ExpctedResult = new ChracterValidationResult(input);
            //act
            var result = _SedolValidator.ValidateSedol(input);

            //assert
            Assert.Equal(result.InputString, ExpctedResult.InputString);
            Assert.Equal(result.IsValidSedol, ExpctedResult.IsValidSedol);
            Assert.Equal(result.IsUserDefined, ExpctedResult.IsUserDefined);
            Assert.Equal(result.ValidationDetails, ExpctedResult.ValidationDetails);
        }
        [Fact]
        public void InvalidChecksumNonUserDefinedSEDOInputLTest()
        {
            string input = "1234567";
            var ExpctedResult = new InvalidChecksumNonUserDefinedResult(input);
            //act
            var result = _SedolValidator.ValidateSedol(input);

            //assert
            Assert.Equal(result.InputString, ExpctedResult.InputString);
            Assert.Equal(result.IsValidSedol, ExpctedResult.IsValidSedol);
            Assert.Equal(result.IsUserDefined, ExpctedResult.IsUserDefined);
            Assert.Equal(result.ValidationDetails, ExpctedResult.ValidationDetails);
        }
        [Fact]
        public void ValidNonUserDefineSEDOLInputTest()
        {
            string input = "0709954";
            var ExpctedResult = new ValidChecksumNonUserDefineResult(input);
            //act
            var result = _SedolValidator.ValidateSedol(input);

            //assert
            Assert.Equal(result.InputString, ExpctedResult.InputString);
            Assert.Equal(result.IsValidSedol, ExpctedResult.IsValidSedol);
            Assert.Equal(result.IsUserDefined, ExpctedResult.IsUserDefined);
            Assert.Equal(result.ValidationDetails, ExpctedResult.ValidationDetails);
        }
        [Fact]
        public void InvalidChecksumUserDefinedSEDOLInputTest()
        {
            string input = "9123451";
            var ExpctedResult = new InvalidChecksumUserDefinedResult(input);
            //act
            var result = _SedolValidator.ValidateSedol(input);

            //assert
            Assert.Equal(result.InputString, ExpctedResult.InputString);
            Assert.Equal(result.IsValidSedol, ExpctedResult.IsValidSedol);
            Assert.Equal(result.IsUserDefined, ExpctedResult.IsUserDefined);
            Assert.Equal(result.ValidationDetails, ExpctedResult.ValidationDetails);
        }
        [Fact]
        public void InvaidCharactersFoundInputTest()
        {
            string input = "9123_51";
            var ExpctedResult = new InvaidCharactersFoundResult(input);
            //act
            var result = _SedolValidator.ValidateSedol(input);

            //assert
            Assert.Equal(result.InputString, ExpctedResult.InputString);
            Assert.Equal(result.IsValidSedol, ExpctedResult.IsValidSedol);
            Assert.Equal(result.IsUserDefined, ExpctedResult.IsUserDefined);
            Assert.Equal(result.ValidationDetails, ExpctedResult.ValidationDetails);
        }
        [Fact]
        public void ValidUserDefinedSEDOLInputTest()
        {
            string input = "9ABCDE1";
            var ExpctedResult = new ValidChecksumUserDefinedResult(input);
            //act
            var result = _SedolValidator.ValidateSedol(input);

            //assert
            Assert.Equal(result.InputString, ExpctedResult.InputString);
            Assert.Equal(result.IsValidSedol, ExpctedResult.IsValidSedol);
            Assert.Equal(result.IsUserDefined, ExpctedResult.IsUserDefined);
            Assert.Equal(result.ValidationDetails, ExpctedResult.ValidationDetails);
        }

    }
}
