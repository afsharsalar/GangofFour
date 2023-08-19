namespace DesignPatterns.State
{
    public class Canvas
    {
        public ITool Tool { get; set; }

        public void MouseDown()
        {
            Tool.MouseDown();
        }

        public void MouseUp()
        {
            Tool.MouseUp();
        }

        
    }
}
