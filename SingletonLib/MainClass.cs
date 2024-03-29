﻿namespace Singleton_Multiton
{
    public static class MainClass
    {
        public static void Run()
        {
            var singleton = Singleton.Instance();
            var singleton2 = Singleton.Instance();

            var multiton = Multiton.Instance("1");
            multiton = Multiton.Instance("2");

            var limitedMultiton = LimitedMultiton.Instance(LimitedMultiton.Count.ONE);
            limitedMultiton = LimitedMultiton.Instance(LimitedMultiton.Count.TWO);

            Console.WriteLine(singleton.Equals(singleton2));
        }
    }
}
