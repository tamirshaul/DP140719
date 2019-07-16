namespace Day3_Memento
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
            this.rText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rText
            // 
            this.rText.Location = new System.Drawing.Point(99, 35);
            this.rText.Name = "rText";
            this.rText.Size = new System.Drawing.Size(582, 252);
            this.rText.TabIndex = 0;
            this.rText.Text = "";
            this.rText.TextChanged += new System.EventHandler(this.rText_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Undo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // Redo
            // 
            this.Redo.Location = new System.Drawing.Point(510, 346);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(171, 58);
            this.Redo.TabIndex = 3;
            this.Redo.Text = "Redo";
            this.Redo.UseVisualStyleBackColor = true;
            this.Redo.Click += new System.EventHandler(this.RedoBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Redo;
    }
}

