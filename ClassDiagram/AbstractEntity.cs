using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    abstract class AbstractEntity
    {
        public static int idCount = 0;
        public int id = idCount++;
        public int Id
        {
            get
            {
                return id;
            }
        }

        // public Guid id (unique id)
    }
}
