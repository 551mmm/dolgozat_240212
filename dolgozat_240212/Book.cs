using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_240212
{


    internal class Book
    {
        public long ISNB { get; private set; }
        public List<Author> szerzok { get; set; }
        public string cim { get; set; }
        public int kiadasev { get; set; }
        public string nyelv { get; set; }
        public int keszlet { get; private set; }
        public int ar { get; set; }
        

        public Book(long isbn, List<Author> szerzok, string cim, int kiadasev, string nyelv, int keszlet, int ar)
        {

            ISNB= isbn;
            szerzok = szerzok ?? throw new ArgumentNullException(nameof(szerzok));
            cim = cim;
            kiadasev = kiadasev;
            nyelv = nyelv;
            keszlet = keszlet;
            ar = ar;
        }
    }
}
