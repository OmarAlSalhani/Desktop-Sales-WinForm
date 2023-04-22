using System;

namespace ClientApp.classes
{
    /// <summary>
    /// this class is used for check if the text is null or if the text is number or not
    /// </summary>
  class texts_class
    {
        // method to check if string is null or not
        // parameters :
        // text : the string we want to check it
        public static bool is_null(string text)
        {
            if (text.Trim().Length == 0)
            {
                return true;
            }
            if (String.IsNullOrEmpty(text))
            {
                return true;
            }
            if (String.IsNullOrWhiteSpace(text))
            {
                return true;
            }
            return false;
        }
        // method to check if string is number or not
        // parameters :
        // text : the string we want to check it
        public static bool is_number(string text)
        {
            bool a = double.TryParse(text, out _);
            return a;
        }

    }
}
