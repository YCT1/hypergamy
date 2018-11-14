using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.MachineLearning.DecisionTrees;
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
            
            for (int i=0; i < 100; i++)
            {
                myMen[i] = new Men();
                myMen[i].SMV = rastgele.Next(1, 11);
                listbox.Items.Add("Sex Count: " + myMen[i].SexCount.ToString() + " SMV: " + myMen[i].SMV.ToString());
            }
            
        }

        private void Group_Click(object sender, EventArgs e)
        {
            
            Random rastgele = new Random();
            for (int i = 0; i < 5000; i++)
            {
                int my1 = rastgele.Next(0, 100);
                int my2 = rastgele.Next(0, 100);
                groupList.Items.Add(myMen[my1].SMV.ToString() + "," + myMen[my2].SMV.ToString());
                if (myMen[my1].SMV > myMen[my2].SMV)
                {
                    myMen[my1].SexCount++;
                    
                }else if(myMen[my2].SMV > myMen[my1].SMV)
                {
                    myMen[my2].SexCount++;
                }
               
            }
            
        }

        private void showSMV_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                listbox.Items.Add("My Man ID:" + i.ToString() + "Sex Count: " + myMen[i].SexCount.ToString() + " SMV: " + myMen[i].SMV.ToString());
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
