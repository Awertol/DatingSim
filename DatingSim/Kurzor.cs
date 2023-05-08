using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DatingSim
{
    public static class Kurzor
    {
        public static Cursor C1 = new Cursor(Application.GetResourceStream(new Uri("soubory/kurz.cur", UriKind.Relative)).Stream);
    }
}
