﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoBlazorServer.Data
{
    public class TaskModel
    {
        public string Task { get; set; }
        public bool IsComplete { get; set; }
    }
}
