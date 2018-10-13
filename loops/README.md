#Exercise-5
Create a program
         
         a). To compute the factorial of a number (n!)! 
             ----> a factorial of a number is the product of all numbers between the given number and 1.
             ----> Zero factorial by definition is 1.
             Example:
                      n! = 1 * 2 * 3 * ...*n
            
         b). to compute the factorial of the first n numbers

         c). Write a method to compute the factorial of a number and use it with 2 or three different input ata.

         Note the factorial of a negative number doesnot exist.

          for(i=1; i<=n; ++i)
        {
            factorial *= i;              // factorial = factorial*i;
        }
        wher factorial is unsigned long (ulong) since it cannot hold a negtive integer value.