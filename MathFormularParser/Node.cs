using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormularParser
{
    /// <summary>
    /// abstract class representing one node in the expression 
    /// </summary>
    public abstract class Node
    {
        public abstract double Eval(IContext ctx);
    }
}
