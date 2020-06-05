namespace StockManagement.Mantenimientos
{
    partial class MantenimientoCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.delCategoriaGrid1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addButton = new System.Windows.Forms.Button();
            this.addDGV = new System.Windows.Forms.DataGridView();
            this.addDesc = new System.Windows.Forms.TextBox();
            this.addNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.delCategoriaButton = new System.Windows.Forms.Button();
            this.delNombreCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.delDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.modIdLb = new System.Windows.Forms.Label();
            this.cargaCatButton = new System.Windows.Forms.Button();
            this.ModCategoriaButton = new System.Windows.Forms.Button();
            this.modDesc = new System.Windows.Forms.TextBox();
            this.modNombre = new System.Windows.Forms.TextBox();
            this.modNombreCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.modDGV = new System.Windows.Forms.DataGridView();
            this.modId = new System.Windows.Forms.TextBox();
            this.delCategoriaGrid1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delDGV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(131, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO CATEGORIAS";
            // 
            // delCategoriaGrid1
            // 
            this.delCategoriaGrid1.Controls.Add(this.tabPage1);
            this.delCategoriaGrid1.Controls.Add(this.tabPage2);
            this.delCategoriaGrid1.Controls.Add(this.tabPage3);
            this.delCategoriaGrid1.Location = new System.Drawing.Point(13, 13);
            this.delCategoriaGrid1.Name = "delCategoriaGrid1";
            this.delCategoriaGrid1.SelectedIndex = 0;
            this.delCategoriaGrid1.Size = new System.Drawing.Size(775, 432);
            this.delCategoriaGrid1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.addDGV);
            this.tabPage1.Controls.Add(this.addDesc);
            this.tabPage1.Controls.Add(this.addNombre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Añadir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(561, 66);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(127, 37);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Añadir";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addDGV
            // 
            this.addDGV.AllowUserToAddRows = false;
            this.addDGV.AllowUserToDeleteRows = false;
            this.addDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addDGV.Location = new System.Drawing.Point(21, 186);
            this.addDGV.Name = "addDGV";
            this.addDGV.ReadOnly = true;
            this.addDGV.Size = new System.Drawing.Size(716, 207);
            this.addDGV.TabIndex = 10;
            // 
            // addDesc
            // 
            this.addDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addDesc.Location = new System.Drawing.Point(118, 116);
            this.addDesc.Multiline = true;
            this.addDesc.Name = "addDesc";
            this.addDesc.Size = new System.Drawing.Size(570, 64);
            this.addDesc.TabIndex = 9;
            // 
            // addNombre
            // 
            this.addNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addNombre.Location = new System.Drawing.Point(118, 73);
            this.addNombre.Name = "addNombre";
            this.addNombre.Size = new System.Drawing.Size(152, 26);
            this.addNombre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.delCategoriaButton);
            this.tabPage2.Controls.Add(this.delNombreCb);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.delDGV);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // delCategoriaButton
            // 
            this.delCategoriaButton.Location = new System.Drawing.Point(582, 77);
            this.delCategoriaButton.Name = "delCategoriaButton";
            this.delCategoriaButton.Size = new System.Drawing.Size(127, 37);
            this.delCategoriaButton.TabIndex = 14;
            this.delCategoriaButton.Text = "Eliminar";
            this.delCategoriaButton.UseVisualStyleBackColor = true;
            this.delCategoriaButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // delNombreCb
            // 
            this.delNombreCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delNombreCb.FormattingEnabled = true;
            this.delNombreCb.Location = new System.Drawing.Point(117, 86);
            this.delNombreCb.Name = "delNombreCb";
            this.delNombreCb.Size = new System.Drawing.Size(272, 28);
            this.delNombreCb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(18, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre:";
            // 
            // delDGV
            // 
            this.delDGV.AllowUserToAddRows = false;
            this.delDGV.AllowUserToDeleteRows = false;
            this.delDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delDGV.Location = new System.Drawing.Point(22, 163);
            this.delDGV.Name = "delDGV";
            this.delDGV.ReadOnly = true;
            this.delDGV.Size = new System.Drawing.Size(716, 237);
            this.delDGV.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(131, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "MANTENIMIENTO CATEGORIAS";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.modId);
            this.tabPage3.Controls.Add(this.modIdLb);
            this.tabPage3.Controls.Add(this.cargaCatButton);
            this.tabPage3.Controls.Add(this.ModCategoriaButton);
            this.tabPage3.Controls.Add(this.modDesc);
            this.tabPage3.Controls.Add(this.modNombre);
            this.tabPage3.Controls.Add(this.modNombreCb);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.modDGV);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // modIdLb
            // 
            this.modIdLb.AutoSize = true;
            this.modIdLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modIdLb.Location = new System.Drawing.Point(18, 117);
            this.modIdLb.Name = "modIdLb";
            this.modIdLb.Size = new System.Drawing.Size(34, 20);
            this.modIdLb.TabIndex = 22;
            this.modIdLb.Text = "ID: ";
            // 
            // cargaCatButton
            // 
            this.cargaCatButton.Location = new System.Drawing.Point(417, 71);
            this.cargaCatButton.Name = "cargaCatButton";
            this.cargaCatButton.Size = new System.Drawing.Size(127, 37);
            this.cargaCatButton.TabIndex = 21;
            this.cargaCatButton.Text = "Cargar";
            this.cargaCatButton.UseVisualStyleBackColor = true;
            this.cargaCatButton.Click += new System.EventHandler(this.carButton_Click);
            // 
            // ModCategoriaButton
            // 
            this.ModCategoriaButton.Location = new System.Drawing.Point(562, 71);
            this.ModCategoriaButton.Name = "ModCategoriaButton";
            this.ModCategoriaButton.Size = new System.Drawing.Size(127, 37);
            this.ModCategoriaButton.TabIndex = 20;
            this.ModCategoriaButton.Text = "Modificar";
            this.ModCategoriaButton.UseVisualStyleBackColor = true;
            this.ModCategoriaButton.Click += new System.EventHandler(this.modButton_Click);
            // 
            // modDesc
            // 
            this.modDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modDesc.Location = new System.Drawing.Point(22, 140);
            this.modDesc.Multiline = true;
            this.modDesc.Name = "modDesc";
            this.modDesc.Size = new System.Drawing.Size(570, 64);
            this.modDesc.TabIndex = 19;
            // 
            // modNombre
            // 
            this.modNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modNombre.Location = new System.Drawing.Point(260, 111);
            this.modNombre.Name = "modNombre";
            this.modNombre.Size = new System.Drawing.Size(152, 26);
            this.modNombre.TabIndex = 18;
            // 
            // modNombreCb
            // 
            this.modNombreCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modNombreCb.FormattingEnabled = true;
            this.modNombreCb.Location = new System.Drawing.Point(93, 71);
            this.modNombreCb.Name = "modNombreCb";
            this.modNombreCb.Size = new System.Drawing.Size(272, 28);
            this.modNombreCb.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(496, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Descripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(134, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nuevo Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(18, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.Location = new System.Drawing.Point(131, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(504, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "MANTENIMIENTO CATEGORIAS";
            // 
            // modDGV
            // 
            this.modDGV.AllowUserToAddRows = false;
            this.modDGV.AllowUserToDeleteRows = false;
            this.modDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modDGV.Location = new System.Drawing.Point(22, 210);
            this.modDGV.Name = "modDGV";
            this.modDGV.ReadOnly = true;
            this.modDGV.Size = new System.Drawing.Size(716, 190);
            this.modDGV.TabIndex = 12;
            // 
            // modId
            // 
            this.modId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modId.Location = new System.Drawing.Point(48, 111);
            this.modId.Name = "modId";
            this.modId.ReadOnly = true;
            this.modId.Size = new System.Drawing.Size(69, 26);
            this.modId.TabIndex = 23;
            // 
            // MantenimientoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delCategoriaGrid1);
            this.Name = "MantenimientoCategoria";
            this.Text = "MantenimientoCategoria";
            this.Load += new System.EventHandler(this.MantenimientoCategoria_Load);
            this.delCategoriaGrid1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delDGV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl delCategoriaGrid1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView addDGV;
        private System.Windows.Forms.TextBox addDesc;
        private System.Windows.Forms.TextBox addNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView delDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView modDGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox delNombreCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delCategoriaButton;
        private System.Windows.Forms.TextBox modDesc;
        private System.Windows.Forms.TextBox modNombre;
        private System.Windows.Forms.ComboBox modNombreCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ModCategoriaButton;
        private System.Windows.Forms.Button cargaCatButton;
        private System.Windows.Forms.Label modIdLb;
        private System.Windows.Forms.TextBox modId;
    }
}