using _28_mar_22.task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_mar_22.task
{
    class Program
    {
        static void Main(string[] args)
        {
            Singer s = new Singer();
            s.Age = 200;
            Console.WriteLine(s.Age);


            Song song = new Song();
            song.AddRatings(2);
            song.AddRatings(3);
            Console.WriteLine(song.GetAverageRating());
            Console.ReadLine();
        }
    }
}
