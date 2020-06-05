namespace StockManagement.Gestion
{
    partial class StockActual
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
            this.tabcontrol3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVtodo = new System.Windows.Forms.DataGridView();
            this.ActTodoBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVCxCat = new System.Windows.Forms.DataGridView();
            this.CxCatBT = new System.Windows.Forms.Button();
            this.CxCatCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVCxP = new System.Windows.Forms.DataGridView();
            this.CxProvBT = new System.Windows.Forms.Button();
            this.CxProvCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabcontrol3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtodo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCxCat)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCxP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol3
            // 
            this.tabcontrol3.Controls.Add(this.tabPage1);
            this.tabcontrol3.Controls.Add(this.tabPage2);
            this.tabcontrol3.Controls.Add(this.tabPage3);
            this.tabcontrol3.Location = new System.Drawing.Point(12, 12);
            this.tabcontrol3.Name = "Consulta por Proveedor";
            this.tabcontrol3.SelectedIndex = 0;
            this.tabcontrol3.Size = new System.Drawing.Size(776, 426);
            this.tabcontrol3.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVtodo);
            this.tabPage1.Controls.Add(this.ActTodoBT);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "Todos los productos";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Todos los productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVtodo
            // 
            this.DGVtodo.AllowUserToAddRows = false;
            this.DGVtodo.AllowUserToDeleteRows = false;
            this.DGVtodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtodo.Location = new System.Drawing.Point(6, 62);
            this.DGVtodo.Name = "DGVtodo";
            this.DGVtodo.ReadOnly = true;
            this.DGVtodo.Size = new System.Drawing.Size(756, 332);
            this.DGVtodo.TabIndex = 31;
            // 
            // ActTodoBT
            // 
            this.ActTodoBT.Location = new System.Drawing.Point(619, 23);
            this.ActTodoBT.Name = "ActTodoBT";
            this.ActTodoBT.Size = new System.Drawing.Size(107, 33);
            this.ActTodoBT.TabIndex = 30;
            this.ActTodoBT.Text = "Actualizar ";
            this.ActTodoBT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(273, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Todos los Productos";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVCxCat);
            this.tabPage2.Controls.Add(this.CxCatBT);
            this.tabPage2.Controls.Add(this.CxCatCB);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "Consulta por categoria";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta por categoria";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVCxCat
            // 
            this.DGVCxCat.AllowUserToAddRows = false;
            this.DGVCxCat.AllowUserToDeleteRows = false;
            this.DGVCxCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCxCat.Location = new System.Drawing.Point(6, 90);
            this.DGVCxCat.Name = "DGVCxCat";
            this.DGVCxCat.ReadOnly = true;
            this.DGVCxCat.Size = new System.Drawing.Size(756, 304);
            this.DGVCxCat.TabIndex = 32;
            // 
            // CxCatBT
            // 
            this.CxCatBT.Location = new System.Drawing.Point(566, 39);
            this.CxCatBT.Name = "CxCatBT";
            this.CxCatBT.Size = new System.Drawing.Size(107, 33);
            this.CxCatBT.TabIndex = 25;
            this.CxCatBT.Text = "Consulta";
            this.CxCatBT.UseVisualStyleBackColor = true;
            this.CxCatBT.Click += new System.EventHandler(this.CxCatBT_Click);
            // 
            // CxCatCB
            // 
            this.CxCatCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CxCatCB.FormattingEnabled = true;
            this.CxCatCB.Location = new System.Drawing.Point(207, 39);
            this.CxCatCB.Name = "CxCatCB";
            this.CxCatCB.Size = new System.Drawing.Size(330, 33);
            this.CxCatCB.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label8.Location = new System.Drawing.Point(96, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Categoria:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVCxP);
            this.tabPage3.Controls.Add(this.CxProvBT);
            this.tabPage3.Controls.Add(this.CxProvCB);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consulta por Proveedor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVCxP
            // 
            this.DGVCxP.AllowUserToAddRows = false;
            this.DGVCxP.AllowUserToDeleteRows = false;
            this.DGVCxP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCxP.Location = new System.Drawing.Point(9, 90);
            this.DGVCxP.Name = "DGVCxP";
            this.DGVCxP.ReadOnly = true;
            this.DGVCxP.Size = new System.Drawing.Size(756, 304);
            this.DGVCxP.TabIndex = 33;
            // 
            // CxProvBT
            // 
            this.CxProvBT.Location = new System.Drawing.Point(572, 39);
            this.CxProvBT.Name = "CxProvBT";
            this.CxProvBT.Size = new System.Drawing.Size(107, 33);
            this.CxProvBT.TabIndex = 29;
            this.CxProvBT.Text = "Consulta";
            this.CxProvBT.UseVisualStyleBackColor = true;
            this.CxProvBT.Click += new System.EventHandler(this.CxProvBT_Click);
            // 
            // CxProvCB
            // 
            this.CxProvCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CxProvCB.FormattingEnabled = true;
            this.CxProvCB.Location = new System.Drawing.Point(213, 39);
            this.CxProvCB.Name = "CxProvCB";
            this.CxProvCB.Size = new System.Drawing.Size(330, 33);
            this.CxProvCB.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.Location = new System.Drawing.Point(93, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 26);
            this.label9.TabIndex = 27;
            this.label9.Text = "Proveedor:";
            // 
            // StockActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcontrol3);
            this.Name = "StockActual";
            this.Text = "Stock Actual";
            this.Load += new System.EventHandler(this.StockActual_Load);
            this.tabcontrol3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtodo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCxCat)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCxP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ActTodoBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVtodo;
        private System.Windows.Forms.Button CxCatBT;
        private System.Windows.Forms.ComboBox CxCatCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGVCxCat;
        private System.Windows.Forms.DataGridView DGVCxP;
        private System.Windows.Forms.Button CxProvBT;
        private System.Windows.Forms.ComboBox CxProvCB;
        private System.Windows.Forms.Label label9;
    }
}