using System;

namespace ClassLibrary1
{
    internal class Internal
    {
        public int MyProperty { get; set; }
    }

    public class NotInternal
    {
        public int MyProperty { get; set; }

        public void Foo()
        {

        }

        internal void Foo1()
        {

        }

    }
}
