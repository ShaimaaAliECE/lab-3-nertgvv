using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        public string Description;
        public CollectionBoard Board;

        public virtual void AddMe(List<Collectable> c)
        {
            c.Add(this);
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
        }
        public abstract void Display();
    }
}
