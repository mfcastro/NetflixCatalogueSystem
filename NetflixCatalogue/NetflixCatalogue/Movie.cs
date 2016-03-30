﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
   public class Movie : Title
    {
        
        int hours;
        int minutes;

        public Movie(int hours, int minutes, string name, string rating) : base(name, rating)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        //Duration field
        public string duration
        {
            get
            {
                return String.Format("{0}:{1:00}", this.hours, this.minutes);
            }
        }


        //Overrides ToString() method to return a string of the name and duration of the movie
        //public override string ToString()
        //{
        //    return (String.Format("Name of Show: {0}, Duration of Movie {1}",/*SHOW.name*/,this.duration));
        //}
    }
}
