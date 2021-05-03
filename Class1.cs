using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    [Serializable]
    public abstract class Item
    {
        public string Name { get; set; }
        public bool NameLanguageEN = true;

    }
    [Serializable]
    public class Line : Item
    {
        public List<Point> Points;
        public GraphicsPath path;
        public Point StartPoint { get; set; }
        public Line(Point origin)
        {
            StartPoint= new Point(origin.X, origin.Y);
        }
    }
    [Serializable]
    public class Furniture : Item
    {
        public Image image { get; set; }
        public Image OriginalImage { get; set; }
        public Point Position { get; set; }
        public int Size;
        public bool Semi_Trans;
        public int RotationAngle;
        public bool Transformed;
        public int id;
        public Furniture(Image im, string name = null, int X = 0, int Y = 0)
        {
            Name = name;
            image = im;
            Position = new Point(X, Y);
            Size = image.Height;
            Semi_Trans = false;
            RotationAngle = 0;
        }
    }
    [Serializable]
    public class FurnituresToSave
    {
        public List<Furniture> FToSave = new List<Furniture>();
    }
}
