using System;
namespace lesson3
{
    public class Calculate
    {
        public int Add(int number1, int number2)
        {

            return number1 + number2; ;

        }

        public int Sub(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Muti(int number1, int number2)
        {
            return number1 * number2;
        }

        public double Div(int number1, int number2)
        {
            return number1 / number2;
        }

        public string DisplayMessage()
        {
            return "welcome in our application";
        }

    }
}
