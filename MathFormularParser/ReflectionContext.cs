using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormularParser
{
    public class ReflectionContext : IContext
    {
        #region member data
        private object _targetObject;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetObject"></param>
        public ReflectionContext(object targetObject)
        {
            _targetObject = targetObject;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public double ResolveVariable(string name)
        {
            // find the property
            var pi = _targetObject.GetType().GetProperty(name);
            if (pi == null)
                throw new InvalidDataException($"Unknown variable: '{name}'");

            // call the property
            return (double)pi.GetValue(_targetObject);
        }     

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        public double CallFunction(string name, double[] arguments)
        {
            // find the method
            var mi = _targetObject.GetType().GetMethod(name);
            if (mi == null)
                throw new InvalidDataException($"Unknown function: '{name}'");

            // convert double array to object array
            var argObjs = arguments.Select(x => (object)x).ToArray();

            // call the method
            return (double)mi.Invoke(_targetObject, argObjs);
        }
    }
}
