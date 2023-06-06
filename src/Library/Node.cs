using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;
        private Persona person;

        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public Persona Person
        {
            get 
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<Node> Children 
        { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number, Persona person)
        {
            this.number = number;
            this.person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
        
    }
}
