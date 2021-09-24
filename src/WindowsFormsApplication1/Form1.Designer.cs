namespace WindowsFormsApplication1
{
    partial class canvas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(canvas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPersonalizar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColorFigura = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColorFoco = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColorPuntos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColorGuia = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.optRelacion = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRelacion = new System.Windows.Forms.ToolStripTextBox();
            this.btnTamano = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ánguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAngulo = new System.Windows.Forms.ToolStripTextBox();
            this.btnRotar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ejeXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtX = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtY = new System.Windows.Forms.ToolStripTextBox();
            this.btnTransformar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.espejarEjeX = new System.Windows.Forms.ToolStripMenuItem();
            this.espejarEjeY = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton6 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnEjeCoordenadas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCentrarEje = new System.Windows.Forms.ToolStripMenuItem();
            this.btnElegirEje = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFoco = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCentrarFoco = new System.Windows.Forms.ToolStripMenuItem();
            this.btnElegirFoco = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.ElegirColor = new System.Windows.Forms.ColorDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton3,
            this.toolStripSeparator4,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton2,
            this.toolStripSeparator2,
            this.toolStripDropDownButton4,
            this.toolStripSeparator3,
            this.toolStripDropDownButton5,
            this.toolStripSeparator5,
            this.toolStripDropDownButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(671, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnAbrir,
            this.btnGuardar,
            this.btnPersonalizar,
            this.btnInformacion});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton3.Text = "Archivo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(139, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(139, 22);
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnPersonalizar
            // 
            this.btnPersonalizar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnColorFigura,
            this.btnColorFoco,
            this.btnColorPuntos,
            this.btnColorGuia});
            this.btnPersonalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonalizar.Image")));
            this.btnPersonalizar.Name = "btnPersonalizar";
            this.btnPersonalizar.Size = new System.Drawing.Size(139, 22);
            this.btnPersonalizar.Text = "Personalizar";
            // 
            // btnColorFigura
            // 
            this.btnColorFigura.Name = "btnColorFigura";
            this.btnColorFigura.Size = new System.Drawing.Size(166, 22);
            this.btnColorFigura.Text = "Color Figura";
            this.btnColorFigura.Click += new System.EventHandler(this.btnColorFigura_Click);
            // 
            // btnColorFoco
            // 
            this.btnColorFoco.Name = "btnColorFoco";
            this.btnColorFoco.Size = new System.Drawing.Size(166, 22);
            this.btnColorFoco.Text = "Color Foco";
            this.btnColorFoco.Click += new System.EventHandler(this.btnColorFoco_Click);
            // 
            // btnColorPuntos
            // 
            this.btnColorPuntos.Name = "btnColorPuntos";
            this.btnColorPuntos.Size = new System.Drawing.Size(166, 22);
            this.btnColorPuntos.Text = "Color Puntos";
            this.btnColorPuntos.Click += new System.EventHandler(this.btnColorPuntos_Click);
            // 
            // btnColorGuia
            // 
            this.btnColorGuia.Name = "btnColorGuia";
            this.btnColorGuia.Size = new System.Drawing.Size(166, 22);
            this.btnColorGuia.Text = "Color Lineas Guia";
            this.btnColorGuia.Click += new System.EventHandler(this.btnColorGuia_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Image = ((System.Drawing.Image)(resources.GetObject("btnInformacion.Image")));
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(139, 22);
            this.btnInformacion.Text = "Información";
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optRelacion,
            this.txtRelacion,
            this.btnTamano});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripDropDownButton1.Text = "Homotecia";
            // 
            // optRelacion
            // 
            this.optRelacion.Enabled = false;
            this.optRelacion.Name = "optRelacion";
            this.optRelacion.ShowShortcutKeys = false;
            this.optRelacion.Size = new System.Drawing.Size(160, 22);
            this.optRelacion.Text = "Escala:";
            // 
            // txtRelacion
            // 
            this.txtRelacion.Name = "txtRelacion";
            this.txtRelacion.Size = new System.Drawing.Size(100, 23);
            this.txtRelacion.Text = "1.2";
            this.txtRelacion.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRelacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRelacion_KeyPress);
            // 
            // btnTamano
            // 
            this.btnTamano.Name = "btnTamano";
            this.btnTamano.Size = new System.Drawing.Size(160, 22);
            this.btnTamano.Text = "Transformar";
            this.btnTamano.Click += new System.EventHandler(this.btnTamano_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ánguloToolStripMenuItem,
            this.txtAngulo,
            this.btnRotar});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton2.Text = "Girar";
            // 
            // ánguloToolStripMenuItem
            // 
            this.ánguloToolStripMenuItem.Enabled = false;
            this.ánguloToolStripMenuItem.Name = "ánguloToolStripMenuItem";
            this.ánguloToolStripMenuItem.ShowShortcutKeys = false;
            this.ánguloToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ánguloToolStripMenuItem.Text = "Ángulo:";
            // 
            // txtAngulo
            // 
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(100, 23);
            this.txtAngulo.Text = "20";
            this.txtAngulo.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAngulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAngulo_KeyPress);
            // 
            // btnRotar
            // 
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(160, 22);
            this.btnRotar.Text = "Rotar";
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejeXToolStripMenuItem,
            this.txtX,
            this.toolStripMenuItem1,
            this.txtY,
            this.btnTransformar});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(85, 22);
            this.toolStripDropDownButton4.Text = "Transformar";
            // 
            // ejeXToolStripMenuItem
            // 
            this.ejeXToolStripMenuItem.Enabled = false;
            this.ejeXToolStripMenuItem.Name = "ejeXToolStripMenuItem";
            this.ejeXToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ejeXToolStripMenuItem.Text = "Eje X:";
            // 
            // txtX
            // 
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 23);
            this.txtX.Text = "1.5";
            this.txtX.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem1.Text = "Eje Y:";
            // 
            // txtY
            // 
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 23);
            this.txtY.Text = "0.5";
            this.txtY.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // btnTransformar
            // 
            this.btnTransformar.Name = "btnTransformar";
            this.btnTransformar.Size = new System.Drawing.Size(160, 22);
            this.btnTransformar.Text = "Transformar";
            this.btnTransformar.Click += new System.EventHandler(this.btnTransformar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espejarEjeX,
            this.espejarEjeY});
            this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(57, 22);
            this.toolStripDropDownButton5.Text = "Espejar";
            // 
            // espejarEjeX
            // 
            this.espejarEjeX.Name = "espejarEjeX";
            this.espejarEjeX.Size = new System.Drawing.Size(99, 22);
            this.espejarEjeX.Text = "Eje X";
            this.espejarEjeX.Click += new System.EventHandler(this.espejarEjeX_Click);
            // 
            // espejarEjeY
            // 
            this.espejarEjeY.Name = "espejarEjeY";
            this.espejarEjeY.Size = new System.Drawing.Size(99, 22);
            this.espejarEjeY.Text = "Eje Y";
            this.espejarEjeY.Click += new System.EventHandler(this.espejarEjeY_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton6
            // 
            this.toolStripDropDownButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEjeCoordenadas,
            this.btnFoco});
            this.toolStripDropDownButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton6.Image")));
            this.toolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton6.Name = "toolStripDropDownButton6";
            this.toolStripDropDownButton6.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButton6.Text = "Elegir";
            // 
            // btnEjeCoordenadas
            // 
            this.btnEjeCoordenadas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCentrarEje,
            this.btnElegirEje});
            this.btnEjeCoordenadas.Name = "btnEjeCoordenadas";
            this.btnEjeCoordenadas.Size = new System.Drawing.Size(138, 22);
            this.btnEjeCoordenadas.Text = "Eje: E(0, 0)";
            // 
            // btnCentrarEje
            // 
            this.btnCentrarEje.Name = "btnCentrarEje";
            this.btnCentrarEje.Size = new System.Drawing.Size(131, 22);
            this.btnCentrarEje.Text = "Centrar eje";
            this.btnCentrarEje.Click += new System.EventHandler(this.btnCentrarEje_Click);
            // 
            // btnElegirEje
            // 
            this.btnElegirEje.Name = "btnElegirEje";
            this.btnElegirEje.Size = new System.Drawing.Size(131, 22);
            this.btnElegirEje.Text = "Elegir eje";
            this.btnElegirEje.Click += new System.EventHandler(this.btnElegirEje_Click);
            // 
            // btnFoco
            // 
            this.btnFoco.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCentrarFoco,
            this.btnElegirFoco});
            this.btnFoco.Name = "btnFoco";
            this.btnFoco.Size = new System.Drawing.Size(138, 22);
            this.btnFoco.Text = "Foco: F(0, 0)";
            // 
            // btnCentrarFoco
            // 
            this.btnCentrarFoco.Name = "btnCentrarFoco";
            this.btnCentrarFoco.Size = new System.Drawing.Size(140, 22);
            this.btnCentrarFoco.Text = "Centrar foco";
            this.btnCentrarFoco.Click += new System.EventHandler(this.btnCentrarFoco_Click);
            // 
            // btnElegirFoco
            // 
            this.btnElegirFoco.Name = "btnElegirFoco";
            this.btnElegirFoco.Size = new System.Drawing.Size(140, 22);
            this.btnElegirFoco.Text = "Elegir foco";
            this.btnElegirFoco.Click += new System.EventHandler(this.btnElegirFoco_Click);
            // 
            // canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(671, 400);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(687, 439);
            this.Name = "canvas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matemática Discreta";
            this.Click += new System.EventHandler(this.canvas_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.canvas_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.Move += new System.EventHandler(this.canvas_Resize);
            this.Resize += new System.EventHandler(this.canvas_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem optRelacion;
        private System.Windows.Forms.ToolStripMenuItem btnTamano;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem ánguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtAngulo;
        private System.Windows.Forms.ToolStripMenuItem btnRotar;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem btnNuevo;
        private System.Windows.Forms.ToolStripMenuItem btnAbrir;
        private System.Windows.Forms.ToolStripMenuItem btnGuardar;
        private System.Windows.Forms.ToolStripMenuItem btnInformacion;
        private System.Windows.Forms.ToolStripTextBox txtRelacion;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem btnTransformar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ejeXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox txtY;
        private System.Windows.Forms.ToolStripTextBox txtX;
        private System.Windows.Forms.ToolStripMenuItem btnPersonalizar;
        private System.Windows.Forms.ToolStripMenuItem btnColorFigura;
        private System.Windows.Forms.ToolStripMenuItem btnColorPuntos;
        private System.Windows.Forms.ToolStripMenuItem btnColorGuia;
        private System.Windows.Forms.ColorDialog ElegirColor;
        private System.Windows.Forms.ToolStripMenuItem btnColorFoco;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        private System.Windows.Forms.ToolStripMenuItem espejarEjeX;
        private System.Windows.Forms.ToolStripMenuItem espejarEjeY;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton6;
        private System.Windows.Forms.ToolStripMenuItem btnEjeCoordenadas;
        private System.Windows.Forms.ToolStripMenuItem btnFoco;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem btnCentrarFoco;
        private System.Windows.Forms.ToolStripMenuItem btnCentrarEje;
        private System.Windows.Forms.ToolStripMenuItem btnElegirEje;
        private System.Windows.Forms.ToolStripMenuItem btnElegirFoco;
    }
}

