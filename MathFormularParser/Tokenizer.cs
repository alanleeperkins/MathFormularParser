using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormularParser
{
    public class Tokenizer
    {
        #region member data
        private TextReader _reader;
        private char _currentChar;
        private eToken _currentToken;
        private double _number;
        private string _identifier;
        #endregion

        #region properties
        public eToken Token
        {
            get { return _currentToken; }
        }

        public double Number
        {
            get { return _number; }
        }

        public string Identifier
        {
            get { return _identifier; }
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        public Tokenizer(TextReader reader)
        {
            _reader = reader;
            NextChar();
            NextToken();
        }


        // Read the next character from the input strem
        // and store it in _currentChar, or load '\0' if EOF
        void NextChar()
        {
            int ch = _reader.Read();
            _currentChar = ch < 0 ? '\0' : (char)ch;
        }

        // Read the next token from the input stream
        public void NextToken()
        {
            // Skip whitespace
            while (char.IsWhiteSpace(_currentChar))
            {
                NextChar();
            }

            // Special characters
            switch (_currentChar)
            {
                case '\0':
                    _currentToken = eToken.EOF;
                    return;

                case '+':
                    NextChar();
                    _currentToken = eToken.Add;
                    return;

                case '-':
                    NextChar();
                    _currentToken = eToken.Subtract;
                    return;

                case '*':
                    NextChar();
                    _currentToken = eToken.Multiply;
                    return;

                case '/':
                    NextChar();
                    _currentToken = eToken.Divide;
                    return;

                case '(':
                    NextChar();
                    _currentToken = eToken.OpenParens;
                    return;

                case ')':
                    NextChar();
                    _currentToken = eToken.CloseParens;
                    return;

                case ',':
                    NextChar();
                    _currentToken = eToken.Comma;
                    return;
            }

            // Number?
            if (char.IsDigit(_currentChar) || _currentChar == '.')
            {
                // Capture digits/decimal point
                var sb = new StringBuilder();
                bool haveDecimalPoint = false;
                while (char.IsDigit(_currentChar) || (!haveDecimalPoint && _currentChar == '.'))
                {
                    sb.Append(_currentChar);
                    haveDecimalPoint = _currentChar == '.';
                    NextChar();
                }

                // Parse it
                _number = double.Parse(sb.ToString(), CultureInfo.InvariantCulture);
                _currentToken = eToken.Number;
                return;
            }

            // Identifier - starts with letter or underscore
            if (char.IsLetter(_currentChar) || _currentChar == '_')
            {
                var sb = new StringBuilder();

                // Accept letter, digit or underscore
                while (char.IsLetterOrDigit(_currentChar) || _currentChar == '_')
                {
                    sb.Append(_currentChar);
                    NextChar();
                }

                // Setup token
                _identifier = sb.ToString();
                _currentToken = eToken.Identifier;
                return;
            }
        }
    }

}
