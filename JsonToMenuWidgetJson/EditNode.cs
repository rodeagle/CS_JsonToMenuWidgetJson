using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonToMenuWidgetJson
{
    public partial class EditNode : Form
    {
        public int count = 1;
        public Category node;
        public EditNode(Category node)
        {
            this.node = node;
            InitializeComponent();
            this.textBox1.Text = node.Title;
            this.textBox2.Text = node.CategoryKey;
            this.Url_TB.Text = node.Url;
            this.targetTextbox.Text = node.Target;
            if (node.StartDate != null)
            {
                this.dateTimePicker1.Value = node.StartDate.Value;
                this.checkBox1.Checked = true;
            }
            if (node.EndDate != null)
            {
                this.dateTimePicker2.Value = node.EndDate.Value;
                this.checkBox2.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            node.Title = this.textBox1.Text;
            if (this.Url_TB.Text != "")
            {
                node.Url = this.Url_TB.Text;
            }
            node.CategoryKey = this.textBox2.Text;
            if (this.checkBox1.Checked)
                node.StartDate = this.dateTimePicker1.Value;
            if (this.checkBox2.Checked)
                node.EndDate = this.dateTimePicker2.Value;
            node.Target = this.targetTextbox.Text;
            this.DialogResult = DialogResult.OK;


        }
    }
}
