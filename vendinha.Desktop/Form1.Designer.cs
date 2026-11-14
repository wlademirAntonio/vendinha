using vendinha.Desktop.Components;

namespace vendinha.Desktop
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
            button1 = new PrimaryButton();
            primaryButton1 = new PrimaryButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(280, 218);
            button1.Name = "button1";
            button1.Size = new Size(220, 60);
            button1.TabIndex = 0;
            button1.Text = "Gerenciar Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // primaryButton1
            // 
            primaryButton1.BackColor = Color.Orange;
            primaryButton1.FlatStyle = FlatStyle.Flat;
            primaryButton1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            primaryButton1.ForeColor = Color.White;
            primaryButton1.Location = new Point(280, 295);
            primaryButton1.Name = "primaryButton1";
            primaryButton1.Size = new Size(220, 60);
            primaryButton1.TabIndex = 1;
            primaryButton1.Text = "Gerenciar Dividas";
            primaryButton1.UseVisualStyleBackColor = true;
            primaryButton1.Click += primaryButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(primaryButton1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private PrimaryButton button1;
        private PrimaryButton primaryButton1;
    }
}
