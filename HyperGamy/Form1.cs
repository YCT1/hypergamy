using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperGamy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Men[] myMen = new Men[100];
        private void hesaplama_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            
            for (int i=0; i < myMen.Length; i++)
            {
                myMen[i] = new Men();
                myMen[i].SMV = rastgele.Next(1, 11);
                listbox.Items.Add("Sex Count: " + myMen[i].SexCount.ToString() + " SMV: " + myMen[i].SMV.ToString());
            }
            
        }

        private void Group_Click(object sender, EventArgs e)
        {
            
            Random rastgele = new Random();
            for (int i = 0; i < myMen.Length; i++)
            {
                int[] my = new int[20];
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
                
               
            }
            
        }

        private void showSMV_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            for (int i = 0; i < myMen.Length; i++)
            {
                listbox.Items.Add("My Man ID:" + i.ToString() + "Sex Count: " + myMen[i].SexCount.ToString() + " SMV: " + myMen[i].SMV.ToString());
            }
        }

        private void topla_Click(object sender, EventArgs e)
        {
            groupList.Items.Clear();
            int[] toplam = new int[11];
            for (int i = 0; i < myMen.Length; i++)
            {
                toplam[myMen[i].SMV]= toplam[myMen[i].SMV] + myMen[i].SexCount;
            }
            for (int i = 0; i < toplam.Length; i++)
            {
                groupList.Items.Add(i.ToString() + "," + toplam[i]);
            }
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
