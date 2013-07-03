using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegWhy
{
   public  class GetSpecialCharacter:IRegWhat
    {
        private string RegExString = "";
        public GetSpecialCharacter(string specialCharacter)
        {
            RegExString = specialCharacter;
        }
        public string Explanation
        {
            get {
                switch (RegExString)
                {
                    case ".":
                        {
                            return "All characters but new line";
                        }
                    default:
                        {
                            return "Not coded yet or unknown special character";
                        }
                }
            }
        }

        public string RegExValue
        {
            get { return RegExString; }
        }
    }
}
