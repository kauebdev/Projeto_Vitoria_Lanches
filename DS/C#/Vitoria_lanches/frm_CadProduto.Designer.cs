using System.Windows.Forms;

namespace Vitoria_lanches
{
    partial class frm_CadProduto
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
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadProduto));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnExt = new System.Windows.Forms.Button();
            this.btnAtt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTipo = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxDesc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecUn = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnExc);
            this.panel3.Controls.Add(this.btnCad);
            this.panel3.Controls.Add(this.btnExt);
            this.panel3.Controls.Add(this.btnAtt);
            this.panel3.Location = new System.Drawing.Point(0, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 57);
            this.panel3.TabIndex = 19;
            // 
            // btnExc
            // 
            this.btnExc.BackColor = System.Drawing.Color.Transparent;
            this.btnExc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExc.BackgroundImage")));
            this.btnExc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExc.Location = new System.Drawing.Point(298, 0);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(116, 47);
            this.btnExc.TabIndex = 11;
            this.btnExc.Text = "Excluir";
            this.btnExc.UseVisualStyleBackColor = false;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.Transparent;
            this.btnCad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCad.BackgroundImage")));
            this.btnCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.Location = new System.Drawing.Point(176, 0);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(116, 47);
            this.btnCad.TabIndex = 13;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnExt
            // 
            this.btnExt.BackColor = System.Drawing.Color.Transparent;
            this.btnExt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExt.BackgroundImage")));
            this.btnExt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExt.Location = new System.Drawing.Point(542, 0);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(116, 47);
            this.btnExt.TabIndex = 10;
            this.btnExt.Text = "Sair";
            this.btnExt.UseVisualStyleBackColor = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // btnAtt
            // 
            this.btnAtt.BackColor = System.Drawing.Color.Transparent;
            this.btnAtt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtt.BackgroundImage")));
            this.btnAtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtt.Location = new System.Drawing.Point(420, 0);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(116, 47);
            this.btnAtt.TabIndex = 12;
            this.btnAtt.Text = "Atualizar";
            this.btnAtt.UseVisualStyleBackColor = false;
            this.btnAtt.Click += new System.EventHandler(this.btnAtt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 59);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(611, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 56);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "CADASTRO DE PRODUTO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnTipo);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rtxDesc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPrecUn);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtCod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 400);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "R$";
            // 
            // btnTipo
            // 
            this.btnTipo.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTipo.BackgroundImage")));
            this.btnTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipo.Location = new System.Drawing.Point(298, 60);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.Size = new System.Drawing.Size(70, 21);
            this.btnTipo.TabIndex = 14;
            this.btnTipo.Text = "NOVO";
            this.btnTipo.UseVisualStyleBackColor = false;
            this.btnTipo.Click += new System.EventHandler(this.btnTipo_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "CATEGORIA"});
            this.cmbTipo.Location = new System.Drawing.Point(128, 60);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(164, 21);
            this.cmbTipo.TabIndex = 16;
            this.cmbTipo.DropDown += new System.EventHandler(this.cmbTipo_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tipo de produto:";
            // 
            // rtxDesc
            // 
            this.rtxDesc.Location = new System.Drawing.Point(128, 178);
            this.rtxDesc.Name = "rtxDesc";
            this.rtxDesc.Size = new System.Drawing.Size(447, 111);
            this.rtxDesc.TabIndex = 14;
            this.rtxDesc.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descrição: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Preço unitário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nome:";
            // 
            // txtPrecUn
            // 
            this.txtPrecUn.Location = new System.Drawing.Point(152, 131);
            this.txtPrecUn.Name = "txtPrecUn";
            this.txtPrecUn.Size = new System.Drawing.Size(67, 20);
            this.txtPrecUn.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(128, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(439, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(128, 25);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(91, 20);
            this.txtCod.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código: ";
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(20, 440);
            this.dgvProd.MultiSelect = false;
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.Size = new System.Drawing.Size(636, 119);
            this.dgvProd.TabIndex = 20;
            this.dgvProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellClick_1);
            // 
            // frm_CadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(668, 562);
            this.ControlBox = false;
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(684, 601);
            this.MinimumSize = new System.Drawing.Size(684, 601);
            this.Name = "frm_CadProduto";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.frm_CadProduto_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecUn;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.DataGridView dgvProd;
    }
}