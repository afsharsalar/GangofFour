﻿namespace DesignPatterns.Behavioral.Visitor
{
    public class AnchorNode : IHtmlNode
    {


        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
