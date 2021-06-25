using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormularParser
{
    public class Library
    {
        #region properties
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double d { get; set; }
        public double e { get; set; }
        public double f { get; set; }
        public double g { get; set; }
        public double h { get; set; }
        public double i { get; set; }
        public double j { get; set; }
        public double k { get; set; }
        public double l { get; set; }
        public double m { get; set; }
        public double n { get; set; }
        public double o { get; set; }
        public double p { get; set; }
        public double q { get; set; }
        public double r { get; set; }
        public double s { get; set; }
        public double t { get; set; }
        public double u { get; set; }
        public double v { get; set; }
        public double w { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public double PI
        {
            get
            {
                return Math.PI;
            }
        }

        public double E
        {
            get
            {
                return Math.E;
            }
        }
        #endregion

        /// <summary>
        /// constructor 
        /// </summary>
        public Library()
        {
            Reset();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Reset()
        {
            a = 0.0;
            b = 0.0;
            c = 0.0;
            d = 0.0;
            e = 0.0;
            f = 0.0;
            g = 0.0;
            h = 0.0;
            i = 0.0;
            j = 0.0;
            k = 0.0;
            l = 0.0;
            m = 0.0;
            n = 0.0;
            o = 0.0;
            p = 0.0;
            q = 0.0;
            r = 0.0;
            s = 0.0;
            t = 0.0;
            u = 0.0;
            v = 0.0;
            w = 0.0;
            x = 0.0;
            y = 0.0;
            z = 0.0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public double sqrt(double d)
        {            
            return Math.Sqrt(d);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public double abs(double d)
        {
            return Math.Abs(d);
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public double round(double d)
        {
            return Math.Round(d);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double pow(double x, double y)
        {
            return Math.Pow(x,y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double ceiling(double x)
        {
            return Math.Ceiling(x);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double cos(double x)
        {
            return Math.Cos(x);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double sin(double x)
        {
            return Math.Sin(x);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double sinh(double x)
        {
            return Math.Sinh(x);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double tan(double x)
        {
            return Math.Tan(x);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double tanh(double x)
        {
            return Math.Tanh(x);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double truncate(double x)
        {
            return Math.Truncate(x);
        }    
          
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double floor(double x)
        {
            return Math.Floor(x);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double exp(double x)
        {
            return Math.Exp(x);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double cosh(double x)
        {
            return Math.Cosh(x);
        }              
    }
}
