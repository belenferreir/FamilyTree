using System;

namespace Library
{
    public class LongestNameVisitor : Visitor
    {
        private string longestName = "";

        public string LongestName 
        { 
            get 
            { 
                return longestName; 
            } 
        }

        public void Visit(Node node)
        {
            if (node.Person.Nombre.Length > longestName.Length)
            {
                longestName = node.Person.Nombre;
            }

            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}