using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEnumerator
{

    public class Mover:IEnumerable
    {

        private readonly int[] array;
        private bool _isEven;
        public Mover(int[] array)
        {
            this.array = array;
        }
        public void SetMode(bool isEven)
        {
            _isEven = isEven;
        }

        public IEnumerator GetEnumerator()
        {
            return new Opposite(array,_isEven);
        }
        
    }
}
