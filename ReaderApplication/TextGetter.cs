using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReaderApplication
{
    public class TextGetter
    {
        public string GetText() 
        {
            return Clipboard.GetText();
        }
    }
}
