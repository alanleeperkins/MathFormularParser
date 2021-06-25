using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormularParser
{
    class NodeNumber : Node
    {
        #region member data
        private double _number;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        public NodeNumber(double number)
        {
            _number = number;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public override double Eval(IContext ctx)
        {
            // just return it.
            return _number;
        }
    }
}
