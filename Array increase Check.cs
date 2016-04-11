using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int counter=0;
            Console.WriteLine("How many element will array");
            int arrayLenght=int.Parse(Console.ReadLine());
            int[] dizi = new int[arrayLenght];
            
            
            for (int i = 0; i < dizi.Length; i++)
                dizi[i] = int.Parse(Console.ReadLine());
            
            
            for (int i = 0; i < dizi.Length-4; i++)
            {
                if((dizi[i+1]-dizi[i])-(dizi[i+2]-dizi[i+1])!=(dizi[i+3]-dizi[i+2])-(dizi[i+4]-dizi[i+3]))
               
                    counter++;
            }
            
            
            if(counter>0)
                Console.WriteLine("Array doesn't increase regularly");
            else
                Console.WriteLine("Array doesn't increase regularly");
        
        }
    }
}
