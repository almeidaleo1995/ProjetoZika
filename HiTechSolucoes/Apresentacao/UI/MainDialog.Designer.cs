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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.DashBoardGrid = new System.Windows.Forms.TabPage();
            this.FornecedoresGrid = new System.Windows.Forms.TabPage();
            this.NotaFiscaisGrid = new System.Windows.Forms.TabPage();
            this.ProdutosGrid = new System.Windows.Forms.TabPage();
            this.UsuariosGrid = new System.Windows.Forms.TabPage();
            this.RelatoriosGrid = new System.Windows.Forms.TabPage();
            this.SeusDadosGrid = new System.Windows.Forms.TabPage();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.DashBoardGrid);
            this.metroTabControl1.Controls.Add(this.FornecedoresGrid);
            this.metroTabControl1.Controls.Add(this.NotaFiscaisGrid);
            this.metroTabControl1.Controls.Add(this.ProdutosGrid);
            this.metroTabControl1.Controls.Add(this.UsuariosGrid);
            this.metroTabControl1.Controls.Add(this.RelatoriosGrid);
            this.metroTabControl1.Controls.Add(this.SeusDadosGrid);
            this.metroTabControl1.Location = new System.Drawing.Point(35, 95);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
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
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainDialog";
            this.Text = "HiTech Solution";
            this.metroTabControl1.ResumeLayout(false);
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
    }
}