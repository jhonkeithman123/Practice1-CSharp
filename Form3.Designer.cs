namespace Practice1
{
    partial class Form3
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
            label1 = new Label();
            platform_text = new TextBox();
            clear_btn = new Button();
            open_btn = new Button();
            save_btn = new Button();
            next_form_btn = new Button();
            prev_form_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Unispace", 51.7499924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(581, 83);
            label1.TabIndex = 0;
            label1.Text = "Notepad Clone";
            // 
            // platform_text
            // 
            platform_text.Location = new Point(24, 121);
            platform_text.Multiline = true;
            platform_text.Name = "platform_text";
            platform_text.Size = new Size(981, 462);
            platform_text.TabIndex = 1;
            platform_text.TextChanged += platform_text_TextChanged;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = SystemColors.GradientInactiveCaption;
            clear_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear_btn.Location = new Point(24, 612);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(103, 41);
            clear_btn.TabIndex = 2;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // open_btn
            // 
            open_btn.BackColor = SystemColors.GradientInactiveCaption;
            open_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            open_btn.Location = new Point(211, 612);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(103, 41);
            open_btn.TabIndex = 3;
            open_btn.Text = "Open";
            open_btn.UseVisualStyleBackColor = false;
            open_btn.Click += open_btn_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = SystemColors.GradientInactiveCaption;
            save_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save_btn.Location = new Point(403, 612);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(103, 41);
            save_btn.TabIndex = 4;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // next_form_btn
            // 
            next_form_btn.BackColor = SystemColors.ActiveCaptionText;
            next_form_btn.Font = new Font("Unispace", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            next_form_btn.ForeColor = SystemColors.Control;
            next_form_btn.Location = new Point(861, 610);
            next_form_btn.Name = "next_form_btn";
            next_form_btn.Size = new Size(144, 41);
            next_form_btn.TabIndex = 5;
            next_form_btn.Text = "Next Form";
            next_form_btn.UseVisualStyleBackColor = false;
            // 
            // prev_form_btn
            // 
            prev_form_btn.BackColor = SystemColors.ActiveCaptionText;
            prev_form_btn.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prev_form_btn.ForeColor = SystemColors.Control;
            prev_form_btn.Location = new Point(689, 610);
            prev_form_btn.Name = "prev_form_btn";
            prev_form_btn.Size = new Size(149, 41);
            prev_form_btn.TabIndex = 6;
            prev_form_btn.Text = "Previous Form";
            prev_form_btn.UseVisualStyleBackColor = false;
            prev_form_btn.Click += prev_form_btn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 718);
            Controls.Add(prev_form_btn);
            Controls.Add(next_form_btn);
            Controls.Add(save_btn);
            Controls.Add(open_btn);
            Controls.Add(clear_btn);
            Controls.Add(platform_text);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox platform_text;
        private Button clear_btn;
        private Button open_btn;
        private Button save_btn;
        private Button next_form_btn;
        private Button prev_form_btn;
    }
}