using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormularParser
{
    /// <summary>
    /// for unary operations such as Negate
    /// </summary>
    class NodeUnary : Node
    {
        #region member data
        /// <summary>
        /// right hand side of the operation
        /// </summary>
        Node _rhs;

        /// <summary>
        /// the callback operator
        /// </summary>
        Func<double, double> _op;
        #endregion

        /// <summary>
        /// constructor accepts the two nodes to be operated on and function
        /// that performs the actual operation
        /// </summary>
        /// <param name="rhs"></param>
        /// <param name="op"></param>
        public NodeUnary(Node rhs, Func<double, double> op)
        {
            _rhs = rhs;
            _op = op;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public override double Eval(IContext ctx)
        {
            // evaluate RHS
            var rhsVal = _rhs.Eval(ctx);

            // evaluate and return
            var result = _op(rhsVal);
            return result;
        }
    }
}
