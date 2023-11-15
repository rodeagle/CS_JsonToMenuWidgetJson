using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonToMenuWidgetJson
{
    internal class DontSerializeAttribute : Attribute
    {
    }

    public class Category
    {
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public int? id;
        [JsonProperty(Required = Required.Always)]
        public string Title;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string CategoryKey;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Url;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Category> SubCategories;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Target;
        public Category()
        {
            SubCategories  = new List<Category>();
        }

        public Category(Category category)
        {
            Title = category.Title;
            CategoryKey = category.CategoryKey;
            Url = category.Url;
            SubCategories = new List<Category>();
            StartDate = category.StartDate;
            EndDate = category.EndDate;
            Target = category.Target;
        }
    }

    public class Tree
    {
        public IEnumerable<Category> Left;
        public IEnumerable<Category> Middle;
        public IEnumerable<Category> Right;

        public Tree()
        {
            Left = new List<Category>();
            Middle = new List<Category>();
                Right = new List<Category>();
        }

    }

    internal class AppService
    {
        private static Dictionary<int, Category>? HashMap;
        private static TreeView treeviewer;
        private static Button AddNode;
        private static Button RemoveNode;
        private static Tree tree;
        private static RichTextBox input;
        private static RichTextBox output;
        private static Button _Up;
        private static Button _Down;

        public static void StartApp(RichTextBox richTextBox2, TreeView treeView1, Button add, Button remove, RichTextBox input, Button Up, Button Down)
        {
            treeviewer = treeView1;
            AddNode = add;
            RemoveNode = remove;
            AppService.input = input;
            output = richTextBox2;
            _Up = Up;
            _Down = Down;   
            AppService.NodeControlVisbility(false);

            string json = @"
            {
                Left : [
 
                ],
                Middle : [

                ],
                Right : [

                ]
            }
            "
            ;

            input.Text = json;

            tree = JsonConvert.DeserializeObject<Tree>(json);

            BuildTree();

        }

        public static void NodeControlVisbility(bool areVisible, bool hideRemove = false, bool hideAdd = false, bool hideUpDown = true)
        {
            RemoveNode.Visible = areVisible;
            AddNode.Visible = areVisible;
            _Up.Visible = true;
            _Down.Visible = true;
            if (hideUpDown)
            {
                _Down.Visible = false;
                _Up.Visible = false;
            }
            if(hideRemove)
                RemoveNode.Visible = false;
            if(hideAdd)
                AddNode.Visible = false;
        }

        public static string GetTreeToJson()
        {
            var tree = new Tree();

            var parentNode = treeviewer.Nodes[0];
            //var _side = parentNode.Nodes[0];

            foreach (TreeNode side in parentNode.Nodes) {
                
                List<Category> categories = new List<Category>();
                foreach (var n in side.Nodes)
                {
                    TreeNode node = (TreeNode)n;
                    Category cat = new Category((Category)node.Tag);
                    if (node.Nodes != null && node.Nodes.Count > 0)
                    {
                        foreach (TreeNode subnode in node.Nodes)
                        {
                            var subCat = (Category)subnode.Tag;
                            subCat.SubCategories = null;
                            cat.SubCategories = cat.SubCategories.Append(subCat);
                        }
                    }
                    else
                    {
                        cat.SubCategories = null;
                    }
                    categories.Add(cat);
                }

                switch (side.Text) {
                    case "Left":
                        tree.Left = categories;
                        break;
                    case "Middle":

                        if (categories.Any())
                            tree.Middle = categories;
                        else tree.Middle = null;
                        break;
                    case "Right":
                        tree.Right = categories;
                        break;
                }
            }
            
            //List<Category> categories = new List<Category>();
            //foreach(var n in side.Nodes)
            //{
            //    TreeNode node = (TreeNode)n;
            //    Category cat = new Category((Category)node.Tag);
            //    if (node.Nodes != null && node.Nodes.Count > 0)
            //    {
            //        foreach (TreeNode subnode in node.Nodes) {
            //            var subCat = (Category)subnode.Tag;
            //            subCat.SubCategories = null;
            //            cat.SubCategories = cat.SubCategories.Append(subCat);
            //        }
            //    }
            //    else
            //    {
            //        cat.SubCategories = null;
            //    }
            //    categories.Add(cat);
            //}
            //tree.Left = categories;
            //categories = new List<Category>();
            //side = parentNode.Nodes[2];
            //foreach (var n in side.Nodes)
            //{
            //    TreeNode node = (TreeNode)n;
            //    Category cat = new Category((Category)node.Tag);
            //    if (node.Nodes != null && node.Nodes.Count > 0)
            //    {
            //        foreach (TreeNode subnode in node.Nodes)
            //        {
            //            var subCat = (Category)subnode.Tag;
            //            subCat.SubCategories = null;
            //            cat.SubCategories = cat.SubCategories.Append(subCat);
            //        }
            //    }
            //    else
            //    {
            //        cat.SubCategories = null;
            //    }
            //    categories.Add(cat);
            //}
            //tree.Right = categories;
            //categories = new List<Category>();
            //side = parentNode.Nodes[1];
            //foreach (var n in side.Nodes)
            //{
            //    TreeNode node = (TreeNode)n;
            //    Category cat = new Category((Category)node.Tag);
            //    if (node.Nodes != null && node.Nodes.Count > 0)
            //    {
            //        foreach (TreeNode subnode in node.Nodes)
            //        {
            //            var subCat = (Category)subnode.Tag;
            //            subCat.SubCategories = null;
            //            cat.SubCategories = cat.SubCategories.Append(subCat);
            //        }
            //    }
            //    else
            //    {
            //        cat.SubCategories = null;
            //    }
            //    categories.Add(cat);
            //}
            //tree.Middle = categories;


            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
                DateTimeZoneHandling = DateTimeZoneHandling.Local,
                DateFormatString = "yyyy-MM-dd HH:mm" // Set the custom date format string
            };
            return JsonConvert.SerializeObject(tree, Formatting.Indented,settings);
        }

        public static void GetImportedTree()
        {
            var json = input.Text;
            tree = JsonConvert.DeserializeObject<Tree>(json);
            treeviewer.Nodes.Clear();
            BuildTree();
        }

        private static void BuildTree()
        {

            TreeNode root = new TreeNode();

            var leftSection = new TreeNode($"Left");
            foreach (var node in tree.Left) {

                var category = new TreeNode($"{node.Title}");
                category.BackColor = Color.Green;
                category.ForeColor = Color.White;
                foreach (var subNode in node.SubCategories) {
                    var subCategory = new TreeNode($"{subNode.Title}");
                    subCategory.Tag = subNode;
                    category.Nodes.Add(subCategory);
                }
                // we use the treeview to control the subcategories
                node.SubCategories = new List<Category>();
                category.Tag = node;
                leftSection.Nodes.Add(category);
            }
            root.Nodes.Add(leftSection);
            /////////
            var middleSection = new TreeNode($"Middle");
            foreach (var node in tree.Middle)
            {

                var category = new TreeNode($"{node.Title}");
                category.BackColor = Color.Green;
                category.ForeColor = Color.White;
                foreach (var subNode in node.SubCategories)
                {
                    var subCategory = new TreeNode($"{subNode.Title}");
                    subCategory.Tag = subNode;
                    category.Nodes.Add(subCategory);
                }
                node.SubCategories = new List<Category>();
                category.Tag = node;
                middleSection.Nodes.Add(category);
            }
                root.Nodes.Add(middleSection);
            /////////
            var rightSection = new TreeNode($"Right");
            foreach (var node in tree.Right)
            {

                var category = new TreeNode($"{node.Title}");
                category.BackColor = Color.Green;
                category.ForeColor = Color.White;
                foreach (var subNode in node.SubCategories)
                {
                    var subCategory = new TreeNode($"{subNode.Title}");
                    subCategory.Tag = subNode;
                    category.Nodes.Add(subCategory);
                }
                node.SubCategories = new List<Category>();
                category.Tag = node;
                rightSection.Nodes.Add(category);
            }
            root.Nodes.Add(rightSection);


            treeviewer.Nodes.Add(root);
            treeviewer.ExpandAll();

            

        }
    }



}
