using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YK_47_Password_Generator
{
    public partial class combinationPasswordGeneratorForm : Form
    {
        public combinationPasswordGeneratorForm()
        {
            InitializeComponent();
        }

        private void btnPasswordAdd_Click(object sender, EventArgs e)
        {
            listPassword.Items.Add(textBox1.Text);
        }

        private void btnSelectedPasswordRemove_Click(object sender, EventArgs e)
        {
            if (listPassword.SelectedIndex != -1)
                listPassword.Items.Remove(listPassword.SelectedIndex);
        }

        private void btnPasswordExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt file(*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var item in listPassword.Items)
                    sw.WriteLine(item);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        private void btnPasswordInport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt file(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "")
                    { line = sr.ReadLine(); continue; }
                    listPassword.Items.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
        }

        private void btnResultExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt file(*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var item in listResult.Items)
                    sw.WriteLine(item);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        private void Crate_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => combination(listGenerator(), null, 0));
            th.Start();
        }
        List<string> combination(List<string> ilkListe, List<string> olusturulanListe, int kactayız)
        {
            List<string> resultList = new List<string>();
            if (kactayız == ilkListe.Count - 1)
            {
                return null;
            }
            else
            {

                if (olusturulanListe == null)
                    foreach (string item in ilkListe)
                        for (int i = 0; i <= ilkListe.Count - 1; i++)
                        {
                            string raks = item.ToString() + ilkListe[i].ToString();
                            listResult.Items.Add(raks);
                            resultList.Add(raks);
                        }
                else
                    foreach (string item in olusturulanListe)
                        for (int i = 0; i <= ilkListe.Count - 1; i++)
                        {
                            string raks = item.ToString() + ilkListe[i].ToString();
                            listResult.Items.Add(raks);
                            resultList.Add(raks);
                        }
            }
            List<string> vale = combination(ilkListe, resultList, ++kactayız);
            if (vale == null)
                return resultList;
            else
                foreach (string item in vale)
                    resultList.Add(item);

            return resultList;
        }

        List<string> listGenerator()
        {
            List<string> resultList = new List<string>();
            foreach (string item in listPassword.Items)
            {
                resultList.Add(item);
            }
            return resultList;
        }

        private void combinationPasswordGeneratorForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
