using System;
using System.Collections.Generic;
using System.Text;

namespace ADS_Converter
{
    public class element
    {

        public string value;
        public element Next;

        public element()
        {

        }

        public element(string n)
        {
            value = n;
        }
    }
}
