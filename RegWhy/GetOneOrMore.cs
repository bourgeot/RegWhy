using System.Collections.Generic;

namespace RegWhy
{
    public class GetOneOrMore : IRegWhat
    {
        public GetOneOrMore(IList<IRegWhat> optionalItem)
        {
            RegExstring = "";
            foreach (IRegWhat regWhat in optionalItem)
            {
                RegExstring += regWhat.RegExValue;
            }
        }

        private string RegExstring { get; set; }

        #region IRegWhat Members

        public string Explanation
        {
            get { return "One or more of" + RegExstring; }
        }

        public string RegExValue
        {
            get
            {
                if (RegExstring.Length > 1)
                {
                    RegExstring = "(" + RegExstring + ")";
                }
                return RegExstring + "+";
            }
        }

        #endregion
    }
}