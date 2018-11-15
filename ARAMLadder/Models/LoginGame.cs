﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARAMLadder.Models
{
    public class LoginGame
    {
        public int Id { get; set; }
        public AramIdentityUser AramIdentityUser { get; set; }
        public string AramIdentityUserId { get; set; }
        public Game Games { get; set; }
        public long GamesId { get; set; }
        public bool Win { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int DoubleKills { get; set; }
        public int TripleKills { get; set; }
        public int QuadraKills { get; set; }
        public int PentaKills { get; set; }
        public bool FirstBloodKill { get; set; }
    }
}
