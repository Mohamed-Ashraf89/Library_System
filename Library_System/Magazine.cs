using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    class Magazine : LibraryContent
    {

        public Magazine(string Name, string Description, string PublicationYear) : base(Name, Description, PublicationYear)
        {

        }

        public override void DisplayAvailability()
        {
            Console.WriteLine("This Magazine can be read only in the library");
        }
    }
}
