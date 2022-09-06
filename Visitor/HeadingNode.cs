namespace Visitor
{
    public class HeadingNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}