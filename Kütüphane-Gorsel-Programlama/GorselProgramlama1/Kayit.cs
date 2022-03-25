using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama1
{
    class Register
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LibraryNumber { get; set; }

        public Register(string isim,string soyisim, string numara)
        {
            this.Name = isim;
            this.Surname = soyisim;
            this.LibraryNumber = numara;
        }

        public bool kayit()
        {
            if (Name != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
