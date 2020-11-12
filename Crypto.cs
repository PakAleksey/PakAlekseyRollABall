using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.MyScripts
{
    public sealed class Crypto
    {
        public static string CryptoXOR(string text, int key = 42)
        {
            var result = String.Empty;
            foreach (var simbol in text)
            {
                result += (char)(simbol ^ key);
            }
            return result;
        }
    }
}
