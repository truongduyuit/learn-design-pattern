using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Design_Pattern
{
    class SingletonExample2
    {
        private static SingletonExample2 _instance;
        private int _age;

        public static SingletonExample2 GetInstance()
        {
            if (_instance == null)
            {
                Random rd = new Random();
                _instance = new SingletonExample2(rd.Next(18, 23));
            }

            return _instance;
        }
        public void Hello()
        {
            Console.WriteLine("Hello, my name is Duy2. I'm " + _age);
        }

        private SingletonExample2() { }

        private SingletonExample2(int age)
        {
            this._age = age;
        }
    }
}
