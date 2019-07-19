using System;

using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using System.IO;
using System.Reflection;
using SpreadsheetLight;


namespace OCRPlantas
{
    public partial class Form1 : Form
    {


        int totalImagenes = 0;
        List<OCR> resultadoLeido = new List<OCR>();
        ThreadStart delegado = null;
        //Creamos la instancia del hilo 
        Thread hilo = null;
        string nombreArchivoResultado = "";


        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            
        }
        //Creamos el delegado 
       

        private void btnCargarImagenes_Click(object sender, EventArgs e)
        {
            resultadoLeido.Clear();
            btnResultado.Visible = false;
            cargarImagenes();
            if (totalImagenes > 0)
            {
                
                lblTotal.Text = "Leyendo OCR imágenes....";
                //lbImagenesSeleccionadas.Visible = false;
                //Creamos la instancia del hilo 
                ThreadStart delegado = new ThreadStart(leerOcr);
                Thread hilo = new Thread(delegado);
                //Iniciamos el hilo 
                hilo.Start();
            }
            else
            {
                MessageBox.Show("Ningua imagen seleccionada");
            }
            //leerOcr();
            //
        }
        public void cargarImagenes()
        {
            lbImagenesSeleccionadas.Items.Clear();
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    lbImagenesSeleccionadas.Items.Add(file);
                }                
                totalImagenes = openFileDialog1.FileNames.Count();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnResultado.Visible = false;
            string path = System.IO.Directory.GetCurrentDirectory() + "\\preloader.gif";
            Image img = Image.FromFile(path);
          

            lbImagenesSeleccionadas.Visible = true;
          
            lblTotal.Text = "";
            this.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "All files (*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "My Image Browser";
            this.openFileDialog1.RestoreDirectory = true;


        }

        private void lbImagenesSeleccionadas_SelectedIndexChanged(object sender, EventArgs e)
        {

            //pictureBox1.Image = Image.FromFile(lbImagenesSeleccionadas.SelectedItem.ToString());
            //MessageBox.Show(lbImagenesSeleccionadas.SelectedItem.ToString());
        }
        public void exportarExcel()
        {
            lblTotal.Text ="Exportando a excel....";
            System.Threading.Thread.Sleep(4000);
            try
            {
                SLDocument sl = new SLDocument();
                sl.SetCellValueNumeric(1, 1, "nombreImagen");
                sl.SetCellValueNumeric(1, 2, "ocrTexto");
                sl.SetCellValueNumeric(1, 3, "observacion");
                int rowIndex = 2;
                int columnIndex = 1;
                
                foreach (OCR row in resultadoLeido)
                {
                
                    sl.SetCellValueNumeric(rowIndex, 1, row.nombreImagen);
                    sl.SetCellValueNumeric(rowIndex, 2, row.ocrTexto);
                    sl.SetCellValueNumeric(rowIndex, 3, row.observacion);


                    rowIndex += 1;
                    columnIndex = 1;
                }
              
                Random rnd = new Random();
                int aleatorio = rnd.Next(1, 50000);
                nombreArchivoResultado = "ocr" + (DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second+DateTime.Now.Millisecond+aleatorio)+".xlsx";
                sl.SaveAs(nombreArchivoResultado);
                lblTotal.Text = "Exportado correctamente";
                lbImagenesSeleccionadas.Visible = true;
                btnResultado.Visible = true;
                
            }
            catch (Exception ex)
            {
                lblTotal.Text = "Erro al exportar en: "+ex.Message;
            }
        }
        
        
            
        private void leerOcr()
        {
            int contador = 1;
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            path = Path.Combine(path, "tessdata");
            path = path.Replace("file:\\", "");
            var ocr = new TesseractEngine(path, "eng", EngineMode.TesseractAndCube);
            List<ImagenesSubidas> imagenesSubidas = new List<ImagenesSubidas>();
            List<string> textosObtenidos = new List<string>();
            foreach (String file in openFileDialog1.FileNames)
            {
                lblTotal.Text = "Leyendo OCR de imágenes " + contador + " de " + totalImagenes;                
                contador++;
                OCR unOcr = new OCR();
                System.IO.FileStream fs = new System.IO.FileStream(file, System.IO.FileMode.Open);
                Image imgs = Image.FromStream(fs);
                imgs.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                System.Drawing.Image unaImagen = System.Drawing.Image.FromStream(fs);
                imgs.Dispose();
                try
                {
                    int indice = file.LastIndexOf("\\");
                    indice++;
                    unOcr.nombreImagen = file.Substring(indice, file.Length - indice);
                    int ancho = unaImagen.Width;
                    int alto = unaImagen.Height;
                    int caso = 1;
                    if (rdbOpcion1.Checked)
                        caso = 1;
                    else if (rdbOpcion2.Checked)
                        caso = 2;
                    else if (rdbOpcion3.Checked)
                        caso = 3;
                    else if (rdbOpcion4.Checked)
                        caso = 4;
                    int x = 0, y = 0, width = 0, height = 0;
                    switch (caso)
                    {
                        case 1:
                            x = (int)Math.Round(ancho / float.Parse("1.8"));
                            y = (int)Math.Round(alto / float.Parse("1.4"));
                            width = ancho - x;
                            height = alto - y;
                            break;

                        case 2:
                            x = (int)Math.Round(ancho / float.Parse("1.8"));
                            y = (int)Math.Round(alto / float.Parse("2.0"));
                            width = ancho - x;
                            height = alto - y;
                            break;
                        case 3:
                            x = 0;
                            y = (int)Math.Round(alto / float.Parse("1.4"));
                            width = ancho - x;
                            height = alto - y;
                            break;
                        case 4:
                            x = 0;
                            y = (int)Math.Round(alto/float.Parse("2.0"));
                            width = ancho - x;
                            height = alto - y;
                            break;
                    }

                    using (var stream = new MemoryStream())
                    {
                        unaImagen.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        var img = Bitmap.FromStream(stream) as Bitmap;

                        System.Drawing.Imaging.PixelFormat format = img.PixelFormat;
                        Rectangle rectangle = new Rectangle(x, y, width - 1, height - 1);
                        Bitmap croppedImage = img.Clone(rectangle, format);
                        var page = ocr.Process(croppedImage);

                        unOcr.ocrTexto = page.GetText();
                        unOcr.observacion = "Correcto";

                        unaImagen.Dispose();
                        stream.Close();
                        stream.Dispose();
                        img.Dispose();
                        page.Dispose();
                        croppedImage.Dispose();
                        fs.Close();
                        fs.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    unOcr.observacion = "Error al leer el ocr:" + ex.Message;
                }
                resultadoLeido.Add(unOcr);                
            }
            exportarExcel();
        }
       

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (nombreArchivoResultado != "")
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\"+nombreArchivoResultado;
                FileInfo fi = new FileInfo(path);
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start(path);
                }
                else
                {
                  
                }
            }
        }
    }
}
