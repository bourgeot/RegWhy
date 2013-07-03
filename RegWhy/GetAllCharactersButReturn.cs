namespace RegWhy
{
    public class GetAllCharactersButReturn : IRegWhat
    {
        #region IRegWhat Members

        public string Explanation
        {
            get { return "Get all characters but return"; }
        }

        public string RegExValue
        {
            get { return "."; }
        }

        #endregion
    }
}