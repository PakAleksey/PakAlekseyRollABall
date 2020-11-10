using System;
using System.Collections;
using System.Collections.Generic;

namespace Assets.MyScripts.Test
{
    class IEnumeratorANDIEnumerable : IEnumerable
    {
        private List<int> _numbers = new List<int> {2,3,6,7 };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _numbers.GetEnumerator();
        }
    }
}
