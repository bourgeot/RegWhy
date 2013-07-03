using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.RegularExpressions;

namespace RegWhy
{
    public class RegWhy:IRegWhat
    {
        
        public ICollection<IRegWhat> Recipes { get; set; }
        public string Explanation { get; set; }
        private string RegExString { get; set; }
        public string TextToSearch { get; set; }
        public RegWhy(ICollection<IRegWhat> recipes,string textToSearch="")
        {
            Recipes = recipes;
            
            if (Recipes.Count == 0)
            {
                throw new InvalidDataException("You must have at least one recipe.");
            }
            RegExString = "";
            Explanation = "";
            foreach (var regWhat in Recipes)
            {
                RegExString += regWhat.RegExValue;
                Explanation += regWhat.Explanation;
            }
            TextToSearch = textToSearch;

        }
        
        public Regex ToRegEx()
        {
            return new Regex(RegExString);
        }
        public string GetTextToSearch()
        {
            return TextToSearch;
        }



        public string RegExValue
        {
             get { return RegExString; } 
        }
    }
}