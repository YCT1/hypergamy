using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace HyperGamy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int mannumber = 100;
        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Men[] myMen;
        private void hesaplama_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Random rastgele = new Random();
            myMen = new Men[mannumber];
            for (int i=0; i < myMen.Length; i++)
            {
                myMen[i] = new Men();
                myMen[i].SMV = rastgele.Next(1, 11);
                listbox.Items.Add("Sex Count: " + myMen[i].SexCount.ToString() + " SMV: " + myMen[i].SMV.ToString());
                //Progress Bar Code
                progressBar1.Maximum = myMen.Length;
                progressBar1.Value++;
            }
            
        }

        private void Group_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Random rastgele = new Random();
            for (int i = 0; i < myMen.Length; i++)
            {
                int[] my = new int[100];
                string foradd = "";
                int[] SMV = new int[Int32.Parse(numericUpDown1.Value.ToString())+1];
                int maxVal = 0;
                int index = -1;
                for (int a=1; a < numericUpDown1.Value + 1; a++)
                {
                    my[a]= rastgele.Next(0, myMen.Length);
                    foradd = foradd +myMen[my[a]].SMV.ToString() + ",";
                    SMV[a] = myMen[my[a]].SMV;
                    int thisNum = SMV[a];
                    if(thisNum > maxVal)
                    {
                        maxVal = thisNum;
                        index = a;
                    }

                }
                myMen[my[index]].SexCount++;
                groupList.Items.Add(foradd);
                //Progress Bar Code
                progressBar1.Maximum = myMen.Length;
                progressBar1.Value++;
            }

        }

        private void showSMV_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            listbox.Items.Clear();
            for (int i = 0; i < myMen.Length; i++)
            {
                listbox.Items.Add("My Man ID:" + i.ToString() + "Sex Count: " + myMen[i].SexCount.ToString() + " SMV: " + myMen[i].SMV.ToString());
                //Progress Bar Code
                progressBar1.Maximum = myMen.Length;
                progressBar1.Value++;
            }
        }

        private void topla_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            groupList.Items.Clear();
            int[] toplam = new int[11];
            int[] toplamPeople = new int[11];
            float[] avrSex = new float[11];
            int toplamSex = 0;
            for (int i = 0; i < myMen.Length; i++)
            {
                toplam[myMen[i].SMV]= toplam[myMen[i].SMV] + myMen[i].SexCount;
                toplamPeople[myMen[i].SMV]++;
                toplamSex = toplamSex + myMen[i].SexCount;
                //////////////Progress Bar Code
                progressBar1.Maximum = myMen.Length+toplamPeople.Length+toplam.Length;
                progressBar1.Value++;
            }
            for(int i = 1; i < toplamPeople.Length; i++)
            {
                groupList.Items.Add(toplamPeople[i]);
                
                //////////////Progress Bar Code
                progressBar1.Value++;
            }
            groupList.Items.Add("AAAAAAAAAAAAAAA");
            for (int i = 0; i < toplam.Length; i++)
            {
                groupList.Items.Add(i.ToString() + "," + toplam[i]);
                //////////////Progress Bar Code
                progressBar1.Value++;
            }
            groupList.Items.Add("AAAAAAAAAAA");
            groupList.Items.Add(toplamSex);
            groupList.Items.Add("AAAAAAAAAAA");
            for(int i = 1; i < toplam.Length; i++)
            {
                float a = toplam[i];
                float b = toplamPeople[i];
               avrSex[i] = a / b;
                groupList.Items.Add(avrSex[i]);
            }
            if (csvfile.Checked)
            {
                saveFileDialog1.ShowDialog();
                StreamWriter myOutputStream = new StreamWriter(saveFileDialog1.FileName);
                foreach (object item in groupList.Items)
                {
                    myOutputStream.WriteLine(item);
                }
                myOutputStream.Close();
            }
        }

        private void numMen_ValueChanged(object sender, EventArgs e)
        {
            mannumber = Int32.Parse(numMen.Value.ToString());
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            groupList.Items.Clear();
            listbox.Items.Clear();
            myMen = null;
        }
    }

    public class Men
    {
        public int SexCount { get; set; }
        public int SMV { get; set; }
        public Men ()
        {
            SexCount = 0;
            SMV = 0;
        }
        
                
    }
}
