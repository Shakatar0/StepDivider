using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD
{
    public class Step
    {
        private int _first;
        private int _second;

        public int First
        {
            get { return _first; }
        }

        public int Second
        {
            get { return _second; }
        }

        public Step(int first, int second)
        {
            _first = first;
            _second = second;
        }
    }
}
