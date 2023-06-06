namespace Library
{
    public class SumaEdadesVisitor : Visitor
    {
        public int SumaEdades { get; set; }

        public void Visit(Node node)
        {
            SumaEdades += node.Person.Edad;

            foreach (var children in node.Children)
            {
                children.Accept(this);
            }
        }
    }
}