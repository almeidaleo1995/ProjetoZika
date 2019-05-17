namespace ProjetoZicaLeonardoA.UI
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
            this.components = new System.ComponentModel.Container();
            this.TabControlProjeto = new MetroFramework.Controls.MetroTabControl();
            this.TpDashBoard = new MetroFramework.Controls.MetroTabPage();
            this.TpFornecedores = new MetroFramework.Controls.MetroTabPage();
            this.TpNotasFiscal = new MetroFramework.Controls.MetroTabPage();
            this.TpProdutos = new MetroFramework.Controls.MetroTabPage();
            this.TpUsuarios = new MetroFramework.Controls.MetroTabPage();
            this.TpRelatorios = new MetroFramework.Controls.MetroTabPage();
            this.TpSeusDados = new MetroFramework.Controls.MetroTabPage();
            this.leonardo_TesteDataSet = new ProjetoZicaLeonardoA.Leonardo_TesteDataSet();
            this.leonardoTesteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.leonardoTesteDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.leonardo_TesteDataSet1 = new ProjetoZicaLeonardoA.Leonardo_TesteDataSet1();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new ProjetoZicaLeonardoA.Leonardo_TesteDataSet1TableAdapters.ProductsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçãoprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipounidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControlProjeto.SuspendLayout();
            this.TpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leonardo_TesteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leonardoTesteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leonardoTesteDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leonardo_TesteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlProjeto
            // 
            this.TabControlProjeto.Controls.Add(this.TpDashBoard);
            this.TabControlProjeto.Controls.Add(this.TpFornecedores);
            this.TabControlProjeto.Controls.Add(this.TpNotasFiscal);
            this.TabControlProjeto.Controls.Add(this.TpProdutos);
            this.TabControlProjeto.Controls.Add(this.TpUsuarios);
            this.TabControlProjeto.Controls.Add(this.TpRelatorios);
            this.TabControlProjeto.Controls.Add(this.TpSeusDados);
            this.TabControlProjeto.Location = new System.Drawing.Point(38, 117);
            this.TabControlProjeto.Name = "TabControlProjeto";
            this.TabControlProjeto.SelectedIndex = 0;
            this.TabControlProjeto.Size = new System.Drawing.Size(1028, 610);
            this.TabControlProjeto.TabIndex = 0;
            this.TabControlProjeto.UseSelectable = true;
            // 
            // TpDashBoard
            // 
            this.TpDashBoard.HorizontalScrollbarBarColor = true;
            this.TpDashBoard.HorizontalScrollbarHighlightOnWheel = false;
            this.TpDashBoard.HorizontalScrollbarSize = 10;
            this.TpDashBoard.Location = new System.Drawing.Point(4, 38);
            this.TpDashBoard.Name = "TpDashBoard";
            this.TpDashBoard.Size = new System.Drawing.Size(1020, 568);
            this.TpDashBoard.TabIndex = 0;
            this.TpDashBoard.Text = "DashBoard";
            this.TpDashBoard.VerticalScrollbarBarColor = true;
            this.TpDashBoard.VerticalScrollbarHighlightOnWheel = false;
            this.TpDashBoard.VerticalScrollbarSize = 10;
            // 
            // TpFornecedores
            // 
            this.TpFornecedores.HorizontalScrollbarBarColor = true;
            this.TpFornecedores.HorizontalScrollbarHighlightOnWheel = false;
            this.TpFornecedores.HorizontalScrollbarSize = 10;
            this.TpFornecedores.Location = new System.Drawing.Point(4, 38);
            this.TpFornecedores.Name = "TpFornecedores";
            this.TpFornecedores.Size = new System.Drawing.Size(1020, 568);
            this.TpFornecedores.TabIndex = 1;
            this.TpFornecedores.Text = "Fornecedores";
            this.TpFornecedores.VerticalScrollbarBarColor = true;
            this.TpFornecedores.VerticalScrollbarHighlightOnWheel = false;
            this.TpFornecedores.VerticalScrollbarSize = 10;
            // 
            // TpNotasFiscal
            // 
            this.TpNotasFiscal.HorizontalScrollbarBarColor = true;
            this.TpNotasFiscal.HorizontalScrollbarHighlightOnWheel = false;
            this.TpNotasFiscal.HorizontalScrollbarSize = 10;
            this.TpNotasFiscal.Location = new System.Drawing.Point(4, 38);
            this.TpNotasFiscal.Name = "TpNotasFiscal";
            this.TpNotasFiscal.Size = new System.Drawing.Size(1020, 568);
            this.TpNotasFiscal.TabIndex = 2;
            this.TpNotasFiscal.Text = "NotasFiscal";
            this.TpNotasFiscal.VerticalScrollbarBarColor = true;
            this.TpNotasFiscal.VerticalScrollbarHighlightOnWheel = false;
            this.TpNotasFiscal.VerticalScrollbarSize = 10;
            // 
            // TpProdutos
            // 
            this.TpProdutos.Controls.Add(this.dataGridProduct);
            this.TpProdutos.HorizontalScrollbarBarColor = true;
            this.TpProdutos.HorizontalScrollbarHighlightOnWheel = false;
            this.TpProdutos.HorizontalScrollbarSize = 10;
            this.TpProdutos.Location = new System.Drawing.Point(4, 38);
            this.TpProdutos.Name = "TpProdutos";
            this.TpProdutos.Size = new System.Drawing.Size(1020, 568);
            this.TpProdutos.TabIndex = 3;
            this.TpProdutos.Text = "Produtos";
            this.TpProdutos.VerticalScrollbarBarColor = true;
            this.TpProdutos.VerticalScrollbarHighlightOnWheel = false;
            this.TpProdutos.VerticalScrollbarSize = 10;
            // 
            // TpUsuarios
            // 
            this.TpUsuarios.HorizontalScrollbarBarColor = true;
            this.TpUsuarios.HorizontalScrollbarHighlightOnWheel = false;
            this.TpUsuarios.HorizontalScrollbarSize = 10;
            this.TpUsuarios.Location = new System.Drawing.Point(4, 38);
            this.TpUsuarios.Name = "TpUsuarios";
            this.TpUsuarios.Size = new System.Drawing.Size(1020, 568);
            this.TpUsuarios.TabIndex = 4;
            this.TpUsuarios.Text = "Usuários";
            this.TpUsuarios.VerticalScrollbarBarColor = true;
            this.TpUsuarios.VerticalScrollbarHighlightOnWheel = false;
            this.TpUsuarios.VerticalScrollbarSize = 10;
            // 
            // TpRelatorios
            // 
            this.TpRelatorios.HorizontalScrollbarBarColor = true;
            this.TpRelatorios.HorizontalScrollbarHighlightOnWheel = false;
            this.TpRelatorios.HorizontalScrollbarSize = 10;
            this.TpRelatorios.Location = new System.Drawing.Point(4, 38);
            this.TpRelatorios.Name = "TpRelatorios";
            this.TpRelatorios.Size = new System.Drawing.Size(1020, 568);
            this.TpRelatorios.TabIndex = 5;
            this.TpRelatorios.Text = "Relátorios";
            this.TpRelatorios.VerticalScrollbarBarColor = true;
            this.TpRelatorios.VerticalScrollbarHighlightOnWheel = false;
            this.TpRelatorios.VerticalScrollbarSize = 10;
            // 
            // TpSeusDados
            // 
            this.TpSeusDados.HorizontalScrollbarBarColor = true;
            this.TpSeusDados.HorizontalScrollbarHighlightOnWheel = false;
            this.TpSeusDados.HorizontalScrollbarSize = 10;
            this.TpSeusDados.Location = new System.Drawing.Point(4, 38);
            this.TpSeusDados.Name = "TpSeusDados";
            this.TpSeusDados.Size = new System.Drawing.Size(1020, 568);
            this.TpSeusDados.TabIndex = 6;
            this.TpSeusDados.Text = "Seus Dados";
            this.TpSeusDados.VerticalScrollbarBarColor = true;
            this.TpSeusDados.VerticalScrollbarHighlightOnWheel = false;
            this.TpSeusDados.VerticalScrollbarSize = 10;
            // 
            // leonardo_TesteDataSet
            // 
            this.leonardo_TesteDataSet.DataSetName = "Leonardo_TesteDataSet";
            this.leonardo_TesteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leonardoTesteDataSetBindingSource
            // 
            this.leonardoTesteDataSetBindingSource.DataSource = this.leonardo_TesteDataSet;
            this.leonardoTesteDataSetBindingSource.Position = 0;
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AutoGenerateColumns = false;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.descriçãoprodutoDataGridViewTextBoxColumn,
            this.tipounidadeDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.dataGridProduct.DataSource = this.productsBindingSource;
            this.dataGridProduct.Location = new System.Drawing.Point(20, 74);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridProduct.Size = new System.Drawing.Size(962, 386);
            this.dataGridProduct.TabIndex = 2;
            this.dataGridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // leonardoTesteDataSetBindingSource1
            // 
            this.leonardoTesteDataSetBindingSource1.DataSource = this.leonardo_TesteDataSet;
            this.leonardoTesteDataSetBindingSource1.Position = 0;
            // 
            // leonardo_TesteDataSet1
            // 
            this.leonardo_TesteDataSet1.DataSetName = "Leonardo_TesteDataSet1";
            this.leonardo_TesteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.leonardo_TesteDataSet1;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 117;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "Nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            this.nomeprodutoDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriçãoprodutoDataGridViewTextBoxColumn
            // 
            this.descriçãoprodutoDataGridViewTextBoxColumn.DataPropertyName = "Descrição_produto";
            this.descriçãoprodutoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriçãoprodutoDataGridViewTextBoxColumn.Name = "descriçãoprodutoDataGridViewTextBoxColumn";
            this.descriçãoprodutoDataGridViewTextBoxColumn.Width = 200;
            // 
            // tipounidadeDataGridViewTextBoxColumn
            // 
            this.tipounidadeDataGridViewTextBoxColumn.DataPropertyName = "Tipo_unidade";
            this.tipounidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.tipounidadeDataGridViewTextBoxColumn.Name = "tipounidadeDataGridViewTextBoxColumn";
            this.tipounidadeDataGridViewTextBoxColumn.Width = 200;
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            this.isActiveDataGridViewTextBoxColumn.DataPropertyName = "Active";
            this.isActiveDataGridViewTextBoxColumn.HeaderText = "Active";
            this.isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
            this.isActiveDataGridViewTextBoxColumn.Width = 200;
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 795);
            this.Controls.Add(this.TabControlProjeto);
            this.KeyPreview = true;
            this.Name = "MainDialog";
            this.Text = "Projeto Zica";
            this.Load += new System.EventHandler(this.MainDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManterCliente_KeyDown);
            this.TabControlProjeto.ResumeLayout(false);
            this.TpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leonardo_TesteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leonardoTesteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leonardoTesteDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leonardo_TesteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControlProjeto;
        private MetroFramework.Controls.MetroTabPage TpDashBoard;
        private MetroFramework.Controls.MetroTabPage TpFornecedores;
        private MetroFramework.Controls.MetroTabPage TpNotasFiscal;
        private MetroFramework.Controls.MetroTabPage TpProdutos;
        private MetroFramework.Controls.MetroTabPage TpUsuarios;
        private MetroFramework.Controls.MetroTabPage TpRelatorios;
        private MetroFramework.Controls.MetroTabPage TpSeusDados;
        private System.Windows.Forms.BindingSource leonardoTesteDataSetBindingSource;
        private Leonardo_TesteDataSet leonardo_TesteDataSet;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.BindingSource leonardoTesteDataSetBindingSource1;
        private Leonardo_TesteDataSet1 leonardo_TesteDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Leonardo_TesteDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipounidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
    }
}