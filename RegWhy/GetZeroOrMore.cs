using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegWhy
{
    public class GetZeroOrMore:IRegWhat
    {

        public string RegExstring { get; set; }
        public GetZeroOrMore(IList<IRegWhat> optionalItem )
        {
            RegExstring = "";
            foreach (var regWhat in optionalItem)
            {
                RegExstring += regWhat.RegExValue;
            }
            
        }
        public string Explanation
        {
            get { return "An optional character (zero of more of"; }
        }

        public string RegExValue
        {
            get
            {
                if (RegExstring.Length > 1)
                {
                    RegExstring = "(" + RegExstring + ")";
                }
                return RegExstring + "?";
            }
        }
    }
}
