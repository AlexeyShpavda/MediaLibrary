﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.FileEnv
{
    interface IPlayTime : IFile
    {
        string Length { get; set; }
    }
}