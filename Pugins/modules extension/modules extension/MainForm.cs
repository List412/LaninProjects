using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface;

namespace modules_extension
{
    public partial class Form1 : Form, IMainApp
    {
        private static readonly string DEFAULT_FOLDER = System.AppDomain.CurrentDomain.BaseDirectory;

        private Dictionary<string, IPlugin> plugins = new Dictionary<string, IPlugin>();

        public Form1()
        {
            InitializeComponent();
            FindPlugins();
            CreatePluginsMenu();
        }

        public Bitmap Image
        {
            get => pic_image.Image as Bitmap;
            set => pic_image.Image = value;
        }

        private void FindPlugins()
        {
            string[] files = Directory.GetFiles(DEFAULT_FOLDER, "*.dll");

            foreach (var file in files)
                try
                {
                    Assembly assembly = Assembly.LoadFile(file);

                    //Type type = assembly.GetType("")

                    foreach (var type in assembly.GetTypes())
                    {
                        Type iface = type.GetInterface("Interface.IPlugin");

                        if (iface != null)
                        {
                            IPlugin plugin = Activator.CreateInstance(type) as IPlugin;
                            plugins.Add(plugin.Name, plugin);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Plugin load exeption: " + file + "\n" + e.Message);
                }
        }

        void CreatePluginsMenu()
        {
            foreach (var name in plugins.Keys)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(name);
                item.Click += OnPluginClick;
                filtresToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        private void OnPluginClick(object sender, EventArgs args)
        {
            object plugin = plugins[((ToolStripMenuItem) sender).Text];

            var type = plugin.GetType();

            var method = type.GetMethod("Transform");            

            new Thread(() => { method?.Invoke(plugin, new object[] { this }); }).Start(); 

            // new Thread(() => { plugin.Transform(this); }).Start();
        }    

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)            
                Image = new Bitmap(open.FileName);            
        }
    }
}
