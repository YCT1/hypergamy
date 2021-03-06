﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using Accord.Statistics;
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
            Hesaplama();
        }
        Men[] myMen;
        bool gauss = false;
        bool writeListbox = false;
        string[] groupText;
        
        //Hesaplama Algoritmasi
        private void Hesaplama()
        {
            Random rastgele = new Random();
            progressBar1.Value = 0;
            myMen = new Men[mannumber];
            if (gauss)
            {
                double mean = 5.5;
                double stdDev = 1.38;
                int negSay = 0;
                int pozSay = 0;
                Normal normalDist = new Normal(mean, stdDev);
                for (int i = 0; i < myMen.Length; i++)
                {

                    double a = normalDist.Sample();


                    int b = Convert.ToInt32(a);
                    myMen[i] = new Men();
                    if (b > 10)
                    {
                        negSay++;
                        b = 10;
                    }
                    if (b < 1)
                    {
                        b = 1;
                        pozSay++;
                    }
                    myMen[i].SMV = b;
                    if (writeListbox)
                    {
                       listbox.Items.Add("Sex Count: " + myMen[i].SexCount.ToString() + " SMV: " + myMen[i].SMV.ToString());
                    }

                    //Progress Bar Code
                    progressBar1.Maximum = myMen.Length;
                    progressBar1.Value++;


                }
                if (writeListbox)
                {
                   listbox.Items.Add("Poz Sayisi: " + negSay.ToString() + " Neg Sayisi: " + pozSay.ToString());
                }
                return;
            }
            for (int i = 0; i < myMen.Length; i++)
            {
                myMen[i] = new Men();
                myMen[i].SMV = rastgele.Next(1, 11);
                if (writeListbox)
                {
                   listbox.Items.Add("Sex Count: " + myMen[i].SexCount.ToString() + " SMV: " + myMen[i].SMV.ToString());
                }
                //Progress Bar Code
                progressBar1.Maximum = myMen.Length;
                progressBar1.Value++;
            }
        }
        //Groplama Algoritmasi
        private void Groupla()
        {
            progressBar1.Value = 0;
            Random rastgele = new Random();
            groupText = new string[myMen.Length];
            for (int i = 0; i < myMen.Length; i++)
            {
                int[] my = new int[100];
                string foradd = "";
                int[] SMV = new int[Int32.Parse(numericUpDown1.Value.ToString()) + 1];
                int maxVal = 0;
                int index = -1;
                int randomGroupNumber = rastgele.Next(Int32.Parse(numericUpDown2.Value.ToString()), Int32.Parse(numericUpDown1.Value.ToString()) + 1);
                for (int a = 1; a < randomGroupNumber + 1; a++)
                {
                    my[a] = rastgele.Next(0, myMen.Length);
                    foradd = foradd + myMen[my[a]].SMV.ToString() + ",";
                    SMV[a] = myMen[my[a]].SMV;
                    int thisNum = SMV[a];
                    if (thisNum > maxVal)
                    {
                        maxVal = thisNum;
                        index = a;
                    }

                }
                myMen[my[index]].SexCount++;
                
                if (writeListbox)
                {
                    groupList.Items.Add(foradd);
                }
                groupText[i] = foradd;
                //Progress Bar Code
                progressBar1.Maximum = myMen.Length;
                progressBar1.Value++;
            }
        }
        //Sex Yapma Algoritmasi
        private void showSMVf()
        {
            progressBar1.Value = 0;
            listbox.Items.Clear();
            for (int i = 0; i < myMen.Length; i++)
            {
                if (writeListbox)
                {
                   listbox.Items.Add("ID: " + i.ToString() + " Sex Count: " + myMen[i].SexCount.ToString() + " SMV: " + myMen[i].SMV.ToString());
                }
                //Progress Bar Code
                progressBar1.Maximum = myMen.Length;
                progressBar1.Value++;
            }
        }
        //Topla Algoritmasi
        private void toplaf()
        {
            progressBar1.Value = 0;
            groupList.Items.Clear();
            int[] toplam = new int[11];
            int[] toplamPeople = new int[11];
            float[] avrSex = new float[11];
            int toplamSex = 0;
            for (int i = 0; i < myMen.Length; i++)
            {
                toplam[myMen[i].SMV] = toplam[myMen[i].SMV] + myMen[i].SexCount;
                toplamPeople[myMen[i].SMV]++;
                toplamSex = toplamSex + myMen[i].SexCount;
                //////////////Progress Bar Code
                progressBar1.Maximum = myMen.Length + toplamPeople.Length + toplam.Length;
                progressBar1.Value++;
            }
            for (int i = 1; i < toplamPeople.Length; i++)
            {
                groupList.Items.Add(toplamPeople[i]);

                //////////////Progress Bar Code
                progressBar1.Value++;
            }
            groupList.Items.Add("AAAAAAAAAAAAAAA");
            for (int i = 0; i < toplam.Length; i++)
            {
                groupList.Items.Add(i.ToString() + ";" + toplam[i]);
                //////////////Progress Bar Code
                progressBar1.Value++;
            }
            groupList.Items.Add("AAAAAAAAAAA");
            groupList.Items.Add(toplamSex);
            groupList.Items.Add("AAAAAAAAAAA");
            for (int i = 1; i < toplam.Length; i++)
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

        private void hesaplama_Click(object sender, EventArgs e)
        {
            writeListbox = true;
            Hesaplama();
        }

        private void Group_Click(object sender, EventArgs e)
        {
            writeListbox = true;
            Groupla();

        }

        private void showSMV_Click(object sender, EventArgs e)
        {
            writeListbox = true;
            showSMVf();
        }

        private void topla_Click(object sender, EventArgs e)
        {
            writeListbox = true;
            toplaf();
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

        private void gaussCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gaussCreationToolStripMenuItem.Checked =! gaussCreationToolStripMenuItem.Checked;
            gauss = !gauss;
        }
       
        public static float Sigmoid(double value)
        {
            return 1.0f / (1.0f + (float)Math.Exp(-value));
        }

        private void firstOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            StreamWriter myOutputStream = new StreamWriter(saveFileDialog1.FileName);
            foreach (object item in listbox.Items)
            {
                myOutputStream.WriteLine(item);
            }
            myOutputStream.Close();
        }

        private void secondOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            StreamWriter myOutputStream = new StreamWriter(saveFileDialog1.FileName);
            foreach (object item in groupList.Items)
            {
                myOutputStream.WriteLine(item);
            }
            myOutputStream.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (lockofnumericvalues.Checked)
            {
                numericUpDown2.Value = numericUpDown1.Value;
            }
            else { return; }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (lockofnumericvalues.Checked)
            {
                numericUpDown1.Value = numericUpDown2.Value;
            }
            else { return; }
        }

        private void doAll_Click(object sender, EventArgs e)
        {
            writeListbox = false;
            Hesaplama();
            Groupla();
            //showSMVf();
            toplaf();
            
        }

        private void enterCMD_Click(object sender, EventArgs e)
        {
            ExcCMD();
        }

        private void cmdLine_TextChanged(object sender, EventArgs e)
        {
            //ExcCMD();
        }
       
        private void ExcCMD()
        {
            if(cmdLine.Text == "save -g")
            {
                SaveArayAsCSV(groupText);
            }
            if (cmdLine.Text == "clear -all")
            {
                groupList.Items.Clear();
                listbox.Items.Clear();
            }
            if (cmdLine.Text == "clear -2")
            {
                groupList.Items.Clear();
            }
            if (cmdLine.Text =="clear -1")
            {
                listbox.Items.Clear();
            }
            if (cmdLine.Text == "save -smv")
            {
                string[] SMV = new string[myMen.Length+1];
                SMV[0] = "ID;SMV;Sex Count";
                for (int i = 0; i < myMen.Length; i++)
                {
                    SMV[i+1] = i.ToString() + ";" + myMen[i].SMV.ToString() + ";" + myMen[i].SexCount.ToString();
                }
                SaveArayAsCSV(SMV);
            }
            if (cmdLine.Text == "show -smv")
            {
                listbox.Items.Add("Showing Men SMV");
                for(int i = 0; i < myMen.Length; i++)
                {
                    listbox.Items.Add("ID: " + i.ToString() + " SMV: " + myMen[i].SMV.ToString());
                }

            }
        }

        private void SaveArayAsCSV(object[] ali)
        {
            saveFileDialog1.ShowDialog();
            StreamWriter myOutputStream = new StreamWriter(saveFileDialog1.FileName);
            foreach (object item in ali)
            {
                myOutputStream.WriteLine(item);
            }
            myOutputStream.Close();
        }
    }

    public class Men
    {
        public int SexCount { get; set; }
        public int SMV { get; set; }
        public int L { get; set; }
        public int M { get; set; }
        public int S { get; set; }
        public Men ()
        {
            SexCount = 0;
            SMV = 0;
            L = 0;
            M = 0;
            S = 0;
            
        }
        
                
    }
    
}
