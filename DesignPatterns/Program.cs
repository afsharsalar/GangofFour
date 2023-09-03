using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Command;
using DesignPatterns.Mediator;
using DesignPatterns.Momento;
using DesignPatterns.Observer;
using DesignPatterns.State;
using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Compress;
using DesignPatterns.Strategy.Filter;
using DesignPatterns.Template;
using DesignPatterns.Visitor;
using Button = DesignPatterns.Command.Button;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Design patterns!");

            #region Momento
            var editor = new Editor();
            var history = new History();

            editor.Content="A";
            history.Push(editor.CreateState());

            editor.Content="B";
            history.Push(editor.CreateState());


            editor.Content="C";

            editor.Restore(history.Pop());

            Console.WriteLine("content of editor is : " + editor.Content);
            #endregion

            #region State
            //OCP (Open Close Principle)
            var canvas = new Canvas
            {
                Tool = new BrushTool()
            };
            canvas.MouseDown();
            canvas.MouseUp();


            #endregion


            #region Strategy


            var imageStore = new ImageStorage();
            imageStore.Store("sample.jpg",new JpegCompress(),new BackAndWhiteFilter());
            imageStore.Store("sample.jpg",new PngCompress(),new CustomFilter());

            #endregion


            #region Template

            var task = new TransferMoneyTask(new AuditTrail());
            task.Execute();

            #endregion


            #region Command

            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);
            button.Click();

            #endregion


            #region Observer

            var dataSource = new DataSource();
            var sheet1 = new SpreadSheet(dataSource);
            var sheet2 = new SpreadSheet(dataSource);
            var chart=new Chart(dataSource);

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);


            dataSource.Set(10);;

            #endregion


            #region Mediator


            var dialog = new ArticleDialogBox();
            dialog.OutPut();

            #endregion


            #region ChainOfResponsibility


            var compressor = new Compressor(null);
            var logger = new Logger(compressor);
            var auth = new Authenticator(logger);
            var server = new WebServer(auth);
            server.Handle(new HttpRequest("admin","admin"));

            #endregion



            #region Visitor

            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());

            document.Execute(new HighlightOperation());
            document.Execute(new PlainTextOperation());

            #endregion
        }
    }
}