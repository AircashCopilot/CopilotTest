namespace CopilotTest
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
            textBoxMessage = new TextBox();
            buttonShowMessage = new Button();
            SuspendLayout();
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(16, 43);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(755, 59);
            textBoxMessage.TabIndex = 0;
            // 
            // buttonShowMessage
            // 
            buttonShowMessage.BackColor = Color.FromArgb(128, 255, 128);
            buttonShowMessage.Location = new Point(16, 124);
            buttonShowMessage.Name = "buttonShowMessage";
            buttonShowMessage.Size = new Size(755, 279);
            buttonShowMessage.TabIndex = 1;
            buttonShowMessage.Text = "RESOLVE";
            buttonShowMessage.UseVisualStyleBackColor = false;
            buttonShowMessage.Click += buttonShowMessage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowMessage);
            Controls.Add(textBoxMessage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMessage;
        private Button buttonShowMessage;
    }
}
