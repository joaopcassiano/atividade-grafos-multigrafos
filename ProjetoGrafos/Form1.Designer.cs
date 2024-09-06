namespace ProjetoGrafos
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
            this.label1 = new System.Windows.Forms.Label();
            this.numVertices = new System.Windows.Forms.NumericUpDown();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numVertices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Vértices: ";
            // 
            // numVertices
            // 
            this.numVertices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVertices.Location = new System.Drawing.Point(186, 40);
            this.numVertices.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVertices.Name = "numVertices";
            this.numVertices.Size = new System.Drawing.Size(173, 26);
            this.numVertices.TabIndex = 1;
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(378, 40);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(126, 20);
            this.btnMatriz.TabIndex = 2;
            this.btnMatriz.Text = "Matriz de adjacência";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.AllowUserToDeleteRows = false;
            this.dgvMatriz.AllowUserToOrderColumns = true;
            this.dgvMatriz.AllowUserToResizeColumns = false;
            this.dgvMatriz.AllowUserToResizeRows = false;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.ColumnHeadersVisible = false;
            this.dgvMatriz.Location = new System.Drawing.Point(23, 66);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersVisible = false;
            this.dgvMatriz.Size = new System.Drawing.Size(748, 311);
            this.dgvMatriz.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(63, 383);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(296, 33);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar a Matriz de Adjacência";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(63, 427);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(296, 33);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar Matriz de Adjacência";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(388, 383);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 472);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.numVertices);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ProjetoGrafos";
            ((System.ComponentModel.ISupportInitialize)(this.numVertices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numVertices;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblResultado;
    }
}

