using System;

namespace lesson3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Interview interview = new Interview();

            interview.GetQuistion1();
            var username = interview.GetAnswer1(Console.ReadLine());

            interview.GetQuistion2();
            var age = interview.GetAnswer2(Convert.ToInt32(Console.ReadLine()));

            interview.GetQuistion3();
            var IsMarrid = interview.GetAnswer3(Console.ReadLine());


            Console.WriteLine(interview.GetInfo(username, age, IsMarrid));
            Console.ReadLine();


        }

    }
}
