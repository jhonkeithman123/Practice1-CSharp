namespace Practice1
{
    partial class Form4
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
            prev_form_btn = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            inputBox = new TextBox();
            label2 = new Label();
            add_btn = new Button();
            remove_btn = new Button();
            clear_all_btn = new Button();
            SuspendLayout();
            // 
            // next_form_btn
            // 
            next_form_btn.BackColor = SystemColors.ActiveCaptionText;
            next_form_btn.Font = new Font("Unispace", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            next_form_btn.ForeColor = SystemColors.Control;
            next_form_btn.Location = new Point(994, 605);
            next_form_btn.Name = "next_form_btn";
            next_form_btn.Size = new Size(144, 41);
            next_form_btn.TabIndex = 6;
            next_form_btn.Text = "Next Form";
            next_form_btn.UseVisualStyleBackColor = false;
            next_form_btn.Click += next_form_btn_Click;
            // 
            // prev_form_btn
            // 
            prev_form_btn.BackColor = SystemColors.ActiveCaptionText;
            prev_form_btn.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prev_form_btn.ForeColor = SystemColors.Control;
            prev_form_btn.Location = new Point(813, 606);
            prev_form_btn.Name = "prev_form_btn";
            prev_form_btn.Size = new Size(149, 41);
            prev_form_btn.TabIndex = 7;
            prev_form_btn.Text = "Previous Form";
            prev_form_btn.UseVisualStyleBackColor = false;
            prev_form_btn.Click += prev_form_btn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(53, 106);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1027, 319);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Unispace", 51.7499924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(455, 83);
            label1.TabIndex = 9;
            label1.Text = "To-Do List";
            // 
            // inputBox
            // 
            inputBox.Location = new Point(53, 460);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(311, 23);
            inputBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 438);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 11;
            label2.Text = "Input";
            // 
            // add_btn
            // 
            add_btn.BackColor = SystemColors.GradientInactiveCaption;
            add_btn.Location = new Point(53, 492);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(80, 33);
            add_btn.TabIndex = 12;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // remove_btn
            // 
            remove_btn.BackColor = SystemColors.GradientInactiveCaption;
            remove_btn.Location = new Point(153, 492);
            remove_btn.Name = "remove_btn";
            remove_btn.Size = new Size(80, 33);
            remove_btn.TabIndex = 13;
            remove_btn.Text = "Remove";
            remove_btn.UseVisualStyleBackColor = false;
            remove_btn.Click += remove_btn_Click;
            // 
            // clear_all_btn
            // 
            clear_all_btn.BackColor = SystemColors.GradientInactiveCaption;
            clear_all_btn.Location = new Point(253, 492);
            clear_all_btn.Name = "clear_all_btn";
            clear_all_btn.Size = new Size(80, 33);
            clear_all_btn.TabIndex = 14;
            clear_all_btn.Text = "Clear All";
            clear_all_btn.UseVisualStyleBackColor = false;
            clear_all_btn.Click += clear_all_btn_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 702);
            Controls.Add(clear_all_btn);
            Controls.Add(remove_btn);
            Controls.Add(add_btn);
            Controls.Add(label2);
            Controls.Add(inputBox);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(prev_form_btn);
            Controls.Add(next_form_btn);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button next_form_btn;
        private Button prev_form_btn;
        private ListBox listBox1;
        private Label label1;
        private TextBox inputBox;
        private Label label2;
        private Button add_btn;
        private Button remove_btn;
        private Button clear_all_btn;
    }
}