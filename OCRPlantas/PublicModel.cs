using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRPlantas
{
    class PublicModel
    {
        
    }
    public class OCR
    {
        public string nombreImagen { get; set; }
        public string ocrTexto { get; set; }
        public string observacion { get; set; }

    }
    public class ImagenesSubidas
    {
        public Image imagen { get; set; }
        public string nombreImagen { get; set; }
    }
}
