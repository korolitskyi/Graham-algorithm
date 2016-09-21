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
            Bindings();


            //Point[] lol = new Point[4] { new Point(0, 0),new Point(100,1), new Point(100, 50), new Point(1, 100) };
            //polygon.Solve(lol);
        }

        void Bindings()
        {
            toolStripButton_Open.Click += ToolStripMenuItem_Open_Click;
            toolStripButton_Save.Click += ToolStripMenuItem_Save_Click;
            toolStripButton_Create.Click += ToolStripMenuItem_Create_Click;
            toolStripButton_AddPoint.Click += ToolStripMenuItem_AddPoint_Click;
            toolStripButton_RemovePoint.Click += ToolStripMenuItem_RemovePoint_Click;
            toolStrip_Activitys.EndDrag += ToolStrip_Standart_EndDrag;
        }
                
        
        private void ToolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            repository.Load();
            polygon.Draw();            
        }
        private void ToolStrip_Standart_EndDrag(object sender, EventArgs e)
        {
            if (polygon.pointsList.Count != 0)
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
        private void ToolStripMenuItem_Create_Click(object sender, EventArgs e)
        {
            if(polygon.pointsList.Count != 0)
            {
                DialogResult dr = MessageBox.Show("Ви точно бажаєте створити новий проект?", "Обережно", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    polygon.Clear();
                    repository.FileName = null;
                }
            }
        }
        private void ToolStripMenuItem_Save_Click(object sender, EventArgs e)
        {
            repository.Save();
        }
        private void ToolStripMenuItem_SaveAs_Click(object sender, EventArgs e)
        {
            repository.SaveAs();
        }
        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ви точно бажаєте вийти?","Вихід",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ToolStripMenuItem_AddPoint_Click(object sender, EventArgs e)
        {
            if(toolStripButton_AddPoint.Checked == false)
            {
                if (toolStripButton_RemovePoint.Checked == true)
                {
                    toolStripButton_RemovePoint.Checked = false;
                }
                toolStripButton_AddPoint.Checked = true;
            }
            else
            {
                toolStripButton_AddPoint.Checked = false;
            }
        }

        private void ToolStripMenuItem_RemovePoint_Click(object sender, EventArgs e)
        {
            if (toolStripButton_RemovePoint.Checked == false)
            {
                if (toolStripButton_AddPoint.Checked == true)
                {
                    toolStripButton_AddPoint.Checked = false;
                }
                toolStripButton_RemovePoint.Checked = true;
            }
            else
            {
                toolStripButton_RemovePoint.Checked = false;
            }
        }        

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                if(toolStripButton_AddPoint.Checked == true || toolStripButton_RemovePoint.Checked == true)
                {
                    toolStripButton_AddPoint.Checked = false;
                    toolStripButton_RemovePoint.Checked = false;
                }else
                    Close();
            }
        }
        

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (toolStripButton_AddPoint.Checked == true)
            {
                polygon.AddPoint(e.X, e.Y);
            }else if (toolStripButton_RemovePoint.Checked == true)
            {
                polygon.RemovePoint(e.X, e.Y);
            }
        }
    }
}
