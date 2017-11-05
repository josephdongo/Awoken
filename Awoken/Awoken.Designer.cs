namespace Awoken
{
    partial class Awoken
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
            this.uxMoralLabel = new System.Windows.Forms.Label();
            this.uxMoralTotal = new System.Windows.Forms.TextBox();
            this.uxChoiceA = new System.Windows.Forms.Button();
            this.uxChoiceB = new System.Windows.Forms.Button();
            this.uxStart = new System.Windows.Forms.Button();
            this.uxStoryText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // uxMoralLabel
            // 
            this.uxMoralLabel.AutoSize = true;
            this.uxMoralLabel.Font = new System.Drawing.Font("GothicE", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMoralLabel.Location = new System.Drawing.Point(13, 13);
            this.uxMoralLabel.Name = "uxMoralLabel";
            this.uxMoralLabel.Size = new System.Drawing.Size(108, 19);
            this.uxMoralLabel.TabIndex = 0;
            this.uxMoralLabel.Text = "Moral Points:";
            // 
            // uxMoralTotal
            // 
            this.uxMoralTotal.BackColor = System.Drawing.Color.Black;
            this.uxMoralTotal.ForeColor = System.Drawing.Color.White;
            this.uxMoralTotal.Location = new System.Drawing.Point(128, 11);
            this.uxMoralTotal.Name = "uxMoralTotal";
            this.uxMoralTotal.ReadOnly = true;
            this.uxMoralTotal.Size = new System.Drawing.Size(57, 20);
            this.uxMoralTotal.TabIndex = 1;
            this.uxMoralTotal.TabStop = false;
            this.uxMoralTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxChoiceA
            // 
            this.uxChoiceA.BackColor = System.Drawing.SystemColors.Control;
            this.uxChoiceA.Font = new System.Drawing.Font("Monotxt_IV25", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxChoiceA.ForeColor = System.Drawing.Color.Black;
            this.uxChoiceA.Location = new System.Drawing.Point(13, 479);
            this.uxChoiceA.Name = "uxChoiceA";
            this.uxChoiceA.Size = new System.Drawing.Size(337, 73);
            this.uxChoiceA.TabIndex = 2;
            this.uxChoiceA.Text = "CHOICE A";
            this.uxChoiceA.UseVisualStyleBackColor = false;
            this.uxChoiceA.Click += new System.EventHandler(this.uxChoiceA_Click);
            // 
            // uxChoiceB
            // 
            this.uxChoiceB.Font = new System.Drawing.Font("Monotxt_IV25", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxChoiceB.ForeColor = System.Drawing.Color.Black;
            this.uxChoiceB.Location = new System.Drawing.Point(357, 479);
            this.uxChoiceB.Name = "uxChoiceB";
            this.uxChoiceB.Size = new System.Drawing.Size(337, 73);
            this.uxChoiceB.TabIndex = 3;
            this.uxChoiceB.Text = "CHOICE B";
            this.uxChoiceB.UseVisualStyleBackColor = true;
            this.uxChoiceB.Click += new System.EventHandler(this.button2_Click);
            // 
            // uxStart
            // 
            this.uxStart.BackColor = System.Drawing.SystemColors.Control;
            this.uxStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxStart.ForeColor = System.Drawing.Color.Black;
            this.uxStart.Location = new System.Drawing.Point(619, 11);
            this.uxStart.Name = "uxStart";
            this.uxStart.Size = new System.Drawing.Size(75, 23);
            this.uxStart.TabIndex = 4;
            this.uxStart.Text = "START";
            this.uxStart.UseVisualStyleBackColor = false;
            this.uxStart.Click += new System.EventHandler(this.uxStart_Click);
            // 
            // uxStoryText
            // 
            this.uxStoryText.BackColor = System.Drawing.Color.Black;
            this.uxStoryText.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStoryText.ForeColor = System.Drawing.Color.Lime;
            this.uxStoryText.Location = new System.Drawing.Point(13, 36);
            this.uxStoryText.Name = "uxStoryText";
            this.uxStoryText.ReadOnly = true;
            this.uxStoryText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.uxStoryText.Size = new System.Drawing.Size(681, 437);
            this.uxStoryText.TabIndex = 5;
            this.uxStoryText.Text = "";
            // 
            // Awoken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 564);
            this.Controls.Add(this.uxStoryText);
            this.Controls.Add(this.uxStart);
            this.Controls.Add(this.uxChoiceB);
            this.Controls.Add(this.uxChoiceA);
            this.Controls.Add(this.uxMoralTotal);
            this.Controls.Add(this.uxMoralLabel);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "Awoken";
            this.Text = "The Awoken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxMoralLabel;
        private System.Windows.Forms.TextBox uxMoralTotal;
        private System.Windows.Forms.Button uxChoiceA;
        private System.Windows.Forms.Button uxChoiceB;
        private System.Windows.Forms.Button uxStart;
        private System.Windows.Forms.RichTextBox uxStoryText;
    }
}

