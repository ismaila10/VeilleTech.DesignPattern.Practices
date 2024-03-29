﻿namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.SingletonDesignPattern
{
    public sealed class Singleton
    {
        private static Singleton? instance;

        private int numberOfInstances = 0;

        //Private constructor is used to prevent creation of instances with 'new' keyword outside this class
        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor.\n");
            numberOfInstances++;
            Console.WriteLine(string.Format("Number of instances ={0}\n", numberOfInstances));
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();

                }
                return instance;
            }
        }
    }

    public sealed class SingletonTS
    {
        // Private static readonly SingletonTS instance=new SingletonTS();
        // We are using volatile to ensure that assignment to the instance variable finishes before it’s access.
        private static volatile SingletonTS? instance;
        private static readonly object lockObject = new Object();
        private SingletonTS() { Console.WriteLine("Instantiating thread-safe inside the private constructor.\n"); }
        public static SingletonTS Instance(string value)
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new SingletonTS();
                        instance.Value = value;
                    }
                        

                }
            }
            return instance;
        }

        // We'll use this property to prove that our Singleton really works.
        public string Value { get; set; }
    }
}
