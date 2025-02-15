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

using System;
using System.Reflection;
using System.Threading;

namespace CookComputing.XmlRpc
{
    public class XmlRpcRequest
    {
        private static int s_created;
        public object[] args;

        public string method;
        public MethodInfo mi;
        public int number = Interlocked.Increment(ref s_created);
        public Guid proxyId;
        public string xmlRpcMethod;

        public XmlRpcRequest() { }

        public XmlRpcRequest(string methodName, object[] parameters, MethodInfo methodInfo)
        {
            method = methodName;
            args = parameters;
            mi = methodInfo;
        }

        public XmlRpcRequest(string methodName, object[] parameters,
                             MethodInfo methodInfo, string XmlRpcMethod, Guid proxyGuid)
        {
            method = methodName;
            args = parameters;
            mi = methodInfo;
            xmlRpcMethod = XmlRpcMethod;
            proxyId = proxyGuid;
        }

        public XmlRpcRequest(string methodName, object[] parameters)
        {
            method = methodName;
            args = parameters;
        }
    }
}