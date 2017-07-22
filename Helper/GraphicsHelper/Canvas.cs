using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsHelper
{
    public class Canvas
    {
        private Graphics _graphics;
        public Graphics Graphics
        {
            get { return _graphics; }
        }
        private Bitmap _bitmap;
        public Bitmap Bitmap
        {
            get { return _bitmap; }
        }

        public Canvas(Size canvasSize)
        {
            _bitmap = new Bitmap(canvasSize.Width, canvasSize.Height);
            _graphics = Graphics.FromImage(_bitmap);
        }
    }
}
