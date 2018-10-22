using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.PlayerEnv
{
    interface IAccept
    {
        void Accept(IVisitor visitor);
    }
}
