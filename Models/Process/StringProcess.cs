using System.Text.RegularExpressions;

namespace TRANHOANGCHUNGBTH2.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey ( string key )
        {
            string numberOnly = Regex.Replace(key, "[^0-9.]", "");
            Console.WriteLine(numberOnly);  
            string letterOnly = Regex.Replace(key, @"[^A-Z]+", ""); 
            Console.WriteLine (letterOnly); 
            int newNumberKey = Int32.Parse(numberOnly) + 1;
            Console.WriteLine (newNumberKey);
            if(newNumberKey < 10) { return (letterOnly+ "0" + newNumberKey); }
            return (letterOnly + newNumberKey.ToString());
        }
    }
}
