using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    interface IEnumerator<T>
    {
        bool MoveNext();
        T Current { get; }
        void Reset();
    }
}
