using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormularParser
{
    /// <summary>
    /// represents a variable (or a constant) in an expression.  eg: "2 * pi"
    /// </summary>
    public class NodeVariable : Node
    {
        #region member data
        private string _variableName;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="variableName"></param>
        public NodeVariable(string variableName)
        {
            _variableName = variableName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public override double Eval(IContext ctx)
        {
            return ctx.ResolveVariable(_variableName);
        }
    }
}
