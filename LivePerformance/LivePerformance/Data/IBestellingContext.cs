﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LivePerformance.Data
{
    public interface IBestellingContext
    {
        void CreateNieuweBestelling(Bestelling bestelling);
    }
}
