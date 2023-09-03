namespace DesignPatterns.Structural.Adapter
{
    public class ImageView
    {
        private readonly Image _image;

        public ImageView(Image image)
        {
            this._image = image;
        }


        public void Apply(IFilter filter)
        {
            filter.Apply(_image);
        }

    }
}
