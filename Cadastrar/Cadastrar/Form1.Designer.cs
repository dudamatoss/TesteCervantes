namespace Cadastrar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            buttonSalvar = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            textBoxTexto = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            textBoxNumeros = new TextBox();
            labelPrincipal = new Label();
            dataGridViewCadastros = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastros).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4753952F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5246048F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewCadastros, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 8);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1077, 503);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 4);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Controls.Add(labelPrincipal, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35.9447021F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 64.0553F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            tableLayoutPanel2.Size = new Size(473, 497);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.0322571F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.9677429F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel3.Controls.Add(buttonEditar, 1, 0);
            tableLayoutPanel3.Controls.Add(buttonExcluir, 2, 0);
            tableLayoutPanel3.Controls.Add(buttonSalvar, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 391);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(467, 103);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditar.BackColor = Color.Silver;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Location = new Point(155, 3);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(152, 97);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar ";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Salmon;
            buttonExcluir.Dock = DockStyle.Fill;
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Location = new Point(313, 3);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(151, 97);
            buttonExcluir.TabIndex = 2;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSalvar.BackColor = Color.LightGreen;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Location = new Point(3, 3);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(146, 97);
            buttonSalvar.TabIndex = 0;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(textBoxTexto, 0, 1);
            tableLayoutPanel4.Location = new Point(3, 66);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 34.25926F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 65.74074F));
            tableLayoutPanel4.Size = new Size(467, 108);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(221, 23);
            label1.TabIndex = 0;
            label1.Text = "Preencha com um Texto";
            // 
            // textBoxTexto
            // 
            textBoxTexto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxTexto.Location = new Point(3, 57);
            textBoxTexto.Name = "textBoxTexto";
            textBoxTexto.Size = new Size(461, 30);
            textBoxTexto.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(textBoxNumeros, 0, 1);
            tableLayoutPanel5.Location = new Point(3, 180);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 31.5789471F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 68.42105F));
            tableLayoutPanel5.Size = new Size(467, 114);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(221, 23);
            label2.TabIndex = 0;
            label2.Text = "Preencha com Números";
            // 
            // textBoxNumeros
            // 
            textBoxNumeros.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxNumeros.Location = new Point(3, 60);
            textBoxNumeros.Name = "textBoxNumeros";
            textBoxNumeros.Size = new Size(461, 30);
            textBoxNumeros.TabIndex = 1;
            textBoxNumeros.KeyPress += textBoxNumero_KeyPress;
            // 
            // labelPrincipal
            // 
            labelPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPrincipal.AutoSize = true;
            labelPrincipal.ForeColor = Color.White;
            labelPrincipal.Location = new Point(3, 20);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(467, 23);
            labelPrincipal.TabIndex = 3;
            labelPrincipal.Text = "Preencha o Formulário";
            labelPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCadastros
            // 
            dataGridViewCadastros.AllowDrop = true;
            dataGridViewCadastros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCadastros.BackgroundColor = Color.White;
            dataGridViewCadastros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCadastros.Location = new Point(482, 3);
            dataGridViewCadastros.Name = "dataGridViewCadastros";
            dataGridViewCadastros.RowHeadersWidth = 51;
            dataGridViewCadastros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCadastros.Size = new Size(592, 497);
            dataGridViewCadastros.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1100, 518);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            ShowIcon = false;
            Text = "Tela de Cadastro";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonExcluir;
        private Button buttonEditar;
        private Button buttonSalvar;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label labelPrincipal;
        private Label label1;
        private TextBox textBoxTexto;
        private Label label2;
        private TextBox textBoxNumeros;
        private DataGridView dataGridViewCadastros;
    }
}
