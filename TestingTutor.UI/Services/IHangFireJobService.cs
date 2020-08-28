﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingTutor.UI.Services
{
    public interface IHangFireJobService
    {
        string GetParentOrDefault(string name);
        void AddJob(string name, string jobId);
        void Remove(string name);
    }
}
