using System;
namespace LectureExample
{
    public class SinglePurposeThing
    {
        public int SomeValue { get; set;}
    }

    //02. then create an extenstionMethod class
    public static class ExtensionMethods
    {
        //when you use this keyword, it allows to the method "Set2Five" of the class "ExtensionMethods" bind to the class "SinglePurposeThing")
        public static void Set2Five(this SinglePurposeThing arg)
        {
            arg.SomeValue = 5;
        }
    }
    internal class Program02
    {
        //static void Set2Five(SinglePurposeThing sps)
        //{
        //    sps.SomeValue = 5;
        //}

        static void Main(string[] args)
        {
            var sps = new SinglePurposeThing();
            //Set2Five(sps);
            //01. we can't access the method "Set2Five" from the object "sps" but we don't want to define the method inside the class.

            //03. now you can call the method "Set2Five" with an instance

            sps.Set2Five();

            Console.WriteLine(sps.SomeValue.ToString()) ;
        }
    }
}

