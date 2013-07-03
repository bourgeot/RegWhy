using System.Collections.Generic;

namespace RegWhy
{
    public class GetThisMany:IRegWhat
    {
        public GetThisMany(ICollection<IRegWhat> valuesToCheck, int numberOfItems)
        {
            string regExStringToMultiply = "";
            RegExValue = "";
            string explanation = "";
            foreach (var regWhat in valuesToCheck)
            {
                regExStringToMultiply += regWhat.RegExValue;
                explanation += " then " + regWhat.Explanation;
            }
            for (int i = 0; i < numberOfItems; i++)
            {
                RegExValue += regExStringToMultiply;
            }
        }
        public string Explanation
        {
            get { return "Get this many of value that is passed"; }
        }

        public string RegExValue { get; set; }
    }
}