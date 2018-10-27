using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;

namespace FileEnv
{
    public abstract class PlayTime : File, IPlayTime
    {
        private string _length;

        public PlayTime(string type, string name, ulong size, string location, string length) :
            base(type, name, size, location)
        {
            Length = length;
        }

        public string Length { get => _length; set => _length = value; }
    }
}
