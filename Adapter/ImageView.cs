using System;

namespace Adapter
{
    public class ImageView
    {
        Image image;

        public ImageView(Image image)
        {
            this.image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(image);
        }
    }
}