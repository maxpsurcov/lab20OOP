namespace lab20OOP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckLinesButton = new System.Windows.Forms.Button();
            this.Line1ABox = new System.Windows.Forms.TextBox();
            this.Line1BBox = new System.Windows.Forms.TextBox();
            this.Line1CBox = new System.Windows.Forms.TextBox();
            this.Line2ABox = new System.Windows.Forms.TextBox();
            this.Line2BBox = new System.Windows.Forms.TextBox();
            this.Line2CBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckLinesButton
            // 
            this.CheckLinesButton.Location = new System.Drawing.Point(89, 61);
            this.CheckLinesButton.Name = "CheckLinesButton";
            this.CheckLinesButton.Size = new System.Drawing.Size(264, 47);
            this.CheckLinesButton.TabIndex = 0;
            this.CheckLinesButton.Text = "CheckLinesButton";
            this.CheckLinesButton.UseVisualStyleBackColor = true;
            this.CheckLinesButton.Click += new System.EventHandler(this.CheckLinesButton_Click);
            // 
            // Line1ABox
            // 
            this.Line1ABox.Location = new System.Drawing.Point(89, 147);
            this.Line1ABox.Name = "Line1ABox";
            this.Line1ABox.Size = new System.Drawing.Size(137, 29);
            this.Line1ABox.TabIndex = 1;
            this.Line1ABox.Text = "A";
            // 
            // Line1BBox
            // 
            this.Line1BBox.Location = new System.Drawing.Point(89, 199);
            this.Line1BBox.Name = "Line1BBox";
            this.Line1BBox.Size = new System.Drawing.Size(137, 29);
            this.Line1BBox.TabIndex = 2;
            this.Line1BBox.Text = "B";
            // 
            // Line1CBox
            // 
            this.Line1CBox.Location = new System.Drawing.Point(89, 249);
            this.Line1CBox.Name = "Line1CBox";
            this.Line1CBox.Size = new System.Drawing.Size(137, 29);
            this.Line1CBox.TabIndex = 3;
            this.Line1CBox.Text = "C";
            // 
            // Line2ABox
            // 
            this.Line2ABox.Location = new System.Drawing.Point(311, 147);
            this.Line2ABox.Name = "Line2ABox";
            this.Line2ABox.Size = new System.Drawing.Size(137, 29);
            this.Line2ABox.TabIndex = 4;
            this.Line2ABox.Text = "A2";
            // 
            // Line2BBox
            // 
            this.Line2BBox.Location = new System.Drawing.Point(311, 199);
            this.Line2BBox.Name = "Line2BBox";
            this.Line2BBox.Size = new System.Drawing.Size(137, 29);
            this.Line2BBox.TabIndex = 5;
            this.Line2BBox.Text = "B2";
            // 
            // Line2CBox
            // 
            this.Line2CBox.Location = new System.Drawing.Point(311, 249);
            this.Line2CBox.Name = "Line2CBox";
            this.Line2CBox.Size = new System.Drawing.Size(137, 29);
            this.Line2CBox.TabIndex = 6;
            this.Line2CBox.Text = "C2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 618);
            this.Controls.Add(this.Line2CBox);
            this.Controls.Add(this.Line2BBox);
            this.Controls.Add(this.Line2ABox);
            this.Controls.Add(this.Line1CBox);
            this.Controls.Add(this.Line1BBox);
            this.Controls.Add(this.Line1ABox);
            this.Controls.Add(this.CheckLinesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckLinesButton;
        private System.Windows.Forms.TextBox Line1ABox;
        private System.Windows.Forms.TextBox Line1BBox;
        private System.Windows.Forms.TextBox Line1CBox;
        private System.Windows.Forms.TextBox Line2ABox;
        private System.Windows.Forms.TextBox Line2BBox;
        private System.Windows.Forms.TextBox Line2CBox;
    }
}

