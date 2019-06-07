namespace Apresentacao.UI
{
    partial class MainDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.DashBoardGrid = new System.Windows.Forms.TabPage();
            this.FornecedoresGrid = new System.Windows.Forms.TabPage();
            this.NotaFiscaisGrid = new System.Windows.Forms.TabPage();
            this.ProdutosGrid = new System.Windows.Forms.TabPage();
            this.UsuariosGrid = new System.Windows.Forms.TabPage();
            this.RelatoriosGrid = new System.Windows.Forms.TabPage();
            this.SeusDadosGrid = new System.Windows.Forms.TabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.AddUser = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.UsuariosGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.DashBoardGrid);
            this.metroTabControl1.Controls.Add(this.UsuariosGrid);
            this.metroTabControl1.Controls.Add(this.NotaFiscaisGrid);
            this.metroTabControl1.Controls.Add(this.ProdutosGrid);
            this.metroTabControl1.Controls.Add(this.RelatoriosGrid);
            this.metroTabControl1.Controls.Add(this.FornecedoresGrid);
            this.metroTabControl1.Controls.Add(this.SeusDadosGrid);
            this.metroTabControl1.Location = new System.Drawing.Point(35, 95);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(884, 417);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // DashBoardGrid
            // 
            this.DashBoardGrid.Location = new System.Drawing.Point(4, 38);
            this.DashBoardGrid.Name = "DashBoardGrid";
            this.DashBoardGrid.Size = new System.Drawing.Size(876, 375);
            this.DashBoardGrid.TabIndex = 0;
            this.DashBoardGrid.Text = "[dashboard]";
            // 
            // FornecedoresGrid
            // 
            this.FornecedoresGrid.Location = new System.Drawing.Point(4, 38);
            this.FornecedoresGrid.Name = "FornecedoresGrid";
            this.FornecedoresGrid.Size = new System.Drawing.Size(876, 375);
            this.FornecedoresGrid.TabIndex = 1;
            this.FornecedoresGrid.Text = "[fornecedores]";
            // 
            // NotaFiscaisGrid
            // 
            this.NotaFiscaisGrid.Location = new System.Drawing.Point(4, 38);
            this.NotaFiscaisGrid.Name = "NotaFiscaisGrid";
            this.NotaFiscaisGrid.Size = new System.Drawing.Size(876, 375);
            this.NotaFiscaisGrid.TabIndex = 2;
            this.NotaFiscaisGrid.Text = "[notafiscais]";
            // 
            // ProdutosGrid
            // 
            this.ProdutosGrid.Location = new System.Drawing.Point(4, 38);
            this.ProdutosGrid.Name = "ProdutosGrid";
            this.ProdutosGrid.Size = new System.Drawing.Size(876, 375);
            this.ProdutosGrid.TabIndex = 3;
            this.ProdutosGrid.Text = "[produtos]";
            // 
            // UsuariosGrid
            // 
            this.UsuariosGrid.BackColor = System.Drawing.Color.White;
            this.UsuariosGrid.Controls.Add(this.AddUser);
            this.UsuariosGrid.Controls.Add(this.metroGrid1);
            this.UsuariosGrid.Location = new System.Drawing.Point(4, 38);
            this.UsuariosGrid.Name = "UsuariosGrid";
            this.UsuariosGrid.Size = new System.Drawing.Size(876, 375);
            this.UsuariosGrid.TabIndex = 4;
            this.UsuariosGrid.Text = "[usuarios]";
            // 
            // RelatoriosGrid
            // 
            this.RelatoriosGrid.Location = new System.Drawing.Point(4, 38);
            this.RelatoriosGrid.Name = "RelatoriosGrid";
            this.RelatoriosGrid.Size = new System.Drawing.Size(876, 375);
            this.RelatoriosGrid.TabIndex = 5;
            this.RelatoriosGrid.Text = "[relatorios]";
            // 
            // SeusDadosGrid
            // 
            this.SeusDadosGrid.Location = new System.Drawing.Point(4, 38);
            this.SeusDadosGrid.Name = "SeusDadosGrid";
            this.SeusDadosGrid.Size = new System.Drawing.Size(876, 375);
            this.SeusDadosGrid.TabIndex = 6;
            this.SeusDadosGrid.Text = "[seusdados]";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(32, 73);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(801, 269);
            this.metroGrid1.TabIndex = 0;
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(557, 21);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(113, 23);
            this.AddUser.TabIndex = 1;
            this.AddUser.Text = "[addButon]";
            this.AddUser.UseSelectable = true;
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainDialog";
            this.Text = "HiTech Solution";
            this.metroTabControl1.ResumeLayout(false);
            this.UsuariosGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage DashBoardGrid;
        private System.Windows.Forms.TabPage FornecedoresGrid;
        private System.Windows.Forms.TabPage NotaFiscaisGrid;
        private System.Windows.Forms.TabPage ProdutosGrid;
        private System.Windows.Forms.TabPage UsuariosGrid;
        private System.Windows.Forms.TabPage RelatoriosGrid;
        private System.Windows.Forms.TabPage SeusDadosGrid;
        private MetroFramework.Controls.MetroButton AddUser;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}