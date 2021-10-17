using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace any_length_uniq_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "abcdefghijklmn";
            string salt = "this is salt";
            int maxLength = 16;
            string alp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            //if (args.Length != 4)
            //    throw new ArgumentException();
            //string x = "";
            //string salt = "";
            //int maxLength = 0;
            //string alp = "";
            //string x = args[0];
            //string salt = args[1];
            //int maxLength;
            //if (!int.TryParse(args[2], out maxLength))
            //    throw new InvalidCastException(nameof(maxLength));
            //strin alp = args[3];
            if (string.IsNullOrEmpty(x))
                throw new ArgumentNullException(nameof(x));
            if (maxLength < 2) 
                throw new ArgumentOutOfRangeException(nameof(maxLength));
            if (string.IsNullOrEmpty(alp))
                throw new ArgumentNullException(nameof(alp));
            if (string.IsNullOrEmpty(salt))
                salt = "this is salt";

            byte[] bX = Encoding.UTF8.GetBytes(x.Reverse().ToArray());
            byte[] bSalt = Encoding.UTF8.GetBytes(salt);
            byte[] bMixed = Mixed(bX, bSalt);
            byte[] bShoten = Shorten(bMixed, maxLength);
            Console.WriteLine(ReplaceAlp(bShoten, alp));
        }

        static byte[] Mixed(byte[] bX, byte[] bSalt)
        {
            byte[] bA = bX.Length >= bSalt.Length ? bX : bSalt;
            byte[] bB = bX.Length >= bSalt.Length ? bSalt : bX;
            List<byte> ret = new List<byte>();
            for (int i=0; i<bA.Length; i++)
            {
                ret.Add(bA[i]); ret.Add(bB[i%bB.Length]);
            }
            return ret.ToArray();
        }
        static byte[] Shorten(byte[] bMixed, int maxLength)
        {
            List<byte> ret = bMixed.ToList();
            int i = 0;
            int j = 1;
            while(maxLength < ret.Count)
            {
                ret[i] = (byte)((ret[i] + ret[j]) % byte.MaxValue);
                ret.RemoveAt(j);
                i = (i + 1) % maxLength;
                j = (j + 1) % maxLength;
            }
            return ret.ToArray();
        }
        static string ReplaceAlp(byte[] bShoten, string alp)
        {
            StringBuilder sb = new StringBuilder();
            char[] arr = alp.ToCharArray();

            for(int i=0; i< bShoten.Length; i++)
            {
                int t = bShoten[i] % alp.Length;
                sb.Append(arr[t]);
            }
            return sb.ToString();
        }
    }
}
