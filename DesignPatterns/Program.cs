using System.Security.Cryptography.X509Certificates;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Momento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.Strategy.Compress;
using DesignPatterns.Behavioral.Strategy.Filter;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Behavioral.Template;
using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Adapter.AvaFilter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Decorator;
using Button = DesignPatterns.Behavioral.Command.Button;

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
            
            #region Composite

            var group1 = new Group();
            group1.Add(new Shape());
            group1.Add(new Shape());


            var group2 = new Group();
            group2.Add(new Shape());
            group2.Add(new Shape());


            var group = new Group();
            group.Add(group1);
            group.Add(group2);


            group.Render();
            group.Move();

            #endregion
            
            #region Adapter

            var imageView = new ImageView(new Image());
            imageView.Apply(new VividFilter());
            imageView.Apply(new CaramelAdapter());

            #endregion


            #region Decorator
            
            StoreCreditCard(new CloudStream());
            StoreCreditCard(new EncryptedCloudStream(new CloudStream()));
            StoreCreditCard(new EncryptedCloudStream(new CompressCloudStream(new CloudStream())));

            #endregion


            #region Bridge

            var control = new AdvanceRemoteControl(new SamsungTv());
            control.TurnOn();

            #endregion
        }

        public static void StoreCreditCard(IStream stream)
        {
            stream.Write("6104-8896-7856-9654");
        }
         
    }
}