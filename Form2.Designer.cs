namespace Practice1
{
    partial class Form2
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
            next_form_btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // next_form_btn
            // 
            next_form_btn.BackColor = SystemColors.ActiveCaptionText;
            next_form_btn.Font = new Font("Unispace", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            next_form_btn.ForeColor = SystemColors.ButtonHighlight;
            next_form_btn.Location = new Point(338, 260);
            next_form_btn.Name = "next_form_btn";
            next_form_btn.Size = new Size(143, 45);
            next_form_btn.TabIndex = 0;
            next_form_btn.Text = "Next Form";
            next_form_btn.UseVisualStyleBackColor = false;
            next_form_btn.Click += next_form_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Unispace", 51.7499924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(29, 61);
            label1.Name = "label1";
            label1.Size = new Size(749, 83);
            label1.TabIndex = 2;
            label1.Text = "Practice Programs";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(next_form_btn);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button next_form_btn;
        private Label label1;
    }
}