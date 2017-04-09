using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_DevAssignment
{
    public class CountClass
    {


        public static Tuple<string, string> OpenFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files|*.txt";
            openFile.Title = "Select a Text File";

            bool? userClickedOK = openFile.ShowDialog();

            if (userClickedOK == true)
            {
                Console.WriteLine(openFile.FileName);
                return Tuple.Create(File.ReadAllText(openFile.FileName, Encoding.UTF8), openFile.FileName);
            }
            else
                return null;
        }

        public static int GetWordsByLength(String file, int characterNumber)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n', ',' };
            var words = file.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            return (words.Where(x => x.Length == characterNumber).ToList()).Count;
        }

        public static int GetCharacterOccurrences(String file, Char character)
        {
            return file.Count(x => x == character);
        }
    }
}
