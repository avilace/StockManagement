namespace StockManagement
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EtiquetaTitulo = new System.Windows.Forms.Label();
            this.EntradaMainMenu = new System.Windows.Forms.Button();
            this.EtiquetaMantenimiento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalidaMainMenu = new System.Windows.Forms.Button();
            this.CateogriasMainMenu = new System.Windows.Forms.Button();
            this.ProductosMainMenu = new System.Windows.Forms.Button();
            this.ProveedoresMainMenu = new System.Windows.Forms.Button();
            this.CompradoresMainMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EtiquetaTitulo
            // 
            this.EtiquetaTitulo.AutoSize = true;
            this.EtiquetaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.EtiquetaTitulo.Location = new System.Drawing.Point(224, 35);
            this.EtiquetaTitulo.Name = "EtiquetaTitulo";
            this.EtiquetaTitulo.Size = new System.Drawing.Size(490, 51);
            this.EtiquetaTitulo.TabIndex = 0;
            this.EtiquetaTitulo.Text = "STOCK MANAGEMENT";
            // 
            // EntradaMainMenu
            // 
            this.EntradaMainMenu.Location = new System.Drawing.Point(145, 171);
            this.EntradaMainMenu.Name = "EntradaMainMenu";
            this.EntradaMainMenu.Size = new System.Drawing.Size(183, 49);
            this.EntradaMainMenu.TabIndex = 1;
            this.EntradaMainMenu.Text = "ENTRADA DE MATERIAL";
            this.EntradaMainMenu.UseVisualStyleBackColor = true;
            this.EntradaMainMenu.Click += new System.EventHandler(this.EntradaMainMenu_Click);
            // 
            // EtiquetaMantenimiento
            // 
            this.EtiquetaMantenimiento.AutoSize = true;
            this.EtiquetaMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.EtiquetaMantenimiento.Location = new System.Drawing.Point(543, 110);
            this.EtiquetaMantenimiento.Name = "EtiquetaMantenimiento";
            this.EtiquetaMantenimiento.Size = new System.Drawing.Size(307, 37);
            this.EtiquetaMantenimiento.TabIndex = 2;
            this.EtiquetaMantenimiento.Text = "MANTENIMIENTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(139, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "GESTIÓN";
            // 
            // SalidaMainMenu
            // 
            this.SalidaMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SalidaMainMenu.Location = new System.Drawing.Point(146, 261);
            this.SalidaMainMenu.Name = "SalidaMainMenu";
            this.SalidaMainMenu.Size = new System.Drawing.Size(182, 47);
            this.SalidaMainMenu.TabIndex = 4;
            this.SalidaMainMenu.Text = "SALIDA DE MATERIAL";
            this.SalidaMainMenu.UseVisualStyleBackColor = true;
            this.SalidaMainMenu.Click += new System.EventHandler(this.SalidaMainMenu_Click);
            // 
            // CateogriasMainMenu
            // 
            this.CateogriasMainMenu.Location = new System.Drawing.Point(612, 171);
            this.CateogriasMainMenu.Name = "CateogriasMainMenu";
            this.CateogriasMainMenu.Size = new System.Drawing.Size(162, 49);
            this.CateogriasMainMenu.TabIndex = 5;
            this.CateogriasMainMenu.Text = "Mant. Categorias";
            this.CateogriasMainMenu.UseVisualStyleBackColor = true;
            this.CateogriasMainMenu.Click += new System.EventHandler(this.CateogriasMainMenu_Click);
            // 
            // ProductosMainMenu
            // 
            this.ProductosMainMenu.Location = new System.Drawing.Point(612, 234);
            this.ProductosMainMenu.Name = "ProductosMainMenu";
            this.ProductosMainMenu.Size = new System.Drawing.Size(162, 49);
            this.ProductosMainMenu.TabIndex = 6;
            this.ProductosMainMenu.Text = "Mant. Productos";
            this.ProductosMainMenu.UseVisualStyleBackColor = true;
            this.ProductosMainMenu.Click += new System.EventHandler(this.ProductosMainMenu_Click);
            // 
            // ProveedoresMainMenu
            // 
            this.ProveedoresMainMenu.Location = new System.Drawing.Point(612, 296);
            this.ProveedoresMainMenu.Name = "ProveedoresMainMenu";
            this.ProveedoresMainMenu.Size = new System.Drawing.Size(162, 49);
            this.ProveedoresMainMenu.TabIndex = 7;
            this.ProveedoresMainMenu.Text = "Mant. Proveedores";
            this.ProveedoresMainMenu.UseVisualStyleBackColor = true;
            this.ProveedoresMainMenu.Click += new System.EventHandler(this.ProveedoresMainMenu_Click);
            // 
            // CompradoresMainMenu
            // 
            this.CompradoresMainMenu.Location = new System.Drawing.Point(612, 360);
            this.CompradoresMainMenu.Name = "CompradoresMainMenu";
            this.CompradoresMainMenu.Size = new System.Drawing.Size(162, 49);
            this.CompradoresMainMenu.TabIndex = 8;
            this.CompradoresMainMenu.Text = "Mant. Compradores";
            this.CompradoresMainMenu.UseVisualStyleBackColor = true;
            this.CompradoresMainMenu.Click += new System.EventHandler(this.CompradoresMainMenu_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(146, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "STOCK ACTUAL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CompradoresMainMenu);
            this.Controls.Add(this.ProveedoresMainMenu);
            this.Controls.Add(this.ProductosMainMenu);
            this.Controls.Add(this.CateogriasMainMenu);
            this.Controls.Add(this.SalidaMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EtiquetaMantenimiento);
            this.Controls.Add(this.EntradaMainMenu);
            this.Controls.Add(this.EtiquetaTitulo);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EtiquetaTitulo;
        private System.Windows.Forms.Button EntradaMainMenu;
        private System.Windows.Forms.Label EtiquetaMantenimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalidaMainMenu;
        private System.Windows.Forms.Button CateogriasMainMenu;
        private System.Windows.Forms.Button ProductosMainMenu;
        private System.Windows.Forms.Button ProveedoresMainMenu;
        private System.Windows.Forms.Button CompradoresMainMenu;
        private System.Windows.Forms.Button button1;
    }
}