using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_DevAssignment
{
    class CountClass
    {
        public static int GetWordsByLength(String file, int characterNumber)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n', ',' };
            var words = file.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            return (words.Where(x => x.Length == characterNumber).ToList()).Count;
        }
    }
}
