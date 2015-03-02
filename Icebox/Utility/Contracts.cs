using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Icebox
{
    public static class Contracts
    {
        #region Check contracts for public APIs
        public static void Check(bool value)
        {
            if (!value)
                throw Except();
        }

        public static void CheckNonEmpty(string value, string paramName)
        {
            if (String.IsNullOrEmpty(value))
                throw ExceptEmpty(paramName);
        }

        public static void CheckNullOrNonEmpty(string value, string paramName)
        {
            if (value != null && value.Length == 0)
                throw ExceptEmpty(paramName);
        }

        private static Exception Except()
        {
            return new InvalidOperationException();
        }

        private static Exception ExceptEmpty(string paramName)
        {
            return new ArgumentException("The given empty parameter is invalid", paramName);
        }
        #endregion

        [Conditional("DEBUG")]
        public static void Assert(bool value) 
        {
#if DEBUG
            if (!value)
                DbgFailCore("");
#endif
        }

        [Conditional("DEBUG")]
        public static void AssertNonEmpty(string value)
        {
#if DEBUG
            if (value == String.Empty)
                DbgFailCore("Empty String");
#endif
        }

        private static void DbgFail() 
        {
#if DEBUG
            DbgFailCore("");
#endif
        }

        private static void DbgFail(String msg)
        {
#if DEBUG
            DbgFailCore(msg);
#endif
        }

        private static void DbgFailCore(String msg)
        {
#if DEBUG
            Debugger.Break();
#endif
        }
    }
}