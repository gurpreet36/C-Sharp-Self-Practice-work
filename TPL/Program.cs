using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class MyApp
    {
        public static void longTask()
        {
            Thread.Sleep(10000);//10sec
            
        }
        public static void myTask()
        {
           /*  Task task=new Task(new Action(longTask)); */
           Task.Run(new Action(longTask));//new thread generated// await is suspension pt
           Console.WriteLine("New Thread is generated");

           /*  task.Start(); */
        }
        
        public static void Main()
        {
           myTask();
           Console.WriteLine("i am  in main method");
    
        }
    }
}