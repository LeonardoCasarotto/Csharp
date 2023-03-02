using System;
using System.Collections.Generic;
using System.Text;

namespace Es0302
{
    class EmptyStackException : Exception
    {
        public EmptyStackException() : base() { }

        public EmptyStackException(string message) : base(message) { }
    }
    class FullStackException : Exception
    {
        public FullStackException() : base() { }

        public FullStackException(string message) : base(message) { }
    }
}
