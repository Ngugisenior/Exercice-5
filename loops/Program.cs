using System;

namespace loops {
    class Program {
        static void Main (string[] args) {
            //ulong factorial;
            int num;
            int NumMin = 6;
            int factorial = 1;
            int NumMax = 10;

            FunctionFactor ();

            void FunctionFactor () {

                //number to be checked will be generated randomly within our program.
                Random rand = new Random ();
                num = rand.Next (NumMin, NumMax);
                Console.Write ("The integer selected is " + num);

                //Factorial calculator
                for (int i = 1; i <= num; ++i) {

                    if (i == num) {
                        factorial = factorial * i;
                        Console.WriteLine (", The factorial of " + num + " is " + factorial);
                    }
                    //factorial
                    factorial = factorial * i;
                }
            }
        }
    }
}