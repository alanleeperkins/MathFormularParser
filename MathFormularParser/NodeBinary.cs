using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormularParser
{
    /// <summary>
    /// 
    /// </summary>
    class NodeBinary : Node
    {
        #region member data
        /// <summary>
        /// left hand side of the operation
        /// </summary>
        Node _lhs;

        /// <summary>
        /// right hand side of the operation
        /// </summary>
        Node _rhs;

        /// <summary>
        /// the callback operator
        /// </summary>
        Func<double, double, double> _op;
        #endregion

        /// <summary>
        /// constructor accepts the two nodes to be operated on and function
        /// that performs the actual operation
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="op"></param>
        public NodeBinary(Node lhs, Node rhs, Func<double, double, double> op)
        {
            _lhs = lhs;
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
            // evaluate both sides
            var lhsVal = _lhs.Eval(ctx);
            var rhsVal = _rhs.Eval(ctx);

            // evaluate and return
            var result = _op(lhsVal, rhsVal);
            return result;
        }
    }
}
