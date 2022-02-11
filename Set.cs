using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_10
{
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>(8);
        }

        public bool addElement(int val)
        {
        
            if (containsElement(val))
            {
                return false;
            }
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
               //else
                    //return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            // created set to hold for Set A
            Set combined = new Set();

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                // changed from rhs to union to combine sets
                combined.addElement(rhs.elements[i]);
            }

            // additional for loop to iterate through Set A
            for(int c = 0; c < this.elements.Count; c++)
            {
                combined.addElement(this.elements[c]);
            }

            return combined;
        }
    }
}
