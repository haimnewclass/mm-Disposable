using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class kuku : IDisposable {
        public void Dispose()
        {
         
        }
    }
    class Data : IDisposable
    {
        public int Id { get; set; }
        public Data(int id)
        {
            Id = id;
        }
        public int[] arr;

        public void Alloc()
        {
            arr = new int[10];
        }

        public void Free()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // free forr each cell
                arr[i] = 0;
            }
        }
        public void Dispose()
        {
            //
            Free();
            Console.WriteLine("Release the Id " + Id.ToString());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(12);
            data.Alloc();
            data.arr[3] = 98;
            data.arr[2] = 48;
            //data.Free();

            using(kuku a = new kuku())
            {

            }

            using(Data d = new Data(55))
            {
                d.Alloc();
                d.arr[3] = 98;
                d.arr[2] = 48;                
            }

            using (System.IO.StreamWriter s = new System.IO.StreamWriter(""))
            {
                s.WriteLine("sdfsdfsdfsdf");
            }    
        }
    }
}
