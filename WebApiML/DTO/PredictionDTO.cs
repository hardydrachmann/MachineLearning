﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiML.BE
{
    public class PredictionDTO
    {
        public List<Dictionary<string, string>> prediction { get; set; }
    }
}