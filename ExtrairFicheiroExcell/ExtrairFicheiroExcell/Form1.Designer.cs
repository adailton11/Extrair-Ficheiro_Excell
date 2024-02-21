namespace ExtrairFicheiroExcell
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
            btnBuscarExcell = new Button();
            txtCaminhoExcell = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarExcell
            // 
            btnBuscarExcell.Location = new Point(19, 12);
            btnBuscarExcell.Name = "btnBuscarExcell";
            btnBuscarExcell.Size = new Size(116, 29);
            btnBuscarExcell.TabIndex = 0;
            btnBuscarExcell.Text = "Buscar Excell";
            btnBuscarExcell.UseVisualStyleBackColor = true;
            btnBuscarExcell.Click += btnBuscarExcell_Click;
            // 
            // txtCaminhoExcell
            // 
            txtCaminhoExcell.Enabled = false;
            txtCaminhoExcell.Location = new Point(147, 12);
            txtCaminhoExcell.Name = "txtCaminhoExcell";
            txtCaminhoExcell.Size = new Size(435, 27);
            txtCaminhoExcell.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(556, 206);
            dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 272);
            Controls.Add(dataGridView1);
            Controls.Add(txtCaminhoExcell);
            Controls.Add(btnBuscarExcell);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarExcell;
        private TextBox txtCaminhoExcell;
        private DataGridView dataGridView1;
    }
}
