namespace JsonToMenuWidgetJson
{
    partial class EditNode
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Url_TB = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            Title = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            targetTextbox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 23);
            textBox2.TabIndex = 1;
            // 
            // Url_TB
            // 
            Url_TB.Location = new Point(12, 110);
            Url_TB.Name = "Url_TB";
            Url_TB.Size = new Size(231, 23);
            Url_TB.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(12, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd hh:ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(12, 226);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(231, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 147);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Has Start Date";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 201);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(96, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Has End Date";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(12, 8);
            Title.Name = "Title";
            Title.Size = new Size(29, 15);
            Title.TabIndex = 7;
            Title.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 8;
            label2.Text = "CategoryKey";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 9;
            label3.Text = "Url";
            // 
            // button1
            // 
            button1.Location = new Point(168, 300);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // targetTextbox
            // 
            targetTextbox.Location = new Point(12, 271);
            targetTextbox.Name = "targetTextbox";
            targetTextbox.Size = new Size(231, 23);
            targetTextbox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 253);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 12;
            label1.Text = "Target";
            // 
            // EditNode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 335);
            Controls.Add(label1);
            Controls.Add(targetTextbox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Title);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(Url_TB);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "EditNode";
            Text = "EditNode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox Url_TB;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label Title;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox targetTextbox;
        private Label label1;
    }
}