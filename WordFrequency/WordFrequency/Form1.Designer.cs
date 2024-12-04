namespace WordFrequency
{
    partial class WordFrequency
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_FileName = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Display = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lstBox_Frequencies = new System.Windows.Forms.ListBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // txtBox_FileName
            // 
            this.txtBox_FileName.Location = new System.Drawing.Point(187, 71);
            this.txtBox_FileName.Name = "txtBox_FileName";
            this.txtBox_FileName.Size = new System.Drawing.Size(300, 31);
            this.txtBox_FileName.TabIndex = 1;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(559, 55);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(147, 63);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(41, 179);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(281, 85);
            this.btn_Display.TabIndex = 3;
            this.btn_Display.Text = "Display Frequencies";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(406, 179);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(281, 85);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save Frequencies";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lstBox_Frequencies
            // 
            this.lstBox_Frequencies.FormattingEnabled = true;
            this.lstBox_Frequencies.ItemHeight = 25;
            this.lstBox_Frequencies.Location = new System.Drawing.Point(41, 312);
            this.lstBox_Frequencies.Name = "lstBox_Frequencies";
            this.lstBox_Frequencies.Size = new System.Drawing.Size(646, 229);
            this.lstBox_Frequencies.TabIndex = 5;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(41, 594);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(226, 89);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // WordFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 742);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lstBox_Frequencies);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.txtBox_FileName);
            this.Controls.Add(this.label1);
            this.Name = "WordFrequency";
            this.Text = "Word Frequency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_FileName;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ListBox lstBox_Frequencies;
        private System.Windows.Forms.Button btn_Exit;
    }
}

