﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Levels
{
    //TODO complete class
    public class Level
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }


        public Level(string title, string image)
        {
            Title = title;
            Image = image;
        }
    }
}
