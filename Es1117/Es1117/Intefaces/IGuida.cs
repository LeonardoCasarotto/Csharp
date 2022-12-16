using System;
using System.Collections.Generic;
using System.Text;

namespace Es1117
{
    interface IGuida
    {
        //note that interfaces do not have a body, and like abstract classes cannot be used to create objects .
        //You should use interfaces to archieve security and to allow one class to inherit from more interfaces, unlike classes inheritage.

        public void Drive();


    }
}
