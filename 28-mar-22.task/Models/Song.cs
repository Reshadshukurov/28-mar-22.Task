using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_mar_22.task.Models
{
    class Song:Singer
    {
        private string Name;
       
        public void setName(string name)
        {
            if (name.Length<100)
            {
                Name = name;
            }
        }
        public string getName()
        {
            return Name;
        }
        private string _Genre;
        public string Genre { 
            get
            {
                return _Genre;
            }

            set
            {
                string[] song = { "Pop", "Rock", "Jazz", "Techno" };
                if (value=="Pop"|| value== "Rock"|| value == "Jazz" || value == "Techno")
                {
                    _Genre = value;
                }


            }
        }

        private string Singer;
        private int[] Ratings = new int[0];
        public void AddRatings(int rating)
        {
            if (rating>=1&&rating<=6)
            {
                Array.Resize(ref Ratings, Ratings.Length + 1);
                Ratings[Ratings.Length - 1] = rating;
            }
        }
        public double GetAverageRating()
        {
            return Math.Round(Ratings.Average(), 2);
        }

    }
}
