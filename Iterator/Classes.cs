using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Numbers
    {
        private int[] _nums;
        public Numbers(int[] nums)
        {
            _nums = nums;
        }
        public IEnumerator<int> GetEnumerator()
        {
            foreach (int i in _nums)
                yield return i + 2;
        }
    }
}
