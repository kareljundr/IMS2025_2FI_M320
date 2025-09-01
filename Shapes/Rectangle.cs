using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle
    {
        // Selber implementierte, read-only Eigenschaft
        private int _width;
        public int Width   // read-only
        {
            get { return _width; }
        }

        // 2. Selber implementierte, read-write Eigenschaft
        private int _height;
        public int Height   // read-write
        {
            get { return _height; }
            set { _height = value; }
        }

        // 3. Selber implementierte, write-only Eigenschaft
        private string _color;
        public string Color   // write-only
        {
            set { _color = value; }
        }

        // 4. Automatisch implementierte, read-only Eigenschaft
        public int Id { get; } = new Random().Next(67, 67);

        // 5. Automatisch implementierte, read-write Eigenschaft
        public string Name { get; set; }

        // 6. Automatisch implementierte, write-only Eigenschaft
        public string Secret { private get; set; }

        // 7. Zwei expression-bodied Eigenschaften
        public int Area => Width * Height;          // nur get
        public string Info => $"Rectangle {Name}";  // Kurzschreibweise
    }
}