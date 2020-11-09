using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assets.MyScripts.Test
{
    public static class ExampleExtensions
    {
        public static T AddTo<T>(this T self, ICollection<T> coll)
        {
            coll.Add(self);
            return self;
        }

        public static bool IsEven(this int i)
        {
            return i > 0;
        }
        
    }
}
