//*******************************************************************************************
// The Problem : Convert a string it to a byte array representing the actual text values of each byte.
// For example a string value: 0x0123456789ABCDEF would be 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD and 0xEF 
// represented in a byte array. 
// read more in : http://blogs.msdn.com/b/heikkiri/archive/2012/07/17/hex-string-to-corresponding-byte-array.aspx
//--------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Utilities
{
    class HexStringToByteArrayConverter
    {
        
        private static readonly byte[] Empty = new byte[0];

        private static byte FromCharacterToByte(char character, int index, int shift = 0)
        {
            byte value = (byte)character;
            if (((0x40 < value) && (0x47 > value)) || ((0x60 < value) && (0x67 > value)))
            {
                if (0x40 == (0x40 & value))
                {
                    if (0x20 == (0x20 & value))
                        value = (byte)(((value + 0xA) - 0x61) << shift);
                    else
                        value = (byte)(((value + 0xA) - 0x41) << shift);
                }
            }
            else if ((0x29 < value) && (0x40 > value))
                value = (byte)((value - 0x30) << shift);
            else
                throw new InvalidOperationException(String.Format("Character '{0}' at index '{1}' is not valid alphanumeric character.", character, index));

            return value;
        }

        public static byte[] Convert(string value)
        {
            byte[] bytes = null;
            if (String.IsNullOrEmpty(value))
                bytes = Empty;
            else
            {
                int string_length = value.Length;
                int character_index = (value.StartsWith("0x", StringComparison.Ordinal)) ? 2 : 0; // Does the string define leading HEX indicator '0x'. Adjust starting index accordingly.               
                int number_of_characters = string_length - character_index;

                bool add_leading_zero = false;
                if (0 != (number_of_characters % 2))
                {
                    add_leading_zero = true;

                    number_of_characters += 1;  // Leading '0' has been striped from the string presentation.
                }

                bytes = new byte[number_of_characters / 2]; // Initialize our byte array to hold the converted string.

                int write_index = 0;
                if (add_leading_zero)
                {
                    bytes[write_index++] = FromCharacterToByte(value[character_index], character_index);
                    character_index += 1;
                }

                for (int read_index = character_index; read_index < value.Length; read_index += 2)
                {
                    byte upper = FromCharacterToByte(value[read_index], read_index, 4);
                    byte lower = FromCharacterToByte(value[read_index + 1], read_index + 1);

                    bytes[write_index++] = (byte)(upper | lower);
                }
            }

            return bytes;
        }
        //--------------------TEST---------------------------
        /*
         static void Main(string[] args)
         {
             string HexString = "188da80eb03090f67cbf20eb43a18800f4ff0afd82ff1012";
             byte[] ByteArr = StringConverter .ConvertToByteArray (HexString);
             for (int i =0 ; i< ByteArr .Length ;i++)
             Console.WriteLine("HexStringToByteArr = {0} ", ByteArr[i] );

         }
        */

    }
}
