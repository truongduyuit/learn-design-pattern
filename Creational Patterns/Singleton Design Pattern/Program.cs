using System;
using System.Threading;

/* 
*  A class of which only a single instance can exist 
*/
namespace Singleton_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Example 1
             * Initialize _instance when starting to run the program.
             * Defect: wasting when not in use or unused.         
             */
            #region Singleton Example 1
            SingletonExample1.GetInstance().Hello();
            Console.WriteLine("");
            #endregion


            /* Example 1
             * Only initialize _instance when calling the GetInstance function for the first time.
             * Defect: possiple to create multiple _instance when there are multiple thread
             */
            #region Singleton Example 2


            var thread1 = new Thread(() => {
                SingletonExample2.GetInstance().Hello();
            });

            var thread2 = new Thread(() => {
                SingletonExample2.GetInstance().Hello();
            });

            thread1.Start();
            thread2.Start();
            #endregion

            /* Example 1
             * Only initialize _instance when calling the GetInstance function for the first time.
             * 
             */
            #region Singleton Example 3
            var thread3 = new Thread(() => {
                SingletonExample3.GetInstance().Hello();
            });

            var thread4 = new Thread(() => {
                SingletonExample3.GetInstance().Hello();
            });

            thread3.Start();
            thread4.Start();
            #endregion

            Console.ReadKey();
        }
    }
}
