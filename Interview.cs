using System;
namespace lesson3
{
    public class Interview
    {
        public void GetQuistion1()
        {
            Console.WriteLine("Enter you name?");
        }

        public string GetAnswer1(string answer)
        {
            return $"your answer is : {answer}";
        }

        public void GetQuistion2()
        {
            Console.WriteLine("Enter your Age");
        }

        public int GetAnswer2(int age)
        {
            return age++;
        }

        public void GetQuistion3()
        {
            Console.WriteLine("Are you marrid?");
        }

        public bool GetAnswer3(string answwer)
        {
            if (answwer == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetInfo(string name, int age, bool isMarrid)
        {
            return $"You name is {name} , your age is {age} and are you marrid{isMarrid}";
        }


    }
}
