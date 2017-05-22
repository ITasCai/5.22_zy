using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._22_zy
{
    class Robot
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name

        {
            set;
            get;
        }

        /// <summary>
        /// 饥饿级别
        /// </summary>
        private int FullLevel  

        {
            set;
            get;
        }

        
        /// <summary>
        /// 打印机器人的姓名
        /// </summary>
        public void SayHello()

        {

            Console.WriteLine("我叫:{0}", Name);

        }

        public void Eat(int foodCount)

        {

            if (FullLevel > 100)

            {

                return;

            }

            FullLevel += foodCount;

        }

        /// <summary>
        /// 回答的问题
        /// </summary>
        /// <param name="str"></param>
        public void Speak(string str)

        {

            if (FullLevel <= 0)

            {

                Console.WriteLine("饿死了,不说了!");

                return;

            }

            if (str.Contains("名字"))

            {

                this.SayHello(); 

            }

            else if (str.Contains("女朋友"))

            {

                Console.WriteLine("女朋友是什么东西，能吃吗!");

            }

            else if (str.Contains("狗蛋"))

            {

                Console.WriteLine("狗蛋是什么东西!");

            }
        

            else if (str.Contains("我帅"))

            {

                Console.WriteLine("好帅，我能做你的小弟吗？");

            }
            else if (str.Contains("不能"))

            {

                Console.WriteLine("我日!");

            }
            else

            {

                Console.WriteLine("不好意思,听不懂!");

            }

            FullLevel--;

        }
    }
}
