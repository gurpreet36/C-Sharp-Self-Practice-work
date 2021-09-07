using System;

namespace PracticeWork_Indexer
{
    class FormData
    {
        private object[] dataTaker=new object[5];
        
        public object this[int a]
        {
            get
            {
                return  dataTaker[a];
            }
            set
            {
                dataTaker[a]=value;
            }
        }

    }
    class Program
    {
        public static void Main()
        {
         FormData formData=new FormData();
         formData[0]=157680;
         formData[1]="Gurpreet Singh";
         formData[2]="D-81 mohan garden uttam nagar new delhi-110059";
         formData[3]=9717983635;
         formData[4]="Delhi";
         Console.WriteLine(formData[0]+" "+formData[1]+" "+formData[2]+" "+formData[3]+" "+formData[4]);

        }
    }
}
