using System;

namespace RegWhy
{
    public class GetLiteral:IRegWhat
    {
        public GetLiteral(string literalVale)
        {
            if (string.IsNullOrEmpty(literalVale))
            {
                throw new FormatException("You cannot pass blank");
            }
            this.RegExValue = literalVale;
        }
        public string Explanation
        {
            get { return "Get exactly " + RegExValue; }
        }

        public string RegExValue { get; set; }
    }
}