namespace RegWhy
{
    public class SpecialCharacters
    {
        public const string AllCharactersButNewLine = ".";
        public const string AllCharactersAndNewLine = "[.|\n]";
        public const string NewLine = "\n";
        public const string LeftBracket = "<";
        public const string RightBracket = ">";
        public const string BackSlash = "\\";
        public const string BackSpace = "\b";
        public const string Digit = @"\d";
        public const string NonDigit = @"\D";
        public const string LowerCaseLetter = "[a-z]";
        public const string UpperCaseLetter = "[A-Z]";
        public const string AnyLetter = "[a-zA-Z]";
        public const string Colon = ":";
        public const string SemiColon = ";";
        public const string Tab = "\t";
        public const string Return = "\r";
        public const string QuestionMark = "?";
        public const string WordBoundary = "\b";
        public const string StartOfString = "^";
        public const string EndOfString = "$";
        public const string AnyWordCharacter = @"\w";
        public const string AnyNonWordCharacter = @"\W";
        public const string AnyWhiteSpaceCharacter = @"\s";
        public const string AnyNonWhiteSpaceCharacter = @"\S";
        public const string AnyVowel = @"[aeiouy]";
        public const string Period = @"\.";
        public const string LeftParenthesis = @"\(";
        public const string RightParenthesis = @"\)";

        
    }
}