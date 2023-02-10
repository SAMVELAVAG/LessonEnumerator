using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEnumerator
{
    public class Opposite:IEnumerator
    {
        private readonly int[] _array;
        private readonly bool _isEven;
        private int index;
        public object Current
        {
            get { return _array[index]; }
        }

        public Opposite(int[] array, bool isEven)
        {
            _array = array;
            _isEven = isEven;
            if(isEven)
            {
                index = array.Length;
            }
            else
            {
                index= -1;
            }
        }

        public bool MoveNext()
        {
            index--;
            if (index >= _array.Length)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
