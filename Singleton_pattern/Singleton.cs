using System;
using System.Runtime.CompilerServices;

namespace Singleton_pattern
{
    public class Singleton
    {

        private static Singleton UniqueInstance;

        private Singleton() { }
        //[MethodImpl(MethodImplOptions.Synchronized)]
        public static  Singleton GetSingleton()
        {
            if (UniqueInstance == null)
            {
                UniqueInstance = new Singleton();
            }
            return UniqueInstance;
        }
    }
    // method 1 slow performance
    public class Singleton2
    {

        private static Singleton2 UniqueInstance2;

        private Singleton2() { }
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Singleton2 GetSingleton2()
        {
            
            if (UniqueInstance2 == null)
            {
                 UniqueInstance2 = new Singleton2();
            }
            return UniqueInstance2;
        }
    }
    //method to eagerly created
    public class Singleton3
    {

        private static Singleton3 UniqueInstance3 = new Singleton3();

        private Singleton3() { }
       
        public static Singleton3 GetSingleton2()
        {
            return UniqueInstance3;
        }
    }


}
