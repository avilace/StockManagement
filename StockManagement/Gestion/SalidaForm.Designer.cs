namespace StockManagement.Gestion
{
    partial class SalidaForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FinBT = new System.Windows.Forms.Button();
            this.addProdBT = new System.Windows.Forms.Button();
            this.textBoxCant = new System.Windows.Forms.TextBox();
            this.LBCmax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addProdCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addCompradorCB = new System.Windows.Forms.ComboBox();
            this.addDGV = new System.Windows.Forms.DataGridView();
            this.addCodEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CargarCxProd = new System.Windows.Forms.Button();
            this.cxProd = new System.Windows.Forms.DataGridView();
            this.CxProdCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CxCat = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.CxCatCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CxProv = new System.Windows.Forms.DataGridView();
            this.CxProvBT = new System.Windows.Forms.Button();
            this.CxProveedorCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.CxIDDGV = new System.Windows.Forms.DataGridView();
            this.CxID = new System.Windows.Forms.Button();
            this.IdEntradaCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cxProd)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CxCat)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CxProv)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CxIDDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FinBT);
            this.tabPage1.Controls.Add(this.addProdBT);
            this.tabPage1.Controls.Add(this.textBoxCant);
            this.tabPage1.Controls.Add(this.LBCmax);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.addProdCB);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.addCompradorCB);
            this.tabPage1.Controls.Add(this.addDGV);
            this.tabPage1.Controls.Add(this.addCodEntrada);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nueva Entrada";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FinBT
            // 
            this.FinBT.Location = new System.Drawing.Point(563, 283);
            this.FinBT.Name = "FinBT";
            this.FinBT.Size = new System.Drawing.Size(155, 78);
            this.FinBT.TabIndex = 22;
            this.FinBT.Text = "Finalizar Pedido";
            this.FinBT.UseVisualStyleBackColor = true;
            this.FinBT.Click += new System.EventHandler(this.FinBT_Click);
            // 
            // addProdBT
            // 
            this.addProdBT.Location = new System.Drawing.Point(379, 253);
            this.addProdBT.Name = "addProdBT";
            this.addProdBT.Size = new System.Drawing.Size(107, 33);
            this.addProdBT.TabIndex = 20;
            this.addProdBT.Text = "Agregar Producto";
            this.addProdBT.UseVisualStyleBackColor = true;
            this.addProdBT.Click += new System.EventHandler(this.addProdBT_Click);
            // 
            // textBoxCant
            // 
            this.textBoxCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxCant.Location = new System.Drawing.Point(139, 353);
            this.textBoxCant.Name = "textBoxCant";
            this.textBoxCant.Size = new System.Drawing.Size(173, 32);
            this.textBoxCant.TabIndex = 19;
            // 
            // LBCmax
            // 
            this.LBCmax.AutoSize = true;
            this.LBCmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LBCmax.Location = new System.Drawing.Point(492, 352);
            this.LBCmax.Name = "LBCmax";
            this.LBCmax.Size = new System.Drawing.Size(33, 26);
            this.LBCmax.TabIndex = 18;
            this.LBCmax.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(334, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cantidad Max:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(15, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad:";
            // 
            // addProdCB
            // 
            this.addProdCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addProdCB.FormattingEnabled = true;
            this.addProdCB.Location = new System.Drawing.Point(139, 304);
            this.addProdCB.Name = "addProdCB";
            this.addProdCB.Size = new System.Drawing.Size(173, 33);
            this.addProdCB.TabIndex = 15;
            this.addProdCB.SelectedIndexChanged += new System.EventHandler(this.addProdCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(15, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(15, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Proveedor:";
            // 
            // addCompradorCB
            // 
            this.addCompradorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addCompradorCB.FormattingEnabled = true;
            this.addCompradorCB.Location = new System.Drawing.Point(139, 253);
            this.addCompradorCB.Name = "addCompradorCB";
            this.addCompradorCB.Size = new System.Drawing.Size(173, 33);
            this.addCompradorCB.TabIndex = 12;
            // 
            // addDGV
            // 
            this.addDGV.AllowUserToAddRows = false;
            this.addDGV.AllowUserToDeleteRows = false;
            this.addDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addDGV.Location = new System.Drawing.Point(20, 40);
            this.addDGV.Name = "addDGV";
            this.addDGV.ReadOnly = true;
            this.addDGV.Size = new System.Drawing.Size(716, 207);
            this.addDGV.TabIndex = 11;
            // 
            // addCodEntrada
            // 
            this.addCodEntrada.Enabled = false;
            this.addCodEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.addCodEntrada.Location = new System.Drawing.Point(85, 14);
            this.addCodEntrada.Name = "addCodEntrada";
            this.addCodEntrada.Size = new System.Drawing.Size(93, 20);
            this.addCodEntrada.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nº Entrada:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CargarCxProd);
            this.tabPage2.Controls.Add(this.cxProd);
            this.tabPage2.Controls.Add(this.CxProdCB);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta por Producto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CargarCxProd
            // 
            this.CargarCxProd.Location = new System.Drawing.Point(564, 57);
            this.CargarCxProd.Name = "CargarCxProd";
            this.CargarCxProd.Size = new System.Drawing.Size(107, 33);
            this.CargarCxProd.TabIndex = 21;
            this.CargarCxProd.Text = "Consulta";
            this.CargarCxProd.UseVisualStyleBackColor = true;
            this.CargarCxProd.Click += new System.EventHandler(this.CargarCxProd_Click);
            // 
            // cxProd
            // 
            this.cxProd.AllowUserToAddRows = false;
            this.cxProd.AllowUserToDeleteRows = false;
            this.cxProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cxProd.Location = new System.Drawing.Point(19, 122);
            this.cxProd.Name = "cxProd";
            this.cxProd.ReadOnly = true;
            this.cxProd.Size = new System.Drawing.Size(716, 259);
            this.cxProd.TabIndex = 17;
            // 
            // CxProdCB
            // 
            this.CxProdCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CxProdCB.FormattingEnabled = true;
            this.CxProdCB.Location = new System.Drawing.Point(204, 57);
            this.CxProdCB.Name = "CxProdCB";
            this.CxProdCB.Size = new System.Drawing.Size(330, 33);
            this.CxProdCB.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(93, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Producto:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CxCat);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.CxCatCB);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consulta por Categoria";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CxCat
            // 
            this.CxCat.AllowUserToAddRows = false;
            this.CxCat.AllowUserToDeleteRows = false;
            this.CxCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CxCat.Location = new System.Drawing.Point(19, 122);
            this.CxCat.Name = "CxCat";
            this.CxCat.ReadOnly = true;
            this.CxCat.Size = new System.Drawing.Size(716, 259);
            this.CxCat.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CxCatCB
            // 
            this.CxCatCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CxCatCB.FormattingEnabled = true;
            this.CxCatCB.Location = new System.Drawing.Point(204, 57);
            this.CxCatCB.Name = "CxCatCB";
            this.CxCatCB.Size = new System.Drawing.Size(330, 33);
            this.CxCatCB.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label8.Location = new System.Drawing.Point(93, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Categoria:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CxProv);
            this.tabPage4.Controls.Add(this.CxProvBT);
            this.tabPage4.Controls.Add(this.CxProveedorCB);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(767, 399);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consulta por Proveedor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CxProv
            // 
            this.CxProv.AllowUserToAddRows = false;
            this.CxProv.AllowUserToDeleteRows = false;
            this.CxProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CxProv.Location = new System.Drawing.Point(19, 121);
            this.CxProv.Name = "CxProv";
            this.CxProv.ReadOnly = true;
            this.CxProv.Size = new System.Drawing.Size(716, 259);
            this.CxProv.TabIndex = 27;
            // 
            // CxProvBT
            // 
            this.CxProvBT.Location = new System.Drawing.Point(563, 56);
            this.CxProvBT.Name = "CxProvBT";
            this.CxProvBT.Size = new System.Drawing.Size(107, 33);
            this.CxProvBT.TabIndex = 26;
            this.CxProvBT.Text = "Consulta";
            this.CxProvBT.UseVisualStyleBackColor = true;
            this.CxProvBT.Click += new System.EventHandler(this.CxProvBT_Click);
            // 
            // CxProveedorCB
            // 
            this.CxProveedorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CxProveedorCB.FormattingEnabled = true;
            this.CxProveedorCB.Location = new System.Drawing.Point(204, 56);
            this.CxProveedorCB.Name = "CxProveedorCB";
            this.CxProveedorCB.Size = new System.Drawing.Size(330, 33);
            this.CxProveedorCB.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.Location = new System.Drawing.Point(91, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Proveedor:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.CxIDDGV);
            this.tabPage5.Controls.Add(this.CxID);
            this.tabPage5.Controls.Add(this.IdEntradaCB);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(767, 399);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Consulta por Entrada";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // CxIDDGV
            // 
            this.CxIDDGV.AllowUserToAddRows = false;
            this.CxIDDGV.AllowUserToDeleteRows = false;
            this.CxIDDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CxIDDGV.Location = new System.Drawing.Point(19, 120);
            this.CxIDDGV.Name = "CxIDDGV";
            this.CxIDDGV.ReadOnly = true;
            this.CxIDDGV.Size = new System.Drawing.Size(716, 259);
            this.CxIDDGV.TabIndex = 31;
            // 
            // CxID
            // 
            this.CxID.Location = new System.Drawing.Point(563, 55);
            this.CxID.Name = "CxID";
            this.CxID.Size = new System.Drawing.Size(107, 33);
            this.CxID.TabIndex = 30;
            this.CxID.Text = "Consulta";
            this.CxID.UseVisualStyleBackColor = true;
            this.CxID.Click += new System.EventHandler(this.CxID_Click);
            // 
            // IdEntradaCB
            // 
            this.IdEntradaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.IdEntradaCB.FormattingEnabled = true;
            this.IdEntradaCB.Location = new System.Drawing.Point(204, 55);
            this.IdEntradaCB.Name = "IdEntradaCB";
            this.IdEntradaCB.Size = new System.Drawing.Size(330, 33);
            this.IdEntradaCB.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.Location = new System.Drawing.Point(91, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "IdSalida:";
            // 
            // SalidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "SalidaForm";
            this.Text = "SalidaForm";
            this.Load += new System.EventHandler(this.SalidaForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cxProd)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CxCat)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CxProv)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CxIDDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button FinBT;
        private System.Windows.Forms.Button addProdBT;
        private System.Windows.Forms.TextBox textBoxCant;
        private System.Windows.Forms.Label LBCmax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addProdCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addCompradorCB;
        private System.Windows.Forms.DataGridView addDGV;
        private System.Windows.Forms.TextBox addCodEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CargarCxProd;
        private System.Windows.Forms.DataGridView cxProd;
        private System.Windows.Forms.ComboBox CxProdCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView CxCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CxCatCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView CxProv;
        private System.Windows.Forms.Button CxProvBT;
        private System.Windows.Forms.ComboBox CxProveedorCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView CxIDDGV;
        private System.Windows.Forms.Button CxID;
        private System.Windows.Forms.ComboBox IdEntradaCB;
        private System.Windows.Forms.Label label10;
    }
}