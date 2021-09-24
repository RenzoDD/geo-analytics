using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class canvas : Form
    {
        #region Variables/Atributos
        //Buffer para las animaciones
        BufferedGraphicsContext bfc;
        BufferedGraphics bf;

        int x, y; //posiciones del mouse
        PointF[] imagen;    //Conjunto de puntos en R2

        Pen penFigura;    //Lapiz para dibujar la figura
        Pen penGuia;    //Lapiz para dibujar las lineas guias
        Pen penPuntos;    //Lapiz para dibujar puntos
        Pen penFoco;    //Lapiz para dibujar puntos
        Font letra;

        PointF foco; //Foco de rotación y homotecia
        PointF eje;

        bool b_foco; //Sabe cuando se va a elegir el foco
        bool b_eje; //Sabe cuando se va a elegir el foco
        int escala = 50; 
        #endregion
        
        #region Formulario
        public canvas()
        {
            InitializeComponent();
            Inicializador();
        }
        private void canvas_Click(object sender, EventArgs e)
        {
            if (b_foco)
            {
                foco.X = x;
                foco.Y = y;
                b_foco = false;
                btnFoco.Text = "Foco: (" + Convertir(foco).X + ", " + Convertir(foco).Y + ")";
            }
            else if (b_eje)
            {
                CambiarEje();
                b_eje = false;
            }
            else
            {
                PointF[] aux = new PointF[imagen.Length + 1];

                imagen.CopyTo(aux, 0);

                aux[imagen.Length] = new PointF(x, y);

                imagen = aux;
            }


            Mostrar();
        }
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
        }
        private void canvas_Resize(object sender, EventArgs e)
        {
            bfc = BufferedGraphicsManager.Current;
            bf = bfc.Allocate(CreateGraphics(), this.ClientRectangle);
            Mostrar();

            x = this.Size.Width / 2;
            y = this.Size.Height / 2;
            CambiarEje();
        }
        private void canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (imagen.Length > 0)
            {
                if (e.KeyValue == 66 || e.KeyValue == 98)
                {

                    PointF[] nuevo = new PointF[imagen.Length - 1];
                    for (int i = 0; i < imagen.Length - 1; i++)
                        nuevo[i] = imagen[i];
                    imagen = nuevo;
                }

                if (e.KeyValue == 87 || e.KeyValue == 119)
                    imagen[imagen.Length - 1].Y = imagen[imagen.Length - 1].Y - 1;
                if (e.KeyValue == 83 || e.KeyValue == 115)
                    imagen[imagen.Length - 1].Y = imagen[imagen.Length - 1].Y + 1;

                if (e.KeyValue == 65 || e.KeyValue == 97)
                    imagen[imagen.Length - 1].X = imagen[imagen.Length - 1].X - 1;
                if (e.KeyValue == 68 || e.KeyValue == 100)
                    imagen[imagen.Length - 1].X = imagen[imagen.Length - 1].X + 1;

                Mostrar();
            }
        }
        void Inicializador()
        {
            penFigura = new Pen(Color.Black);
            penGuia = new Pen(Color.Green);
            penPuntos = new Pen(Color.Blue);
            penFoco = new Pen(Color.Orange);
            letra = new Font("Arial", 10);

            imagen = new PointF[0];
            foco = new Point(0, 25);

            bfc = BufferedGraphicsManager.Current;
            bf = bfc.Allocate(CreateGraphics(), this.ClientRectangle);

            eje.X = this.Size.Width / 2;
            eje.Y = this.Size.Height / 2;

            foco = eje;
        }
        #endregion
        #region Archivos
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            imagen = new PointF[0];
            Inicializador();
            Limpiar();
            Mostrar();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFile.Filter = "Medina files (*.medina)|*.medina|All files (*.*)|*.*";
            SaveFile.FilterIndex = 1;

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = File.CreateText(SaveFile.FileName);
                file.WriteLine(imagen.Length.ToString());

                file.WriteLine(foco.X.ToString());
                file.WriteLine(foco.Y.ToString());

                for (int i = 0; i < imagen.Length; i++)
                {
                    file.WriteLine(imagen[i].X.ToString());
                    file.WriteLine(imagen[i].Y.ToString());
                }
                file.Close();
            }
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {

            OpenFile.Filter = "Medina files (*.medina)|*.medina|All files (*.*)|*.*";
            OpenFile.FilterIndex = 1;
            OpenFile.RestoreDirectory = true;

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = File.OpenText(OpenFile.FileName);
                int length = int.Parse(file.ReadLine());
                PointF[] respuesta = new PointF[length];

                foco.X = int.Parse(file.ReadLine());
                foco.Y = int.Parse(file.ReadLine());

                for (int i = 0; i < length; i++)
                {
                    respuesta[i].X = float.Parse(file.ReadLine());
                    respuesta[i].Y = float.Parse(file.ReadLine());
                }
                file.Close();
                imagen = respuesta;
                Mostrar();
            }
        }
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            Info frm = new Info();
            frm.ShowDialog();
        }
        #endregion
        #region Sin letras
        private void txtAngulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(txtAngulo.Text, e);
        }
        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(txtX.Text, e);
        }
        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(txtY.Text, e);
        }
        private void txtRelacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(txtRelacion.Text, e);
        }
        void ValidarNumeros(string texto, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                try
                { double i = double.Parse(texto); }
                catch
                { e.Handled = true; return; }

                if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space))
                { e.Handled = true; return; }
            }
        }
        #endregion
        #region Funciones de transformación
        PointF[] Agrandar(double relacion)
        {

            PointF[] respuesta = new PointF[imagen.Length];

            for (int i = 0; i < respuesta.Length; i++)
            {
                if (foco.X < imagen[i].X)
                {
                    //tangente
                    double tang = (foco.Y - imagen[i].Y) / (imagen[i].X - foco.X);

                    //Distancia entre el foco y el punto
                    double distancia = Math.Sqrt(Math.Pow(imagen[i].X - foco.X, 2) + Math.Pow(foco.Y - imagen[i].Y, 2));

                    //Distancia entre el foco y el nuevo punto
                    double nuevadistancia = relacion * distancia;

                    //Hallar los nuevos puntos
                    double angulo = Math.Atan(tang);

                    respuesta[i].Y = foco.Y - (float)(Math.Sin(angulo) * nuevadistancia);
                    respuesta[i].X = foco.X + (float)(Math.Cos(angulo) * nuevadistancia);
                }
                else if (foco.X > imagen[i].X)
                {
                    double tang = (imagen[i].Y - foco.Y) / (foco.X - imagen[i].X);

                    //Distancia entre el foco y el punto
                    double distancia = Math.Sqrt(Math.Pow(foco.X - imagen[i].X, 2) + Math.Pow(imagen[i].Y - foco.Y, 2));

                    //Distancia entre el foco y el nuevo punto
                    double nuevadistancia = relacion * distancia;

                    //Hallar los nuevos puntos
                    double angulo = Math.Atan(tang);

                    respuesta[i].Y = foco.Y + (float)(Math.Sin(angulo) * nuevadistancia);
                    respuesta[i].X = foco.X - (float)(Math.Cos(angulo) * nuevadistancia);
                }


                MostrarEje();
                MostrarPunto(respuesta);
                bf.Graphics.DrawLine(penGuia, foco, respuesta[i]);

            }
            return respuesta;
        }
        PointF[] Espejar(bool eje)
        {
            PointF[] respuesta = new PointF[imagen.Length];
            for (int i = 0; i < respuesta.Length; i++)
            {
                if (!eje)
                {
                    float constante = (this.eje.X) - imagen[i].X;
                    respuesta[i] = new PointF(constante + (this.eje.X), imagen[i].Y);
                }
                else
                {
                    float constante = this.eje.Y - imagen[i].Y;
                    respuesta[i] = new PointF(imagen[i].X, constante + (this.eje.Y));
                }
            }
            return respuesta;
        }
        PointF[] Rotar(double relacion)
        {
            PointF[] respuesta = new PointF[imagen.Length];

            for (int i = 0; i < respuesta.Length; i++)
            {
                if (foco.X < imagen[i].X)
                {
                    //tangente
                    double tang = (foco.Y - imagen[i].Y) / (imagen[i].X - foco.X);
                    double beta = Math.Atan(tang);

                    double alfa = relacion * 0.0174533;

                    //Distancia entre el foco y el punto
                    double distancia = Math.Sqrt(Math.Pow(imagen[i].X - foco.X, 2) + Math.Pow(foco.Y - imagen[i].Y, 2));

                    respuesta[i].Y = foco.Y - (float)(Math.Sin(beta - alfa) * distancia);
                    respuesta[i].X = foco.X + (float)(Math.Cos(beta - alfa) * distancia);
                }
                else if (foco.X > imagen[i].X)
                {
                    //tangente
                    double tang = (imagen[i].Y - foco.Y) / (foco.X - imagen[i].X);
                    double beta = Math.Atan(tang);

                    double alfa = relacion * 0.0174533;

                    //Distancia entre el foco y el punto
                    double distancia = Math.Sqrt(Math.Pow(foco.X - imagen[i].X, 2) + Math.Pow(imagen[i].Y - foco.Y, 2));

                    respuesta[i].Y = foco.Y + (float)(Math.Sin(beta - alfa) * distancia);
                    respuesta[i].X = foco.X - (float)(Math.Cos(beta - alfa) * distancia);
                }



                MostrarEje();
                MostrarPunto(respuesta);
                bf.Graphics.DrawLine(penGuia, foco, respuesta[i]);

            }
            return respuesta;
        }
        PointF[] Transformar(float x, float y)
        {
            //Creo un rectangulo que inscriba la figura
            PointF[] rectangulo = new PointF[4];
            for (int i = 0; i < 4; i++)//Se inicializa los vertices del rectangulo
            {
                rectangulo[i].X = imagen[0].X;
                rectangulo[i].Y = imagen[0].Y;
            }

            for (int i = 0; i < imagen.Length; i++)//Se encuentran los vertices del rectangulo
            {
                if (imagen[i].X < rectangulo[0].X)
                    rectangulo[0].X = imagen[i].X;
                if (imagen[i].Y < rectangulo[0].Y)
                    rectangulo[0].Y = imagen[i].Y;

                if (imagen[i].X > rectangulo[1].X)
                    rectangulo[1].X = imagen[i].X;
                if (imagen[i].Y < rectangulo[1].Y)
                    rectangulo[1].Y = imagen[i].Y;

                if (imagen[i].X > rectangulo[2].X)
                    rectangulo[2].X = imagen[i].X;
                if (imagen[i].Y > rectangulo[2].Y)
                    rectangulo[2].Y = imagen[i].Y;

                if (imagen[i].X < rectangulo[3].X)
                    rectangulo[3].X = imagen[i].X;
                if (imagen[i].Y > rectangulo[3].Y)
                    rectangulo[3].Y = imagen[i].Y;
            }

            //Se obtiene el alto y ancho del rectangulo
            float ladoX = rectangulo[2].X - rectangulo[0].X, ladoY = rectangulo[2].Y - rectangulo[0].Y;

            //Se crea un arreglo de puntos, que contendrá la relación entre el lado del rectangulo y cada punto
            PointF[] relacion = new PointF[imagen.Length];
            for (int i = 0; i < imagen.Length; i++)
            {
                relacion[i].X = (imagen[i].X - rectangulo[0].X) / ladoX;
                relacion[i].Y = (imagen[i].Y - rectangulo[0].Y) / ladoY;
            }
            //se cambia el tamaño del rectangulo a las proporciones ingresadas
            rectangulo[1].X = ladoX * x + rectangulo[0].X;
            rectangulo[2].X = ladoX * x + rectangulo[0].X;
            rectangulo[2].Y = ladoY * y + rectangulo[0].Y;
            rectangulo[3].Y = ladoY * y + rectangulo[0].Y;
            //Se vuelve a calcular las nuevas dimensiones del rectangulo
            ladoX = rectangulo[2].X - rectangulo[0].X; ladoY = rectangulo[2].Y - rectangulo[0].Y;

            //Se
            PointF[] respuesta = new PointF[imagen.Length];
            for (int i = 0; i < imagen.Length; i++)
            {
                respuesta[i].X = ladoX * relacion[i].X + rectangulo[0].X;
                respuesta[i].Y = ladoY * relacion[i].Y + rectangulo[0].Y;
            }

            for (int i = 0; i < 4; i++)//Se inicializa los vertices del rectangulo
            {
                rectangulo[i].X = respuesta[0].X;
                rectangulo[i].Y = respuesta[0].Y;
            }
            for (int i = 0; i < respuesta.Length; i++)
            {
                if (respuesta[i].X < rectangulo[0].X)
                    rectangulo[0].X = respuesta[i].X;
                if (respuesta[i].Y < rectangulo[0].Y)
                    rectangulo[0].Y = respuesta[i].Y;

                if (respuesta[i].X > rectangulo[1].X)
                    rectangulo[1].X = respuesta[i].X;
                if (respuesta[i].Y < rectangulo[1].Y)
                    rectangulo[1].Y = respuesta[i].Y;

                if (respuesta[i].X > rectangulo[2].X)
                    rectangulo[2].X = respuesta[i].X;
                if (respuesta[i].Y > rectangulo[2].Y)
                    rectangulo[2].Y = respuesta[i].Y;

                if (respuesta[i].X < rectangulo[3].X)
                    rectangulo[3].X = respuesta[i].X;
                if (respuesta[i].Y > rectangulo[3].Y)
                    rectangulo[3].Y = respuesta[i].Y;
            }
            MostrarEje();
            MostrarPunto(respuesta);
            bf.Graphics.DrawPolygon(penGuia, rectangulo);


            return respuesta;
        }
        PointF Convertir(PointF punto)
        {
            PointF respuesta = new PointF(punto.X - eje.X, eje.Y - punto.Y);

            return respuesta;
        }
        #endregion
        #region Botones
        private void btnTamano_Click(object sender, EventArgs e)
        {
                double max = double.Parse(txtRelacion.Text);

                for (double i = 1; i >= max; i -= 0.0003)
                {
                    Limpiar();
                    bf.Graphics.DrawPolygon(penFigura, Agrandar(i));
                    bf.Render(CreateGraphics());
                }

                for (double i = 1; i <= max; i += 0.0003)
                {
                    Limpiar();
                    bf.Graphics.DrawPolygon(penFigura, Agrandar(i));
                    bf.Render(CreateGraphics());
                }

                imagen = Agrandar(max);
                Mostrar();
        }
        private void btnRotar_Click(object sender, EventArgs e)
        {
            try
            {
                    double ANGULO = -(double.Parse(txtAngulo.Text));

                    for (double i = 0; i < ANGULO; i += 0.1)
                    {
                        Limpiar();
                        bf.Graphics.DrawPolygon(penFigura, Rotar(i));
                        bf.Render(CreateGraphics());
                    }

                    for (double i = 0; i > ANGULO; i -= 0.1)
                    {
                        Limpiar();
                        bf.Graphics.DrawPolygon(penFigura, Rotar(i));
                        bf.Render(CreateGraphics());
                    }

                    imagen = Rotar(ANGULO);
                    Mostrar();
            }
            catch { }
        }
        private void btnTransformar_Click(object sender, EventArgs e)
        {
            float x = 1, y = 1;
            while (x <= float.Parse(txtX.Text) || y <= float.Parse(txtY.Text))
            {
                Limpiar();
                bf.Graphics.DrawPolygon(penFigura, Transformar(x, y));
                bf.Render(CreateGraphics());


                if (x < float.Parse(txtX.Text)) x += 0.001f;
                if (y < float.Parse(txtY.Text)) y += 0.001f;
            }

            while (x >= float.Parse(txtX.Text) || y >= float.Parse(txtY.Text))
            {
                Limpiar();
                bf.Graphics.DrawPolygon(penFigura, Transformar(x, y));
                bf.Render(CreateGraphics());


                if (x > float.Parse(txtX.Text)) x -= 0.001f;
                if (y > float.Parse(txtY.Text)) y -= 0.001f;
            }
            imagen = Transformar(x, y);
            Mostrar();
        }
        private void espejarEjeX_Click(object sender, EventArgs e)
        {
            imagen = Espejar(true);
            Mostrar();
        }
        private void espejarEjeY_Click(object sender, EventArgs e)
        {
            imagen = Espejar(false);
            Mostrar();
        }

        private void btnCentrarFoco_Click(object sender, EventArgs e)
        {
            foco = eje;
            Mostrar();
            b_foco = false;
        }
        private void btnCentrarEje_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(eje.X);
            y = Convert.ToInt32(eje.Y);

            eje.X = this.Size.Width / 2;
            eje.Y = this.Size.Height / 2;

            for (int i = 0; i < imagen.Length; i++)
            {
                imagen[i].X = eje.X - (x - imagen[i].X);
                imagen[i].Y = eje.Y - (y - imagen[i].Y);
            }
            foco = eje;
            Mostrar();
            b_eje = false;
        }
        private void btnElegirFoco_Click(object sender, EventArgs e)
        {
            b_foco = true;
        }
        private void btnElegirEje_Click(object sender, EventArgs e)
        {
            b_eje = true;
            b_foco = false;
        }
        #endregion
        #region Personalizar Colores 
        private void btnColorFigura_Click(object sender, EventArgs e)
        {
            ElegirColor.Color = penFigura.Color;

            if (ElegirColor.ShowDialog() == DialogResult.OK)
                penFigura.Color = ElegirColor.Color;

            Mostrar();
        }
        private void btnColorFoco_Click(object sender, EventArgs e)
        {
            ElegirColor.Color = penFoco.Color;

            if (ElegirColor.ShowDialog() == DialogResult.OK)
                penFoco.Color = ElegirColor.Color;

            Mostrar();
        }
        private void btnColorPuntos_Click(object sender, EventArgs e)
        {
            ElegirColor.Color = penPuntos.Color;

            if (ElegirColor.ShowDialog() == DialogResult.OK)
                penPuntos.Color = ElegirColor.Color;

            Mostrar();
        }
        private void btnColorGuia_Click(object sender, EventArgs e)
        {
            ElegirColor.Color = penGuia.Color;

            if (ElegirColor.ShowDialog() == DialogResult.OK)
                penGuia.Color = ElegirColor.Color;

            Mostrar();
        }
        #endregion
        #region Dibujar
        void Limpiar()
        {
            bf.Graphics.Clear(Color.White);
        }
        void Mostrar()
        {
            Limpiar();

            MostrarEje();

            //Dibuja la figura
            if (imagen.Length > 2)
                bf.Graphics.DrawPolygon(penFigura, imagen);
            else if (imagen.Length == 2)
                bf.Graphics.DrawLine(penFigura, imagen[0], imagen[1]);

            MostrarPunto(imagen);

            bf.Render(CreateGraphics());
        }
        void MostrarEje()
        {
            Pen pen = new Pen(Color.Black);
            Brush br = new SolidBrush(Color.Black);
            Point uno = new Point(this.Size.Width, Convert.ToInt32(eje.Y));
            Point dos = new Point(0, Convert.ToInt32(eje.Y));

            // Dibuja el eje de coordenadas;
            bf.Graphics.DrawLine(pen, eje, uno);
            bf.Graphics.DrawLine(pen, eje, dos);

            uno.X = Convert.ToInt32(eje.X); uno.Y = this.Size.Height;
            dos.X = Convert.ToInt32(eje.X); dos.Y = 0;

            bf.Graphics.DrawLine(pen, eje, uno);
            bf.Graphics.DrawLine(pen, eje, dos);

            pen.Color = Color.LightGray;
            for (int i = 0; i < this.Size.Width; i++)
            {
                if ((i - eje.X) % escala == 0 && (i - eje.X) != 0)
                {
                    uno.X = i; uno.Y = (int)eje.Y;
                    dos.X = i; dos.Y = 0;
                    bf.Graphics.DrawLine(pen, uno, dos);

                    dos.X = i; dos.Y = this.Size.Height;
                    bf.Graphics.DrawLine(pen, uno, dos);

                    bf.Graphics.DrawString((i - eje.X).ToString(), letra, br, i, eje.Y);
                }
            }
            for (int i = 0; i < this.Size.Height; i++)
            {
                if ((i - eje.Y) % escala == 0 && (i - eje.Y) != 0)
                {
                    uno.X = (int)eje.X; uno.Y = i;
                    dos.X = 0; dos.Y = i;
                    bf.Graphics.DrawLine(pen, uno, dos);

                    dos.X = this.Size.Width; dos.Y = i;
                    bf.Graphics.DrawLine(pen, uno, dos);

                    bf.Graphics.DrawString((eje.Y - i).ToString(), letra, br, eje.X, i);
                }
            }
            bf.Graphics.DrawString("0", letra, br, eje);
        }
        void CambiarEje()
        {
            for (int i = 0; i < imagen.Length; i++)
            {
                imagen[i].X = x - (eje.X - imagen[i].X);
                imagen[i].Y = y - (eje.Y - imagen[i].Y);
            }

            foco.X = x - (eje.X - foco.X);
            foco.Y = y - (eje.Y - foco.Y);

            eje.X = x;
            eje.Y = y;
        }
        void MostrarPunto(PointF[] img)
        {
            PointF n;
            Brush br = new SolidBrush(penPuntos.Color);
            for (int i = 0; i < img.Length; i++)//Dibuja los puntos de la figura
            {
                n = Convertir(img[i]);
                bf.Graphics.DrawRectangle(penPuntos, img[i].X, img[i].Y, 1, 1);
                bf.Graphics.DrawString("(" + Math.Ceiling(n.X) + ", " + Math.Ceiling(n.Y) + ")", letra, br, img[i].X, img[i].Y);
            }
            if (foco != eje)
            {
                bf.Graphics.DrawRectangle(penFoco, foco.X, foco.Y, 1, 1); //Dibuja el foco
                bf.Graphics.DrawString("F", letra, br, foco.X, foco.Y);
            }
        }

        #endregion
    }
    
}
