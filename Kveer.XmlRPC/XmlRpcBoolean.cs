/* 
XML-RPC.NET library
Copyright (c) 2001-2006, Charles Cook <charlescook@cookcomputing.com>

Permission is hereby granted, free of charge, to any person 
obtaining a copy of this software and associated documentation 
files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, 
publish, distribute, sublicense, and/or sell copies of the Software, 
and to permit persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission notice shall be 
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
DEALINGS IN THE SOFTWARE.
*/

namespace CookComputing.XmlRpc
{
    public class XmlRpcBoolean
    {
        private readonly bool _value;

        public XmlRpcBoolean()
        {
        }

        public XmlRpcBoolean(bool val)
        {
            _value = val;
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override bool Equals(
          object o)
        {
            var dbl = o as XmlRpcBoolean;
            return dbl?._value == _value;
        }

        public static bool operator ==(
          XmlRpcBoolean xi,
          XmlRpcBoolean xj)
        {
            if (((object)xi) == null && ((object)xj) == null)
                return true;
            if (((object)xi) == null || ((object)xj) == null)
                return false;
            return xi._value == xj._value;
        }

        public static bool operator !=(
          XmlRpcBoolean xi,
          XmlRpcBoolean xj)
        {
            return !(xi == xj);
        }

        public static implicit operator bool(XmlRpcBoolean x)
        {
            return x._value;
        }

        public static implicit operator XmlRpcBoolean(bool x)
        {
            return new XmlRpcBoolean(x);
        }
    }
}