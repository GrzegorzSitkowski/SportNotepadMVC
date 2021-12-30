﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Domain.Model
{
    public class Profile
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Age { get; set; }
        public float Weight { get; set; }
        public string Pb5k { get; set; }
        public string Pb10k { get; set; }
        public string PbHalfMarathon { get; set; }
        public string PbMarathon { get; set; }
        public int CountCompetitions { get; set; }
    }
}
