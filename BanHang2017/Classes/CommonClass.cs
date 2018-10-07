using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BanHang2017.Classes
{
    public class CommonClass
    {
        public string SinhMa(string stringStart)
        {
            Random rd=new Random ();
            string id;
            id = stringStart + rd.Next(0, 1000000000);
            return id;
        }
    }
}
