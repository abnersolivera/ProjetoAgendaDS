
namespace ProjetoAgenda.Formulários
{
    partial class FrmCadPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadPessoas));
            System.Windows.Forms.Label id_pessoaLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label datanascimentoLabel;
            this.pessoa_dsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pessoa_dsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_pessoaTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.datanascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pessoa_dsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoa_dsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Agenda = new ProjetoAgenda.Dados.DataSet_Agenda();
            this.pessoa_dsTableAdapter = new ProjetoAgenda.Dados.DataSet_AgendaTableAdapters.pessoa_dsTableAdapter();
            this.tableAdapterManager = new ProjetoAgenda.Dados.DataSet_AgendaTableAdapters.TableAdapterManager();
            id_pessoaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            datanascimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsBindingNavigator)).BeginInit();
            this.pessoa_dsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // pessoa_dsBindingNavigator
            // 
            this.pessoa_dsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoa_dsBindingNavigator.BindingSource = this.pessoa_dsBindingSource;
            this.pessoa_dsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoa_dsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoa_dsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pessoa_dsBindingNavigatorSaveItem});
            this.pessoa_dsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoa_dsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoa_dsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoa_dsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoa_dsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoa_dsBindingNavigator.Name = "pessoa_dsBindingNavigator";
            this.pessoa_dsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoa_dsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.pessoa_dsBindingNavigator.TabIndex = 0;
            this.pessoa_dsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // pessoa_dsBindingNavigatorSaveItem
            // 
            this.pessoa_dsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoa_dsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoa_dsBindingNavigatorSaveItem.Image")));
            this.pessoa_dsBindingNavigatorSaveItem.Name = "pessoa_dsBindingNavigatorSaveItem";
            this.pessoa_dsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pessoa_dsBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pessoa_dsBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoa_dsBindingNavigatorSaveItem_Click);
            // 
            // id_pessoaLabel
            // 
            id_pessoaLabel.AutoSize = true;
            id_pessoaLabel.Location = new System.Drawing.Point(158, 84);
            id_pessoaLabel.Name = "id_pessoaLabel";
            id_pessoaLabel.Size = new System.Drawing.Size(21, 13);
            id_pessoaLabel.TabIndex = 1;
            id_pessoaLabel.Text = "ID:";
            // 
            // id_pessoaTextBox
            // 
            this.id_pessoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_dsBindingSource, "id_pessoa", true));
            this.id_pessoaTextBox.Location = new System.Drawing.Point(249, 81);
            this.id_pessoaTextBox.Name = "id_pessoaTextBox";
            this.id_pessoaTextBox.Size = new System.Drawing.Size(51, 20);
            this.id_pessoaTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(158, 110);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_dsBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(249, 107);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(158, 136);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 5;
            cidadeLabel.Text = "Cidade:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_dsBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(249, 133);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cidadeTextBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(158, 162);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(38, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "E-mail:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_dsBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(249, 159);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // datanascimentoLabel
            // 
            datanascimentoLabel.AutoSize = true;
            datanascimentoLabel.Location = new System.Drawing.Point(158, 189);
            datanascimentoLabel.Name = "datanascimentoLabel";
            datanascimentoLabel.Size = new System.Drawing.Size(92, 13);
            datanascimentoLabel.TabIndex = 9;
            datanascimentoLabel.Text = "Data Nascimento:";
            // 
            // datanascimentoDateTimePicker
            // 
            this.datanascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoa_dsBindingSource, "datanascimento", true));
            this.datanascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datanascimentoDateTimePicker.Location = new System.Drawing.Point(251, 185);
            this.datanascimentoDateTimePicker.Name = "datanascimentoDateTimePicker";
            this.datanascimentoDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.datanascimentoDateTimePicker.TabIndex = 10;
            // 
            // pessoa_dsDataGridView
            // 
            this.pessoa_dsDataGridView.AutoGenerateColumns = false;
            this.pessoa_dsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoa_dsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pessoa_dsDataGridView.DataSource = this.pessoa_dsBindingSource;
            this.pessoa_dsDataGridView.Location = new System.Drawing.Point(93, 279);
            this.pessoa_dsDataGridView.Name = "pessoa_dsDataGridView";
            this.pessoa_dsDataGridView.Size = new System.Drawing.Size(645, 220);
            this.pessoa_dsDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_pessoa";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "datanascimento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data Nascimento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // pessoa_dsBindingSource
            // 
            this.pessoa_dsBindingSource.DataMember = "pessoa_ds";
            this.pessoa_dsBindingSource.DataSource = this.dataSet_Agenda;
            // 
            // dataSet_Agenda
            // 
            this.dataSet_Agenda.DataSetName = "DataSet_Agenda";
            this.dataSet_Agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoa_dsTableAdapter
            // 
            this.pessoa_dsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pessoa_dsTableAdapter = this.pessoa_dsTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoAgenda.Dados.DataSet_AgendaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmCadPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.pessoa_dsDataGridView);
            this.Controls.Add(id_pessoaLabel);
            this.Controls.Add(this.id_pessoaTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(datanascimentoLabel);
            this.Controls.Add(this.datanascimentoDateTimePicker);
            this.Controls.Add(this.pessoa_dsBindingNavigator);
            this.Name = "FrmCadPessoas";
            this.Text = "FrmCadPessoas";
            this.Load += new System.EventHandler(this.FrmCadPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsBindingNavigator)).EndInit();
            this.pessoa_dsBindingNavigator.ResumeLayout(false);
            this.pessoa_dsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.DataSet_Agenda dataSet_Agenda;
        private System.Windows.Forms.BindingSource pessoa_dsBindingSource;
        private Dados.DataSet_AgendaTableAdapters.pessoa_dsTableAdapter pessoa_dsTableAdapter;
        private Dados.DataSet_AgendaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoa_dsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pessoa_dsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_pessoaTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker datanascimentoDateTimePicker;
        private System.Windows.Forms.DataGridView pessoa_dsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}