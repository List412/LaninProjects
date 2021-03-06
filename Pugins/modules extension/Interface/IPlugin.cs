﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IPlugin
    {
        string Name { get; }
        string Version { get; }
        string Author { get; }
        void Transform(IMainApp application);
    }
}
