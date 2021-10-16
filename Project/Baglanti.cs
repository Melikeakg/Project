using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    public class Baglanti
    {
        public string Adres = System.IO.File.ReadAllText(@"c:\Baglanti.txt"); 
    }
}
