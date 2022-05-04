using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Computer
    {
        //OOP gives us freedom to create objects inside application freely. To create and use an object we must create a prototype first. We can create as many as we want and where we need. We hold all those objects inside of a class. 
        
        //Default access modifier is private, to be able to reach and use the properties we need to mark them as public.
        string CPU;
        private string DisplayCard; 

       
        public int MemoryCapacity;
        public string MemoryType;
        public bool DisplaySecreen;
    }
}
