namespace Random_Number_Generator
{
    partial class Form1
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
            this.generateButton = new System.Windows.Forms.Button();
            this.numberOneTbox = new System.Windows.Forms.TextBox();
            this.numberTwoTbox = new System.Windows.Forms.TextBox();
            this.numberOneLabel = new System.Windows.Forms.Label();
            this.numberTwoLabel = new System.Windows.Forms.Label();
            this.generateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(123, 99);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(82, 36);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate Number";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // numberOneTbox
            // 
            this.numberOneTbox.Location = new System.Drawing.Point(52, 58);
            this.numberOneTbox.Name = "numberOneTbox";
            this.numberOneTbox.Size = new System.Drawing.Size(100, 20);
            this.numberOneTbox.TabIndex = 1;
            // 
            // numberTwoTbox
            // 
            this.numberTwoTbox.Location = new System.Drawing.Point(174, 58);
            this.numberTwoTbox.Name = "numberTwoTbox";
            this.numberTwoTbox.Size = new System.Drawing.Size(100, 20);
            this.numberTwoTbox.TabIndex = 2;
            // 
            // numberOneLabel
            // 
            this.numberOneLabel.AutoSize = true;
            this.numberOneLabel.Location = new System.Drawing.Point(52, 39);
            this.numberOneLabel.Name = "numberOneLabel";
            this.numberOneLabel.Size = new System.Drawing.Size(53, 13);
            this.numberOneLabel.TabIndex = 3;
            this.numberOneLabel.Text = "Number 1";
            // 
            // numberTwoLabel
            // 
            this.numberTwoLabel.AutoSize = true;
            this.numberTwoLabel.Location = new System.Drawing.Point(174, 39);
            this.numberTwoLabel.Name = "numberTwoLabel";
            this.numberTwoLabel.Size = new System.Drawing.Size(53, 13);
            this.numberTwoLabel.TabIndex = 4;
            this.numberTwoLabel.Text = "Number 2";
            // 
            // generateLabel
            // 
            this.generateLabel.AutoSize = true;
            this.generateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateLabel.Location = new System.Drawing.Point(36, 9);
            this.generateLabel.Name = "generateLabel";
            this.generateLabel.Size = new System.Drawing.Size(254, 25);
            this.generateLabel.TabIndex = 5;
            this.generateLabel.Text = "Generate Number Between:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 147);
            this.Controls.Add(this.generateLabel);
            this.Controls.Add(this.numberTwoLabel);
            this.Controls.Add(this.numberOneLabel);
            this.Controls.Add(this.numberTwoTbox);
            this.Controls.Add(this.numberOneTbox);
            this.Controls.Add(this.generateButton);
            this.Name = "Form1";
            this.Text = "Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox numberOneTbox;
        private System.Windows.Forms.TextBox numberTwoTbox;
        private System.Windows.Forms.Label numberOneLabel;
        private System.Windows.Forms.Label numberTwoLabel;
        private System.Windows.Forms.Label generateLabel;
    }
}

