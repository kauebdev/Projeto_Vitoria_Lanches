namespace Vitoria_lanches
{
    partial class frm_pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pedidos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAcomPed = new System.Windows.Forms.Button();
            this.btn_CadPed = new System.Windows.Forms.Button();
            this.btnExt = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 59);
            this.panel2.TabIndex = 19;
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
            this.label2.Font = new System.Drawing.Font("Elephant", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "MENU DE PEDIDOS";
            // 
            // btnAcomPed
            // 
            this.btnAcomPed.BackColor = System.Drawing.Color.Transparent;
            this.btnAcomPed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcomPed.BackgroundImage")));
            this.btnAcomPed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcomPed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcomPed.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcomPed.Location = new System.Drawing.Point(337, 157);
            this.btnAcomPed.Name = "btnAcomPed";
            this.btnAcomPed.Size = new System.Drawing.Size(246, 66);
            this.btnAcomPed.TabIndex = 20;
            this.btnAcomPed.Text = "CADASTRAR PEDIDO";
            this.btnAcomPed.UseVisualStyleBackColor = false;
            this.btnAcomPed.Click += new System.EventHandler(this.btnAcomPed_Click);
            // 
            // btn_CadPed
            // 
            this.btn_CadPed.BackColor = System.Drawing.Color.Transparent;
            this.btn_CadPed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CadPed.BackgroundImage")));
            this.btn_CadPed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CadPed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CadPed.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadPed.Location = new System.Drawing.Point(85, 157);
            this.btn_CadPed.Name = "btn_CadPed";
            this.btn_CadPed.Size = new System.Drawing.Size(246, 66);
            this.btn_CadPed.TabIndex = 21;
            this.btn_CadPed.Text = "ACOMPANHAR PEDIDO";
            this.btn_CadPed.UseVisualStyleBackColor = false;
            this.btn_CadPed.Click += new System.EventHandler(this.btn_CadPed_Click);
            // 
            // btnExt
            // 
            this.btnExt.BackColor = System.Drawing.Color.Transparent;
            this.btnExt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExt.BackgroundImage")));
            this.btnExt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExt.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExt.Location = new System.Drawing.Point(207, 251);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(246, 66);
            this.btnExt.TabIndex = 22;
            this.btnExt.Text = "SAIR";
            this.btnExt.UseVisualStyleBackColor = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // frm_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(669, 403);
            this.ControlBox = false;
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.btn_CadPed);
            this.Controls.Add(this.btnAcomPed);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(685, 603);
            this.Name = "frm_pedidos";
            this.Text = "  ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAcomPed;
        private System.Windows.Forms.Button btn_CadPed;
        private System.Windows.Forms.Button btnExt;
    }
}