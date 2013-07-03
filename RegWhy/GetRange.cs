using System.Collections.Generic;

namespace RegWhy
{
    public class GetRange : IRegWhat
    {
        public GetRange(IList<IRegWhat> itemsTocheck, int lowerBound, int higherBound)
        {
            RegWhats = itemsTocheck;
            foreach (IRegWhat regWhat in itemsTocheck)
            {
                RegExString += regWhat.RegExValue;
            }
            LowerBound = lowerBound;
            HigherBound = higherBound;
        }

        public IList<IRegWhat> RegWhats { get; set; }
        public int LowerBound { get; set; }
        public int HigherBound { get; set; }
        private string RegExString { get; set; }

        #region IRegWhat Members

        public string Explanation
        {
            get { return LowerBound.ToString() + " to " + HigherBound.ToString() + " " + RegExString; }
        }

        public string RegExValue
        {
            get
            {
                if (RegExString.Length > 1)
                {
                    RegExString = "(" + RegExString + ")";
                }
                return  RegExString  + "{" + LowerBound.ToString() + "," + HigherBound.ToString() + "}";
            }
        }

        #endregion
    }
}