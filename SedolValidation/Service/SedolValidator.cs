using SedolValidation.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SedolValidation.Service
{
    public class SedolValidator : ISedolValidator
    {
      public   ISedolValidationResult ValidateSedol(string input)
        {
            // soution 1
            
            if (string.IsNullOrEmpty(input) ||input.Length != 7 )
                return new ChracterValidationResult(input);
            else if (!InvalidCharcter(input))
                return new InvaidCharactersFoundResult(input);
            else if(input[0].ToString()=="9")
            {
                if (IsValidSedol(input.ToLower()))
                    return new ValidChecksumUserDefinedResult(input);
                else
                    return new InvalidChecksumUserDefinedResult(input);
            }
            else
            {
                if (IsValidSedol(input.ToLower()))
                    return new ValidChecksumNonUserDefineResult(input);
                else
                    return new InvalidChecksumNonUserDefinedResult(input);
            }

            // above soulution can be imaplement by using single calss as well in that case i will set value  dyamically to ISedolValidationResult class
            // 

            // soution 2  here i have one class only ValidationResult

            //if (input.Length != 7 || string.IsNullOrEmpty(input))
            //    return new ValidationResult(input, false, false, "Input string was not 7-characters long");
            //...........
            //.........




        }
        public bool InvalidCharcter(string input)
        {
            // ^ indicate begin with 
         Regex regex = new Regex(@"^([a-zA-Z0-9]{6})\d$");
            Match match = regex.Match(input);           
            return match.Success;
        }

        public bool IsValidSedol(string input)
        {
            bool result = false;
            int checksum = 0;
            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        checksum += GetCharcterValue(input[i]) * 1;
                        break;
                    case 1:
                        checksum += GetCharcterValue(input[i]) * 3;
                        break;
                    case 2:
                        checksum += GetCharcterValue(input[i]) * 1;
                        break;
                    case 3:
                        checksum += GetCharcterValue(input[i]) * 7;
                        break;
                    case 4:
                        checksum += GetCharcterValue(input[i]) * 3;
                        break;
                    case 5:
                        checksum += GetCharcterValue(input[i]) * 9;
                        break;

                }
            }

            int CheckDigit = (10 - checksum % 10) % 10;
            if (CheckDigit == Convert.ToInt16(input[6].ToString()))
                result = true;
            return result;
        }


        public int GetCharcterValue(char a)
        {
            return char.IsLetter(a) ? GETSedolCodeForAlphabet(a) :Convert.ToInt32(a.ToString());
        }

       public int GETSedolCodeForAlphabet(char a)
        {
            int result = 0;
            switch (a)
            {
                case 'a':
                    result= 10;
                    break;
                case 'b':
                    result = 11;
                    break;
                case 'c':
                    result = 12;
                    break;
                case 'd':
                    result = 13;
                    break;
                case 'e':
                    result = 14;
                    break;
                case 'f':
                    result = 15;
                    break;
                case 'g':
                    result = 16;
                    break;
                case 'h':
                    result = 17;
                    break;
                case 'i':
                    result = 18;
                    break;
                case 'j':
                    result = 19;
                    break;
                case 'k':
                    result = 20;
                    break;
                case 'l':
                    result = 21;
                    break;
                case 'm':
                    result = 22;
                    break;
                case 'n':
                    result = 23;
                    break;
                case 'o':
                    result = 24;
                    break;
                case 'p':
                    result = 25;
                    break;
                case 'q':
                    result = 26;
                    break;
                case 'r':
                    result = 27;
                    break;
                case 's':
                    result = 28;
                    break;
                case 't':
                    result = 29;
                    break;
                case 'u':
                    result = 30;
                    break;
                case 'v':
                    result = 31;
                    break;
                case 'w':
                    result = 32;
                    break;
                case 'x':
                    result = 33;
                    break;
                case 'y':
                    result = 34;
                    break;
                case 'z':
                    result = 35;
                    break;

            }

            return result;


        }
       
    }
}
