using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graham_scan_WF
{
    class Repository
    {

        List<Point> list;
        public Repository(ref List<Point> pointList)
        {
            this.list = pointList;
        }

        public string FileName;
        protected string defaultFileExt = ".txt";
        protected const string DEFAULT_BASE_FILE_NAME = "file";
        private string baseFileName = DEFAULT_BASE_FILE_NAME;
        public string BaseFileName
        {
            get { return baseFileName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    baseFileName = DEFAULT_BASE_FILE_NAME;
                }
                else
                {
                    baseFileName = value.Trim();
                }
            }
        }

        public void Save()
        {
            if(FileName == null)
            {
                SaveAs();
                return;
            }
            if (list.Count == 0 || list == null)
            {
                MessageBox.Show("Нема що зберігати", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (StreamWriter sw = new StreamWriter(FileName, false))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sw.WriteLine(string.Format("p{0}:{1},{2}", i, list[i].X, list[i].Y));
                }
            }
        }

        public void SaveAs()
        {
            if (list.Count == 0 || list == null)
            {
                MessageBox.Show("Нема що зберігати","Інформація",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.FileName = baseFileName;
            saveDialog.DefaultExt = defaultFileExt;
            saveDialog.Filter = "Text Files | *.txt";
            
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveDialog.FileName, false))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        sw.WriteLine(string.Format("p{0}:{1},{2}",i,list[i].X, list[i].Y));
                    }
                }
            }
        }
        

        public void Load()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.FileName;

                using (StreamReader sr = new StreamReader(FileName))
                {
                    string line;
                    list.Clear();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(':');
                        int x, y;
                        x = Int32.Parse(fields[1].Split(',')[0]);
                        y = Int32.Parse(fields[1].Split(',')[1]);
                        Point p = new Point(x, y);

                        list.Add(p);
                    }
                }
            }
        }
    }
}
