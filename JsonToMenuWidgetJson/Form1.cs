using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JsonToMenuWidgetJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Set the tooltip text for the TextBox control
            toolTip.SetToolTip(this.richTextBox1, "Enter your text here");

            // Enable the tooltip for the TextBox control
            toolTip.Active = true;

            AppService.StartApp(richTextBox2, treeView1, AddNodeButton, RemoveNodeButton, richTextBox1, Up, Down);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Select a Valid Node");
            }

            var selectedNode = treeView1.SelectedNode;
            Category dataNode = new Category();
            dataNode.Title = "New Web Category " + new Random().Next(1, 100);
            TreeNode treeNode = new TreeNode();
            if (selectedNode.Level == 1)
            {
                treeNode.BackColor = Color.Green;
                treeNode.ForeColor = Color.White;
            }
            treeNode.Tag = dataNode;
            treeNode.Text = dataNode.Title;
            //((Category)selectedNode.Parent.Tag).SubCategories.Append(dataNode);
            selectedNode.Nodes.Add(treeNode);
            treeView1.Update();
            treeView1.ExpandAll();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level < 2)
            {
                return;
            }
            using (var form = new EditNode((Category)e.Node.Tag))
            {
                DialogResult dialog = form.ShowDialog(this);
                if (form.DialogResult == DialogResult.OK)
                {
                    e.Node.Tag = form.node;
                    e.Node.Text = form.node.Title;
                }
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.SelectedNode = e.Node;
            if (e.Node.Level == 1)
                AppService.NodeControlVisbility(true, true);
            else if (e.Node.Level == 2)
                AppService.NodeControlVisbility(true, hideUpDown: false);
            else if (e.Node.Level == 3)
                AppService.NodeControlVisbility(true, hideAdd: true, hideUpDown: false);
            else
                AppService.NodeControlVisbility(false);
        }

        private void treeView1_Leave(object sender, EventArgs e)
        {
            AppService.NodeControlVisbility(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox2.Text = AppService.GetTreeToJson();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppService.GetImportedTree();
        }

        private void RemoveNodeButton_Click(object sender, EventArgs e)
        {
            var currentnode = treeView1.SelectedNode;
            treeView1.Nodes.Remove(currentnode);
            treeView1.Update();
            treeView1.ExpandAll();

        }

        private void Up_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;
            TreeNode parentNode = selectedNode.Parent;
            int index = parentNode.Nodes.IndexOf(selectedNode);
            if (index > 0)
            {
                // Move the selected node up one position
                parentNode.Nodes.RemoveAt(index);
                parentNode.Nodes.Insert(index - 1, selectedNode);

                selectedNode.EnsureVisible();
                treeView1.SelectedNode = selectedNode;
                treeView1.Focus();

            }

        }

        private void Down_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;
            TreeNode parentNode = selectedNode.Parent;
            int index = parentNode.Nodes.IndexOf(selectedNode);
            if (index >= 0)
            {
                // Move the selected node up one position
                parentNode.Nodes.RemoveAt(index);
                parentNode.Nodes.Insert(index + 1, selectedNode);

                selectedNode.EnsureVisible();
                treeView1.SelectedNode = selectedNode;
                treeView1.Focus();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.richTextBox2.Text.Length > 0)
            {
                Clipboard.SetText(this.richTextBox2.Text);
            }
            MessageBox.Show("Copied to clipboard");
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}