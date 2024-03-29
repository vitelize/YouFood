﻿using System.Collections.Generic;

namespace Models
{
    public class Restaurant
    {
        //proprietés de base
        public int ID { get; set; }
        public string Description { get; set; }
        public string Adresse { get; set; }
        public int Capacite { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }

        //Navigation
        public List<Zone> Zones { get; set; }
        public Manager Responsable { get; set; }
    }
}
