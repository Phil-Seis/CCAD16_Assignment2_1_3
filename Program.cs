//Overloading: Write a simple Maths class (don’t use the keyword Math, it will be a conflict with standard class from system).
//Write overloaded methods with logic and give choice to user to call different methods :
//a.Add(int num1, int num2)
//b.Add(decimal num1, decimal num2, decimal num3)
//c.Multiply(float num1, float num2)
//d.Multiply(float num1, float num2, float num3)
//Declare these methods as public and static.

namespace CCAD16_Assignment2_1_3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int output1 = Maths.AddTwoInt(5, 8);
            decimal output2 = Maths.AddThreeDec(5.4m, 9.8m, 6.6m);
            float output3 = Maths.MulTwoNum(10f, 18f);
            float output4 = Maths.MulThreeNum(2, 33, 4);

            Console.WriteLine($"5 + 8 = {output1}");
            Console.WriteLine($"5.4 + 9.8 = {output2}");
            Console.WriteLine($"10 x 18 = {output3}");
            Console.WriteLine($"2 x 33 x 4 = {output4}");
        }


        class Maths
        {
            public static int AddTwoInt(int num1, int num2)
            {
                return num1 + num2;
            }

            public static decimal AddThreeDec(decimal num1, decimal num2, decimal num3)
            {
                return num1 + num2;
            }

            public static float MulTwoNum(float num1, float num2)
            {
                return num1 * num2;
            }

            public static float MulThreeNum(float num1, float num2, float num3)
            {
                return num1 * num2 * num3;
            }

            public static int AddArrayForEach(int[] inputs)
            {
                int result = 0;

                foreach (int input in inputs)
                {
                    result += input;
                }

                return result;
            }

            public static int AddArrayFor(int[] inputs)
            {
                int result = 0;

                for (int i = 0;i < inputs.Length; i++)
                {
                    result += inputs[i];
                }

                return result;
            }
        }
    }
}
