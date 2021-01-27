using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Jones
{
    public enum SurfaceMaterial {
    Oak,
    Laminate,
    Pine,
    Rosewood,
    Veneer
    }
    public class Desk
    {
        public decimal width { get; set; }

        public decimal depth { get; set; }

        public int NumberOfDrawers { get; set; }

        public SurfaceMaterial SurfaceMaterialProp { get; set; } 
        
    }
}
