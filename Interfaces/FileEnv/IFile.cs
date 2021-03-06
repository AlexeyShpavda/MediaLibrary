﻿using System;
using Interfaces.PlayerEnv;

namespace Interfaces.FileEnv
{
    public interface IFile : IAccept
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        int Size { get; set; }
        string Location { get; set; }
    }
}
