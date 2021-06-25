using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormularParser
{
    public enum eToken
    {
        EOF,
        Add,
        Subtract,
        Multiply,
        Divide,
        OpenParens,
        CloseParens,
        Comma,
        Identifier,
        Number,
    }
}
