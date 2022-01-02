
namespace G_Code_Lathe_Facing
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
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.odLabel = new System.Windows.Forms.Label();
            this.odTextbox = new System.Windows.Forms.TextBox();
            this.DialogBox = new System.Windows.Forms.TextBox();
            this.generateGCodeButton = new System.Windows.Forms.Button();
            this.toolNumTextbox = new System.Windows.Forms.TextBox();
            this.toolNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(326, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(301, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // odLabel
            // 
            this.odLabel.AutoSize = true;
            this.odLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odLabel.Location = new System.Drawing.Point(10, 50);
            this.odLabel.Name = "odLabel";
            this.odLabel.Size = new System.Drawing.Size(84, 20);
            this.odLabel.TabIndex = 2;
            this.odLabel.Text = "Enter O.D.";
            // 
            // odTextbox
            // 
            this.odTextbox.Location = new System.Drawing.Point(13, 70);
            this.odTextbox.Name = "odTextbox";
            this.odTextbox.Size = new System.Drawing.Size(100, 20);
            this.odTextbox.TabIndex = 3;
            // 
            // DialogBox
            // 
            this.DialogBox.Location = new System.Drawing.Point(13, 113);
            this.DialogBox.Multiline = true;
            this.DialogBox.Name = "DialogBox";
            this.DialogBox.Size = new System.Drawing.Size(325, 200);
            this.DialogBox.TabIndex = 4;
            // 
            // generateGCodeButton
            // 
            this.generateGCodeButton.Location = new System.Drawing.Point(263, 68);
            this.generateGCodeButton.Name = "generateGCodeButton";
            this.generateGCodeButton.Size = new System.Drawing.Size(75, 23);
            this.generateGCodeButton.TabIndex = 5;
            this.generateGCodeButton.Text = "Generate";
            this.generateGCodeButton.UseVisualStyleBackColor = true;
            this.generateGCodeButton.Click += new System.EventHandler(this.generateGCodeButton_Click);
            // 
            // toolNumTextbox
            // 
            this.toolNumTextbox.Location = new System.Drawing.Point(135, 70);
            this.toolNumTextbox.Name = "toolNumTextbox";
            this.toolNumTextbox.Size = new System.Drawing.Size(56, 20);
            this.toolNumTextbox.TabIndex = 7;
            // 
            // toolNumberLabel
            // 
            this.toolNumberLabel.AutoSize = true;
            this.toolNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolNumberLabel.Location = new System.Drawing.Point(133, 50);
            this.toolNumberLabel.Name = "toolNumberLabel";
            this.toolNumberLabel.Size = new System.Drawing.Size(52, 20);
            this.toolNumberLabel.TabIndex = 6;
            this.toolNumberLabel.Text = "Tool #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lathe Facing G-Code Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolNumTextbox);
            this.Controls.Add(this.toolNumberLabel);
            this.Controls.Add(this.generateGCodeButton);
            this.Controls.Add(this.DialogBox);
            this.Controls.Add(this.odTextbox);
            this.Controls.Add(this.odLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label odLabel;
        private System.Windows.Forms.TextBox odTextbox;
        private System.Windows.Forms.TextBox DialogBox;
        private System.Windows.Forms.Button generateGCodeButton;
        private System.Windows.Forms.TextBox toolNumTextbox;
        private System.Windows.Forms.Label toolNumberLabel;
        private System.Windows.Forms.Label label1;
    }
}

