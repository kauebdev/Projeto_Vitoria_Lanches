namespace Vitoria_lanches
{
    partial class frm_index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_index));
            this.btnCadProd = new System.Windows.Forms.Button();
            this.btnRel = new System.Windows.Forms.Button();
            this.btnCadCli = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnExt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadProd
            // 
            this.btnCadProd.BackColor = System.Drawing.Color.Transparent;
            this.btnCadProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadProd.BackgroundImage")));
            this.btnCadProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadProd.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProd.Location = new System.Drawing.Point(84, 164);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(246, 66);
            this.btnCadProd.TabIndex = 0;
            this.btnCadProd.Text = "CADASTRAR PRODUTOS";
            this.btnCadProd.UseVisualStyleBackColor = false;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click);
            // 
            // btnRel
            // 
            this.btnRel.BackColor = System.Drawing.Color.Transparent;
            this.btnRel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRel.BackgroundImage")));
            this.btnRel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRel.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRel.Location = new System.Drawing.Point(348, 164);
            this.btnRel.Name = "btnRel";
            this.btnRel.Size = new System.Drawing.Size(246, 66);
            this.btnRel.TabIndex = 2;
            this.btnRel.Text = "RELATÓRIOS";
            this.btnRel.UseVisualStyleBackColor = false;
            // 
            // btnCadCli
            // 
            this.btnCadCli.BackColor = System.Drawing.Color.Transparent;
            this.btnCadCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadCli.BackgroundImage")));
            this.btnCadCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadCli.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCli.Location = new System.Drawing.Point(84, 250);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(246, 66);
            this.btnCadCli.TabIndex = 3;
            this.btnCadCli.Text = "CADASTRAR CLIENTES";
            this.btnCadCli.UseVisualStyleBackColor = false;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPedidos.BackgroundImage")));
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.Font = new System.Drawing.Font("Elephant", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(84, 35);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(510, 109);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "PEDIDOS";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnExt
            // 
            this.btnExt.BackColor = System.Drawing.Color.Transparent;
            this.btnExt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExt.BackgroundImage")));
            this.btnExt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExt.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExt.Location = new System.Drawing.Point(348, 250);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(246, 66);
            this.btnExt.TabIndex = 5;
            this.btnExt.Text = "SAIR";
            this.btnExt.UseVisualStyleBackColor = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExt);
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Controls.Add(this.btnCadCli);
            this.panel1.Controls.Add(this.btnRel);
            this.panel1.Controls.Add(this.btnCadProd);
            this.panel1.Location = new System.Drawing.Point(1, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 366);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 49);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "version 2.3";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 133);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(255, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(669, 564);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(685, 603);
            this.MinimumSize = new System.Drawing.Size(685, 603);
            this.Name = "frm_index";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.Button btnRel;
        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

