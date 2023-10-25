namespace PrimeiroProjetoC_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_salvar = new System.Windows.Forms.ToolStripButton();
            this.tsb_atualizar = new System.Windows.Forms.ToolStripButton();
            this.tsb_buscar = new System.Windows.Forms.ToolStripButton();
            this.tsb_apagar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(12, 54);
            this.txt_CPF.Mask = "000,000,000-00";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(104, 20);
            this.txt_CPF.TabIndex = 0;
            this.txt_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CPF.Leave += new System.EventHandler(this.txt_CPF_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF DO CLIENTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME DO CLIENTE";
            // 
            // txt_nome
            // 
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.Location = new System.Drawing.Point(12, 104);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(420, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_salvar,
            this.tsb_atualizar,
            this.tsb_buscar,
            this.tsb_apagar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(447, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_salvar
            // 
            this.tsb_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_salvar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_salvar.Image")));
            this.tsb_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_salvar.Name = "tsb_salvar";
            this.tsb_salvar.Size = new System.Drawing.Size(23, 22);
            this.tsb_salvar.Text = "toolStripButton1";
            this.tsb_salvar.ToolTipText = "SALVAR";
            this.tsb_salvar.Click += new System.EventHandler(this.tsb_salvar_Click_1);
            // 
            // tsb_atualizar
            // 
            this.tsb_atualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_atualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_atualizar.Image")));
            this.tsb_atualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_atualizar.Name = "tsb_atualizar";
            this.tsb_atualizar.Size = new System.Drawing.Size(23, 22);
            this.tsb_atualizar.Text = "toolStripButton2";
            this.tsb_atualizar.ToolTipText = "ATUALIZAR";
            // 
            // tsb_buscar
            // 
            this.tsb_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_buscar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_buscar.Image")));
            this.tsb_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_buscar.Name = "tsb_buscar";
            this.tsb_buscar.Size = new System.Drawing.Size(23, 22);
            this.tsb_buscar.Text = "toolStripButton3";
            this.tsb_buscar.ToolTipText = "BUSCAR";
            // 
            // tsb_apagar
            // 
            this.tsb_apagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_apagar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_apagar.Image")));
            this.tsb_apagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_apagar.Name = "tsb_apagar";
            this.tsb_apagar.Size = new System.Drawing.Size(23, 22);
            this.tsb_apagar.Text = "toolStripButton4";
            this.tsb_apagar.ToolTipText = "APAGAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 558);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_CPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_salvar;
        private System.Windows.Forms.ToolStripButton tsb_atualizar;
        private System.Windows.Forms.ToolStripButton tsb_buscar;
        private System.Windows.Forms.ToolStripButton tsb_apagar;
    }
}

