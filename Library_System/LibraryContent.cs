using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    //Abstract class for a Library content 
    abstract class LibraryContent
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string PublicationYear { get; set; }

        //Constructor for get a details about the item
        public LibraryContent(string name, string description, string publicationYear)
        {
            this.Name = name;
            this.Description = description;
            this.PublicationYear = publicationYear;
        }

        public abstract void DisplayAvailability();
    }
}
