using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.PlayerEnv
{
    public interface IAccept
    {
        void Accept(IVisitor visitor);
    }
}
