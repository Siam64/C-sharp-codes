namespace VolumeConverter
{
    partial class volumeConverter
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
            this.convertClTitleLabel = new System.Windows.Forms.Label();
            this.clTextBox = new System.Windows.Forms.TextBox();
            this.literTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clLabel = new System.Windows.Forms.Label();
            this.literLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertClTitleLabel
            // 
            this.convertClTitleLabel.AutoSize = true;
            this.convertClTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertClTitleLabel.Location = new System.Drawing.Point(299, 29);
            this.convertClTitleLabel.Name = "convertClTitleLabel";
            this.convertClTitleLabel.Size = new System.Drawing.Size(309, 39);
            this.convertClTitleLabel.TabIndex = 0;
            this.convertClTitleLabel.Text = "Convert CL to liter";
            // 
            // clTextBox
            // 
            this.clTextBox.Location = new System.Drawing.Point(292, 128);
            this.clTextBox.Multiline = true;
            this.clTextBox.Name = "clTextBox";
            this.clTextBox.Size = new System.Drawing.Size(244, 48);
            this.clTextBox.TabIndex = 1;
            this.clTextBox.TextChanged += new System.EventHandler(this.clTextBox_TextChanged);
            // 
            // literTextBox
            // 
            this.literTextBox.Location = new System.Drawing.Point(292, 249);
            this.literTextBox.Multiline = true;
            this.literTextBox.Name = "literTextBox";
            this.literTextBox.Size = new System.Drawing.Size(244, 47);
            this.literTextBox.TabIndex = 2;
            this.literTextBox.TextChanged += new System.EventHandler(this.literTextBox_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertButton.Location = new System.Drawing.Point(292, 426);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(116, 49);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Location = new System.Drawing.Point(583, 426);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 49);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clLabel
            // 
            this.clLabel.AutoSize = true;
            this.clLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clLabel.Location = new System.Drawing.Point(599, 147);
            this.clLabel.Name = "clLabel";
            this.clLabel.Size = new System.Drawing.Size(47, 29);
            this.clLabel.TabIndex = 5;
            this.clLabel.Text = "CL";
            this.clLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // literLabel
            // 
            this.literLabel.AutoSize = true;
            this.literLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.literLabel.Location = new System.Drawing.Point(599, 267);
            this.literLabel.Name = "literLabel";
            this.literLabel.Size = new System.Drawing.Size(59, 29);
            this.literLabel.TabIndex = 6;
            this.literLabel.Text = "liter";
            this.literLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // volumeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(965, 536);
            this.Controls.Add(this.literLabel);
            this.Controls.Add(this.clLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.literTextBox);
            this.Controls.Add(this.clTextBox);
            this.Controls.Add(this.convertClTitleLabel);
            this.Name = "volumeConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label convertClTitleLabel;
        private System.Windows.Forms.TextBox clTextBox;
        private System.Windows.Forms.TextBox literTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label clLabel;
        private System.Windows.Forms.Label literLabel;
    }
}

