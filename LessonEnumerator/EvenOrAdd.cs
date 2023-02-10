using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEnumerator
{
    public class EvenOrAdd:IEnumerator
    {
        private readonly int[] _array;
        private readonly bool _isEven;
        private int index ;

        public object Current
        {
            get { return _array[index]; }
        }
        public EvenOrAdd(int[] arr,bool isEven)
        {
            _array = arr;
            _isEven = isEven;
            
            if (isEven)
            {
                index = -2;
            }
            else
            {
                index = -1;
            }
        }
        
        public bool MoveNext()
        {
            index += 2;
            return index <= _array.Length - 1;
        }
        public void Reset()
        {
            if (_isEven)
            {
                index = -2;
            }
            else
            {
                index = -1;
            }
        }
       
    }
}
