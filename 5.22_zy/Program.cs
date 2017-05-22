using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._22_zy
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot1 = new Robot();

            robot1.Name = "小度";

            robot1.Eat(5);

            Robot robot2 = new Robot();

            robot2.Name = "小娜";

            robot2.Eat(8);

            Console.WriteLine("请选择机器人: 1：小度; 2： 小娜");

            string str = Console.ReadLine();


            Robot robot = null;

            if (str == "1")

            {

                robot = robot1;

            }

            else if (str == "2")

            {

                robot = robot2;

            }

            else

            {

                Console.WriteLine("你要找的机器人不存在!");

                return;

            }



            robot.SayHello();

            while (true)

            {

                string strChat = Console.ReadLine();

                robot.Speak(strChat);

            }
        }
    }
}
