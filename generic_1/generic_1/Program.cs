using System;
using System.Collections.Generic;


namespace generic_1
{
    class genClass<T>
    {
        public void Display(T genericParameter)
        {
            string a = "abc";
            Console.WriteLine("Parameter type: {0},value:{1}", typeof(T).ToString(),genericParameter); 

        }
        public void Displays(T genericParameter)
        {
            string a = "abc";
            Console.WriteLine("Parameter type: {0},value:{1}", typeof(T).ToString(), genericParameter);

        }
    }
    class emp1
    {
        public int employeeID { get; set; }
        public string employeeName { get; set; }
    }
    class genMethod
    {
        public void Genmethod()
        {
            List<string> lststr = new List<string>();
            lststr.Add("ADB");
            lststr.Add("ahhh");

            ProcessedItem<string>(lststr);
        }
        public void ProcessedItem<T>(List<T>lst)
        {
            Console.WriteLine("**");
            foreach(T item in lst)
            {
                Console.WriteLine(item);
            }
        }
}

    class GenericInterface
    {
        public void GenInterfaceMethod()
        {
            char[] vowels = new char[5];
            vowels[0] = 'a';
            vowels[0] = 'e';
            vowels[0] = 'i';
            vowels[0] = 'o';
            vowels[0] = 'u';

            
        }

    }
   
    class GenricListExample
    {
        static void Main(string[] args)
        {
            genClass<int> lstInt = new genClass<int>();
            
            List<emp1> e1 = new List<emp1>();

            e1.Add(new emp1 { employeeID = 101, employeeName = "Hrishikesh" });
            e1.Add(new emp1 { employeeID = 102, employeeName = "Hrishi" });
            genClass < emp1 > lstObj = new genClass<emp1>();

            foreach (emp1 obj in e1)
            {
                Console.WriteLine(obj.employeeID + "" + obj.employeeName);  
            }
            lstInt.Display(10);
            lstInt.Displays(11);
        }
    }
}
