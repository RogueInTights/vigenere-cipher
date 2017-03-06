namespace Vigenere_cipher
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.keyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(13, 13);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(34, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(16, 30);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(200, 50);
            this.inputTextBox.TabIndex = 1;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(16, 105);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(200, 50);
            this.outputTextBox.TabIndex = 3;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(13, 88);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(42, 13);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Output:";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(16, 172);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(28, 13);
            this.keyLabel.TabIndex = 4;
            this.keyLabel.Text = "Key:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(50, 169);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(166, 20);
            this.keyTextBox.TabIndex = 5;
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(60, 212);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(75, 23);
            this.encodeButton.TabIndex = 6;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // keyButton
            // 
            this.keyButton.Location = new System.Drawing.Point(141, 212);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(75, 23);
            this.keyButton.TabIndex = 7;
            this.keyButton.Text = "Find key";
            this.keyButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 247);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputLabel);
            this.Name = "Form1";
            this.Text = "Vigenere cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button keyButton;
    }
}

