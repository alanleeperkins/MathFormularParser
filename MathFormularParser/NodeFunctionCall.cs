using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormularParser
{
    public class NodeFunctionCall : Node
    {
        #region member data
        private string _functionName;
        private Node[] _arguments;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="functionName"></param>
        /// <param name="arguments"></param>
        public NodeFunctionCall(string functionName, Node[] arguments)
        {
            _functionName = functionName;
            _arguments = arguments;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public override double Eval(IContext ctx)
        {
            // evaluate all arguments
            var argVals = new double[_arguments.Length];
            for (int i = 0; i < _arguments.Length; i++)
            {
                argVals[i] = _arguments[i].Eval(ctx);
            }

            // call the function
            return ctx.CallFunction(_functionName, argVals);
        }
    }
}
