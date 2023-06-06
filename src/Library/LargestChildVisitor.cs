using System;

namespace Library
{
    public class LargestChildVisitor : Visitor
    {
        public int LargestNumber { get; set;}
        public Persona LargestChild { get; set;}

        public LargestChildVisitor()
        {  
            { 
                LargestNumber = int.MinValue;
                LargestChild = null;
            } 
        }

         public void Visit (Node node)
        {
            if (node.Person.Edad > LargestNumber)
            {
                LargestNumber = node.Person.Edad;
                LargestChild = node.Person;
            }

                foreach (var child in node.Children)
                {
                    child.Accept(this);
                }
        }
    }
}