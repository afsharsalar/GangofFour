namespace DesignPatterns.Mediator
{
    public class ArticleDialogBox //: DialogBox
    {
        private readonly ListBox _listBox;
        private readonly TextBox _textBox;
        private readonly Button _button;


        public ArticleDialogBox()
        {
            _listBox = new ListBox();
            _textBox = new TextBox();
            _button = new Button();

            _listBox.Attach();
            
        }


        public void OutPut()
        {
            _listBox.Selection="Article 1";
            Console.WriteLine($"TextBox: {_textBox.Content}");
            Console.WriteLine($"Button: {_button.Enable}");
        }

       
        //public override void Changed(UiControl control)
        //{
        //    if (control == _listBox)
        //    {
        //        _textBox.Content = _listBox.Selection;
        //        _button.Enable=true;
        //    }else if (control == _textBox)
        //    {
        //        if(_textBox.Content.Length==0)
        //            _button.Enable=false;
        //    }
        //}

    }
}
