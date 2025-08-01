using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLengthEncoding
{
    public class RunLengthEncoder
    {
        public static string Encode(string rlestring)
        {
            try
            {
                if (string.IsNullOrEmpty(rlestring)) return "";
                var encoded = new StringBuilder();
                int count = 1;
                int stringlength = rlestring.Length;
                for (int i = 1; i < stringlength; i++)
                {
                    if (rlestring[i] == rlestring[i - 1])
                    {
                        count++;
                    }
                    else
                    {
                        encoded.Append(rlestring[i - 1]);
                        encoded.Append(count);
                        count = 1;
                    }
                }
                encoded.Append(rlestring[stringlength - 1]);
                encoded.Append(count);

                return encoded.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error in encoding function { e.ToString()}");
                return "";
            }
        }
    }
}
