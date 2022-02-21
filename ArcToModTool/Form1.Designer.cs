
namespace ArcOutfitExtractorTool
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.DirectoryConvertButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxKs = new System.Windows.Forms.CheckBox();
            this.checkBoxNeiToCsv = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertButton.AutoSize = true;
            this.ConvertButton.Location = new System.Drawing.Point(242, 3);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(233, 30);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Extract From Selection of Arcs";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_click);
            // 
            // DirectoryConvertButton
            // 
            this.DirectoryConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryConvertButton.AutoSize = true;
            this.DirectoryConvertButton.Location = new System.Drawing.Point(3, 3);
            this.DirectoryConvertButton.Name = "DirectoryConvertButton";
            this.DirectoryConvertButton.Size = new System.Drawing.Size(233, 30);
            this.DirectoryConvertButton.TabIndex = 1;
            this.DirectoryConvertButton.Text = "Extract From Arcs In Directory";
            this.DirectoryConvertButton.UseVisualStyleBackColor = true;
            this.DirectoryConvertButton.Click += new System.EventHandler(this.DirectoryConvertButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(483, 439);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "drag and drop";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.DirectoryConvertButton);
            this.flowLayoutPanel1.Controls.Add(this.ConvertButton);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxKs);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxNeiToCsv);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(483, 61);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBoxKs.AutoSize = true;
            this.checkBoxKs.Checked = true;
            this.checkBoxKs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxKs.Location = new System.Drawing.Point(3, 39);
            this.checkBoxKs.Name = "checkBox1";
            this.checkBoxKs.Size = new System.Drawing.Size(148, 19);
            this.checkBoxKs.TabIndex = 2;
            this.checkBoxKs.Text = "*.ks file shift jis to utf8";
            this.checkBoxKs.UseVisualStyleBackColor = true;
            // 
            // checkBoxNeiToCsv
            // 
            this.checkBoxNeiToCsv.AutoSize = true;
            this.checkBoxNeiToCsv.Checked = true;
            this.checkBoxNeiToCsv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNeiToCsv.Location = new System.Drawing.Point(157, 39);
            this.checkBoxNeiToCsv.Name = "checkBoxNeiToCsv";
            this.checkBoxNeiToCsv.Size = new System.Drawing.Size(86, 19);
            this.checkBoxNeiToCsv.TabIndex = 3;
            this.checkBoxNeiToCsv.Text = "*.nei to csv";
            this.checkBoxNeiToCsv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 500);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Arc To Mod Tool";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ConvertButton;
		private System.Windows.Forms.Button DirectoryConvertButton;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.CheckBox checkBoxKs;
        internal System.Windows.Forms.CheckBox checkBoxNeiToCsv;
    }
}

