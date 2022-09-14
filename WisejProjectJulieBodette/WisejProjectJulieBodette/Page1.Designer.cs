namespace WisejProjectJulieBodette
{
    partial class Page1
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typedTextBox1 = new Wisej.Web.TypedTextBox();
            this.typedTextBox2 = new Wisej.Web.TypedTextBox();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // typedTextBox1
            // 
            this.typedTextBox1.Location = new System.Drawing.Point(378, 38);
            this.typedTextBox1.Name = "typedTextBox1";
            this.typedTextBox1.Size = new System.Drawing.Size(242, 30);
            this.typedTextBox1.TabIndex = 0;
            this.typedTextBox1.ValueType = typeof(string);
            // 
            // typedTextBox2
            // 
            this.typedTextBox2.Location = new System.Drawing.Point(659, 35);
            this.typedTextBox2.Name = "typedTextBox2";
            this.typedTextBox2.Size = new System.Drawing.Size(249, 30);
            this.typedTextBox2.TabIndex = 1;
            this.typedTextBox2.ValueType = typeof(string);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(386, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 411);
            this.dataGridView1.TabIndex = 2;
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.typedTextBox2);
            this.Controls.Add(this.typedTextBox1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1298, 573);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TypedTextBox typedTextBox1;
        private Wisej.Web.TypedTextBox typedTextBox2;
        private Wisej.Web.DataGridView dataGridView1;
    }
}

