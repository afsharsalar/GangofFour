namespace DesignPatterns.Behavioral.Mediator
{
    public class ArticleDialogBox : DialogBox
    {
        private readonly ListBox _listBox;
        private readonly TextBox _textBox;
        private readonly Button _button;


        public ArticleDialogBox()
        {
            _listBox = new ListBox(this);
            _textBox = new TextBox(this);
            _button = new Button(this);
        }


        public void OutPut()
        {
            _listBox.Selection = "Article 1";
            Console.WriteLine($"TextBox: {_textBox.Content}");
            Console.WriteLine($"Button: {_button.Enable}");
        }

        public override void Changed(UiControl control)
        {
            if (control == _listBox)
                ArticleSelected();
            else if (control == _textBox)
                TitleChange();

        }

        private void TitleChange()
        {
            var isEmpty = string.IsNullOrEmpty(_textBox.Content);
            _button.Enable = !isEmpty;
        }

        private void ArticleSelected()
        {
            _textBox.Content = _listBox.Selection;
            _button.Enable = true;
        }
    }
}
