using System.Diagnostics;

namespace JsonToMenuWidgetJson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            treeView1 = new TreeView();
            AddNodeButton = new Button();
            RemoveNodeButton = new Button();
            Up = new Button();
            Down = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(300, 344);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(669, 344);
            button2.Name = "button2";
            button2.Size = new Size(137, 23);
            button2.TabIndex = 1;
            button2.Text = "Generate Json";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(552, 344);
            button3.Name = "button3";
            button3.Size = new Size(115, 23);
            button3.TabIndex = 2;
            button3.Text = "Copy To Clipboard";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(16, 93);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(359, 245);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.MouseHover += richTextBox1_MouseHover;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(381, 93);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(425, 245);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // treeView1
            // 
            treeView1.AllowDrop = true;
            treeView1.Location = new Point(16, 373);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(790, 280);
            treeView1.TabIndex = 5;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            // 
            // AddNodeButton
            // 
            AddNodeButton.Location = new Point(16, 344);
            AddNodeButton.Name = "AddNodeButton";
            AddNodeButton.Size = new Size(75, 23);
            AddNodeButton.TabIndex = 6;
            AddNodeButton.Text = "Add Category Item";
            AddNodeButton.UseVisualStyleBackColor = true;
            AddNodeButton.Click += button4_Click;
            // 
            // RemoveNodeButton
            // 
            RemoveNodeButton.Location = new Point(97, 344);
            RemoveNodeButton.Name = "RemoveNodeButton";
            RemoveNodeButton.Size = new Size(75, 23);
            RemoveNodeButton.TabIndex = 7;
            RemoveNodeButton.Text = "Remove";
            RemoveNodeButton.UseVisualStyleBackColor = true;
            RemoveNodeButton.Click += RemoveNodeButton_Click;
            // 
            // Up
            // 
            Up.Location = new Point(178, 344);
            Up.Name = "Up";
            Up.Size = new Size(38, 23);
            Up.TabIndex = 8;
            Up.Text = "Up";
            Up.UseVisualStyleBackColor = true;
            Up.Click += Up_Click;
            // 
            // Down
            // 
            Down.Location = new Point(222, 344);
            Down.Name = "Down";
            Down.Size = new Size(46, 23);
            Down.TabIndex = 9;
            Down.Text = "Down";
            Down.UseVisualStyleBackColor = true;
            Down.Click += Down_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 75);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 10;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 75);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 11;
            label2.Text = "Output";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 6);
            label3.Name = "label3";
            label3.Size = new Size(266, 15);
            label3.TabIndex = 12;
            label3.Text = "* Input must always have a Left and Right section";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 21);
            label4.Name = "label4";
            label4.Size = new Size(306, 15);
            label4.TabIndex = 13;
            label4.Text = "* To reset to default close and open the application again";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 36);
            label5.Name = "label5";
            label5.Size = new Size(712, 15);
            label5.TabIndex = 14;
            label5.Text = "* You can move up and down each node, create new categories and subcategories, click on each node to open and edit each category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 51);
            label6.Name = "label6";
            label6.Size = new Size(624, 15);
            label6.TabIndex = 15;
            label6.Text = "* Copy paste the content item and click import, make changes then click Generate Json to have the new content item";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 664);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Down);
            Controls.Add(Up);
            Controls.Add(RemoveNodeButton);
            Controls.Add(AddNodeButton);
            Controls.Add(treeView1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Simple Dynamic Menu  - by Rodrigo Rea for Colorstreet";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private TreeView treeView1;
        private Button AddNodeButton;
        private Button RemoveNodeButton;
        private Button Up;
        private Button Down;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}