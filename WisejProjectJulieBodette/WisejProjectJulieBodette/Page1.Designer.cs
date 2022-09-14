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
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.dataGridView3 = new Wisej.Web.DataGridView();
            this.button1 = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.dataGridView1.Controls.Add(this.dataGridView2);
            this.dataGridView1.Location = new System.Drawing.Point(386, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 411);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Dock = Wisej.Web.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(519, 100);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Location = new System.Drawing.Point(1093, 448);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(200, 100);
            this.dataGridView3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(975, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "create database";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.typedTextBox2);
            this.Controls.Add(this.typedTextBox1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1339, 548);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataGridView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TypedTextBox typedTextBox1;
        private Wisej.Web.TypedTextBox typedTextBox2;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridView dataGridView2;
        private Wisej.Web.DataGridView dataGridView3;
        private Wisej.Web.Button button1;
    }
}

