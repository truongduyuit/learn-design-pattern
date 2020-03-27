using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Design_Pattern
{
    class SingletonExample3
    {
        private static SingletonExample3 _instance;
        private static readonly object lockObject = new object();
        private int _age;

        public static SingletonExample3 GetInstance()
        {
            if (_instance == null)
            {
                lock(lockObject)
                {
                    if (_instance == null)
                    {
                        Random rd = new Random();
                        _instance = new SingletonExample3(rd.Next(18, 23));
                    }
                }
            }
            return _instance;
        }

        public void Hello()
        {
            Console.WriteLine("Hello, my name is Duy3. I'm " + _age);
        }

        private SingletonExample3() { }
        private SingletonExample3(int age)
        {
            this._age = age;
        }
    }
}
