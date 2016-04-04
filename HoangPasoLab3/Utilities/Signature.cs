using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Utilities
{
    class Signature
    {
        private static ByteArrayList file_bytes ;
        private static ByteArrayList Mask_bytes ;
        private static ByteArrayList Value_bytes ;
        

        public Signature()
        {
            
                       
        }

        public  bool getCheckSign()
        {
            bool check = false;
            byte[] tmp_File = new byte[Mask_bytes.getSize()];
            
                for (int i = 0; i < file_bytes.getSize() - Mask_bytes.getSize(); i++)
                {
                    Array.Copy(file_bytes.getArray(), i, tmp_File, 0, Mask_bytes.getSize());

                    if (BitConverter.ToInt32(AddXOR(Multiply(tmp_File, Mask_bytes.getArray()), Value_bytes.getArray()), 0) == 0)
                    {
                        check = true;
                        break;
                    }
                    else
                    {
                        check = false;
                    }
                }
            
            return check;
        }

        private static byte[] Multiply(byte[] a, byte[] b)
        {
            byte[] temp = new byte[a.Length];

            for (int i = 0; i < a.Length; i++)
                temp[i] = (byte)(a[i] & b[i]);

            return temp;

        }

        private static byte[] AddXOR(byte[] a, byte[] b)
        {
            byte[] temp = new byte[a.Length];

            for (int i = 0; i < a.Length; i++)
                temp[i] = (byte)(a[i] ^ b[i]);

            return temp;

        }

        public void set_File(byte[] tmp_bytes)
        {
            file_bytes = new ByteArrayList();
            file_bytes.Add(tmp_bytes);
        }

        public void set_Mask(ByteArrayList tmp)
        {
            Mask_bytes = new ByteArrayList();
            Mask_bytes.Add(tmp.getArray());
        }

        public void set_Value(ByteArrayList tmp)
        {
            Value_bytes = new ByteArrayList();
            Value_bytes.Add(tmp.getArray());
        }


        /*
        //---------------------------------TEST----------------------------------------
        public static void Main(string[] args)
        {
            //string A = "EB::3A::::1EEB::CD209CEB::CD20EB::CD2060";
            string B = "EB033A4D3A1EEB02CD209CEB02CD20EB02CD2060";
            string Mask = "FF00FF0000FFFF00FFFFFFFF00FFFFFF00FFFFFF";
            string Value = "EB003A00001EEB00CD209CEB00CD20EB00CD2060EB";
            
            
            byte[] B_bytes = HexStringToByteArrayConverter.Convert(B);
            byte[] Mask_bytes = HexStringToByteArrayConverter.Convert(Mask);

              Console.Write("\nB_bytes length = {0} || ", B_bytes.Length);
              for (int i = 0; i < B_bytes.Length; i++) Console.Write("{0:X}", B_bytes[i]);
              Console.Write("\nMask_bytes length = {0} || ", Mask_bytes.Length);
              for (int i = 0; i < Mask_bytes.Length; i++) Console.Write("{0:X}", Mask_bytes[i]);

            byte[] result1 = Multiply(B_bytes, Mask_bytes);
            Console.Write("\nresult1 length = {0} || ", result1.Length);
            for (int i = 0; i < result1.Length; i++) Console.Write("{0:X}", result1[i]);

            byte[] Value_bytes = HexStringToByteArrayConverter.Convert(Value);

            byte[] result2 = AddXOR(result1, Value_bytes);
            Console.Write("\nresult2 length = {0} || ", result2.Length);
            for (int i = 0; i < result2.Length; i++) Console.Write("{0:X}", result2[i]);

            int check_result2 = BitConverter.ToInt32(result2, 0);
            Console.Write("\ncheck_result2 = {0} || {1} ", check_result2, check_result2);
            
            
            // dvd_bjfnt13.exe
            FileStream file = new FileStream("dvd_bjfnt13.exe", FileMode.Open);
            BinaryReader bread = new BinaryReader(file);
            byte[] file_bytes = bread.ReadBytes((int)file.Length);
            bread.Close();


            bool check_file = CheckSign(file_bytes, Mask_bytes, Value_bytes);


            Console.Write("\nCheck = {0}", check_file);
            Console.ReadKey(true);
            }

        */
        }
    
}
