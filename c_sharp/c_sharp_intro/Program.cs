namespace _c_sharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1
            //Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");

            // #2
            //Console.WriteLine("Enter first number: ");
            //String st1 = Console.ReadLine();
            //int num1=int.Parse(st1);
            //Console.WriteLine("Enter second number: ");
            //String st2 = Console.ReadLine();
            //int num2 = int.Parse(st2);
            //Console.WriteLine("Enter thirth number: ");
            //String st3 = Console.ReadLine();
            //int num3 = int.Parse(st3);
            //Console.WriteLine("Enter fourth number: ");
            //String st4 = Console.ReadLine();
            //int num4 = int.Parse(st4);
            //Console.WriteLine("Enter fiveth number: ");
            //String st5 = Console.ReadLine();
            //int num5 = int.Parse(st5);
            //int summ=num1 + num2 + num3 + num4+num5;
            //int divide=num1*num2 *num3* num4 * num5;
            //int min = 0;
            //int max = 0;
            //if (num1 > num2 && num1 > num3 && num1 > num3 && num1 > num4 && num1 > num5)
            //{
            //    max = num1; 
            //}
            //else if (num2 > num1 && num2 > num3 && num2 > num3 && num2 > num4 && num2 > num5)
            //{
            //    max = num2;
            //}
            //else if (num3 > num1 && num3 > num2 &&  num3 > num4 && num3 > num5)
            //{
            //    max = num3;
            //}
            //else if (num4 > num1 && num4 > num2 && num4 > num3  && num4 > num5)
            //{
            //    max = num4;
            //}
            //else
            //{
            //    max = num5;
            //}
            //if (num1 < num2 && num1 < num3 && num1 < num3 && num1 < num4 && num1 < num5)
            //{
            //    min = num1;
            //}
            //else if (num2 < num1 && num2 < num3 && num2 < num3 && num2 < num4 && num2 < num5)
            //{
            //    min = num2;
            //}
            //else if (num3 < num1 && num3 < num2 && num3 < num4 && num3 < num5)
            //{
            //    min = num3;
            //}
            //else if (num4 < num1 && num4 < num2 && num4 < num3 && num4 < num5)
            //{
            //    min = num4;
            //}
            //else
            //{
            //    min = num5;
            //}
            //Console.WriteLine("Summa: " + summ + "\nDivide: " + divide + "\nMinimum: " + min + "\nMaximum: " + max);
            // #3

            //Console.WriteLine("Enter a 6 digit number: ");
            //String st1 = Console.ReadLine();
            //int number=int.Parse(st1);
            //int n6 = number % 10;
            //int n5 = (number % 100)-n6;
            //int n4 = (number % 1000)-n5-n6;
            //int n3 = (number % 10000)-n4-n5-n6;
            //int n2 = (number % 100000)-n3-n4-n5-n6;
            //int n1 = (number % 1000000)-n2 - n3 - n4 - n5 - n6;
            //Console.Write(n6);
            //Console.Write(n5/10);
            //Console.Write(n4/100);
            //Console.Write(n3/1000);
            //Console.Write(n2/10000);
            //Console.Write(n1/100000);

            // #4
            //Console.WriteLine("Enter low enge of range: ");
            //string input = Console.ReadLine();
            //int low=int.Parse(input);
            //Console.WriteLine("Enter high enge of range: ");
            //input = Console.ReadLine();
            //int high = int.Parse(input);
            //int a = 0, b = 1, temp;
            //for(int i = 0; i <= high; i++)
            //{
            //    temp = a;
            //    a = b;
            //    b = temp + b;
            //    if (a >= 0 && a <= high) {
            //        Console.WriteLine($"{a},");
            //    }


            //}

            // #5
            //Console.WriteLine("Enter smaller number: ");
            //string input = Console.ReadLine();
            //int small = int.Parse(input);
            //Console.WriteLine("Enter bigger number: ");
            //input = Console.ReadLine();
            //int big = int.Parse(input);

            //for(int i=small; i<=big; i++) { 
            //for(int j=0; j <i;j++)
            //    {
            //        Console.Write(i);
            //    }
            //Console.WriteLine();
            //}

            // # 6
            Console.WriteLine("Enter length of line: ");
            string input = Console.ReadLine();
            int length = int.Parse(input);
            Console.WriteLine("Enter direction of line \n(H,h - horizontal) \n(V,v - vertival) ");
            input = Console.ReadLine();
            char direction = char.Parse(input);
            if(direction=='H'|| direction == 'h')
            {
                for( int i =0;i< length; i++ ) { 
                Console.Write("+");
                }
            }
            else if(direction=='V'|| direction == 'v')
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine("+");
                }
            }

        }
    }
}
