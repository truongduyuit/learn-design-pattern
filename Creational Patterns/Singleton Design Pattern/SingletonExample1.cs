using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Design_Pattern
{
    public class SingletonExample1
    {
        private static SingletonExample1 _instance = new SingletonExample1();

        public static SingletonExample1 GetInstance()
        {
            return _instance;
        }

        public void Hello()
        {
            Console.WriteLine("Hello, my name is Duy1" );
        }

        public SingletonExample1()
        {
        }
    }
}
