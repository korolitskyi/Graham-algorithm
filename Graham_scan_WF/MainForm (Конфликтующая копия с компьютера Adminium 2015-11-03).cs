using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graham_scan_WF
{
    public partial class MainForm : Form
    {
        Polygon polygon;
        Repository repository;
        public MainForm()
        {
            InitializeComponent();
            polygon = new Polygon(pictureBox);
            repository = new Repository(ref polygon.pointsList);

        }

        void Bindings()
        {
            toolStripButton_Open.Click += ToolStripMenuItem_Open_Click;
            toolStripButton_Save.Click += ToolStripMenuItem_Save_Click;
        }
                
        
        private void ToolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            repository.Load();
            polygon.Draw();            
        }

        private void ToolStripMenuItem_StandartPanel_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItem_StandartPanel.Checked == true)
            {
                ToolStripMenuItem_StandartPanel.Checked = false;
                toolStrip_Standart.Visible = false;
            }
            else
            {
                ToolStripMenuItem_StandartPanel.Checked = true;
                toolStrip_Standart.Visible = true;
            }

        }

        private void ToolStripMenuItem_Activitys_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItem_Activitys.Checked == true)
            {
                ToolStripMenuItem_Activitys.Checked = false;
                toolStrip_Activitys.Visible = false;
            }
            else
            {
                ToolStripMenuItem_Activitys.Checked = true;
                toolStrip_Activitys.Visible = true;
            }
        }

        private void toolStrip_Standart_DragDrop(object sender, DragEventArgs e)
        {
            polygon.Draw();
        }

        private void toolStripButton_RemovePoint_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip_Standart_EndDrag(object sender, EventArgs e)
        {
            if(polygon.pointsList.Count != 0)
                polygon.Draw();
        }

        private void ToolStripMenuItem_Create_Click(object sender, EventArgs e)
        {
            if(polygon.pointsList.Count != 0)
            {
                DialogResult dr = MessageBox.Show("Ви точно бажаєте створити новий проект?", "Обережно", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    polygon.Clear();
                }
            }
        }

        private void toolStripButton_Create_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Create_Click(sender, e);
        }

        private void ToolStripMenuItem_Save_Click(object sender, EventArgs e)
        {
            repository.Save();
        }

        private void ЯкToolStripMenuItem_SaveAs_Click(object sender, EventArgs e)
        {
            repository.SaveAs();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ви точно бажаєте вийти?","Вихід",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
