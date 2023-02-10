using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEnumerator
{
    public class ForwardEnumerator:IEnumerator
    {
        private int[] _array;
        private int index1 = -1; // Sa kent indexnerov e araj gnum
        private int index2 = -2; // isk sa zuyg indexnerov e araj gnum
        
        public ForwardEnumerator(int[] array)
        {
            _array = array;
            
        }
        public object Current
        {
            get
            {
                return _array[index1];
            }
        }

        public bool MoveNext()
        {

            index1++;
           if(index1>=_array.Length)
            {
                return false;
            }


            return true;
            
            
        }
        public void Reset()
        {
            index1 =-1;
        }
    }
}
