using System.Collections.Generic;

namespace RegWhy
{
    public class Get : IRegWhat
    {
        #region TypeOfSearch enum

        public enum TypeOfSearch
        {
            OnlyOne,
            ZeroOrOne,
            ZeroOrMore,
            OneOrMore
        }

        #endregion

        public Get(ICollection<IRegWhat> itemsToGet, TypeOfSearch type = TypeOfSearch.OnlyOne)
        {
            RegExString = "";
            CurrentType = type;
            foreach (IRegWhat regWhat in itemsToGet)
            {
                RegExString += regWhat.RegExValue;
                ExplanationString += regWhat.Explanation;
            }
        }

        private string RegExString { get; set; }
        private string ExplanationString { get; set; }
        private TypeOfSearch CurrentType { get; set; }

        #region IRegWhat Members

        public string Explanation
        {
            get { return GetTypeExplanation(CurrentType) + ExplanationString; }
        }

        public string RegExValue
        {
            get
            {
                if (RegExString.Length > 1 && CurrentType != TypeOfSearch.OnlyOne)
                {
                    RegExString = "(" + RegExString + ")";
                }
                return RegExString + GetTypeModifier(CurrentType);
            }
        }

        #endregion

        private string GetTypeModifier(TypeOfSearch typeToCheck)
        {
            switch (typeToCheck)
            {
                case TypeOfSearch.OnlyOne:
                    {
                        return "";
                    }
                case TypeOfSearch.OneOrMore:
                    {
                        return "+";
                    }
                case TypeOfSearch.ZeroOrOne:
                    {
                        return "?";
                    }
                case TypeOfSearch.ZeroOrMore:
                    {
                        return "*";
                    }
                default:
                    {
                        return "";
                    }
            }
        }

        private string GetTypeExplanation(TypeOfSearch typeToCheck)
        {
            switch (typeToCheck)
            {
                case TypeOfSearch.OnlyOne:
                    {
                        return "Only one ";
                    }
                case TypeOfSearch.OneOrMore:
                    {
                        return "One or More";
                    }
                case TypeOfSearch.ZeroOrOne:
                    {
                        return "Zero or One";
                    }
                case TypeOfSearch.ZeroOrMore:
                    {
                        return "Zero or More";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
}