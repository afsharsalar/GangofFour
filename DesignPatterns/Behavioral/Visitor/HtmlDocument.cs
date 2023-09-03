using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public class HtmlDocument
    {
        private List<IHtmlNode> nodes = new List<IHtmlNode>();


        public void Add(IHtmlNode node)
        {
            nodes.Add(node);

        }


        public void Execute(IOperation operation)
        {
            foreach (var htmlNode in nodes)
            {
                htmlNode.Execute(operation);
            }
        }
    }
}
