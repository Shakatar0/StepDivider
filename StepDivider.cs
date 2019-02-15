using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD
{
    public class StepDivider : IEnumerable<Step>
    {
        //Step number = 2

        private Step[] _steps = new Step[] { };
        private int _number;
        private int _divider;

        private int initSteps(int reste)
        {
            if (reste == 0)
            {
                _steps = new Step[_divider];
                return 1;
            }
            else
            {
                _steps = new Step[_divider + 1];
                return 2;
            }
        }

        public StepDivider(int number, int divider)
        {
            _number = number;
            _divider = divider;

            int divided = number / divider;
            int reste = number % divider;
            int add = initSteps(reste);

            for (int x = 1; x < divider + add; x++)
            {
                int first_number = divided * (x - 1);
                int second_number = divided * (x);

                if (x == 1) //Check for first iter
                {
                    first_number = 0;
                    second_number = divided * x;
                }

                if (x == divider + 1) //Check for last iter
                {
                    second_number = first_number + reste;
                }

                _steps[x - 1] = new Step(first_number, second_number);
            }
        }

        public IEnumerator<Step> GetEnumerator()
        {
            for (int x = 0; x < _steps.GetLength(0); x += 1)
            {
                yield return new Step(_steps[x].First, _steps[x].Second);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
