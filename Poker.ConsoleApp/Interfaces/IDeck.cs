﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.ConsoleApp.Interfaces
{
    public interface IDeck
    {
        public void Fill();
        public void Shuffle();
    }
}
