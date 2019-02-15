using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD; //Import SD library

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            StepDivider sd = new StepDivider(13, 3, false); //Create StepDivider object | 13/3 without steprest

            foreach(Step s in sd) //Iterate over sd object which is Step[]
            {
                Console.WriteLine(Environment.NewLine + "-----------------------" + Environment.NewLine); //Display /r/n ----------------------- /r/n
                Console.WriteLine(s.First + " TO " + s.Second); //Display {first number} TO {second number}
                Console.WriteLine(Environment.NewLine + "-----------------------"); //Display /r/n -----------------------

                //Next Step...
            }
        }
    }
}
