namespace Visitor
{
    public class AnchorNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}