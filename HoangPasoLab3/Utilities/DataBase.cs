using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Utilities
{
    class DataBase
    {
        
        private string name;
        private ByteArrayList value = new ByteArrayList();
        private ByteArrayList mask = new ByteArrayList();             
                      
        public void set_Name (string tmp)
        {
            name = string.Copy(tmp);
         }

        public void set_Value(string tmp)
        {
            string newvalue = tmp.Replace(":", "0");
            byte[] tmp_bytes = HexStringToByteArrayConverter.Convert(newvalue);
            value.Add(tmp_bytes);
        }

        public void set_Mask(string tmp)
        {
            string tmp_mask = Regex.Replace(tmp, @"[A-Z,0-9]", "F");
            string maska = tmp_mask.Replace(":", "0");   
            byte[] tmp_bytes = HexStringToByteArrayConverter.Convert(maska);
            mask.Add(tmp_bytes);
        }

        public string get_Name()
        {
            return name;
        }

        public ByteArrayList get_Value()
        {

            return value;
        }

        public ByteArrayList get_Mask()
        {
            return mask;
        }
        
    }
}
