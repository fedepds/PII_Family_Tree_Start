using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;
        public Persona Padre;

        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }
        public Node(Persona padre)
        {
            this.Padre = padre;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
    }
}
