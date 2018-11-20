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
using System.Numerics;
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
            //Hesaplama();
        }
        Men[] myMen;
        Women[] myWomen;
        bool gauss = false;
        bool writeListbox = false;
        string[] groupText;
        
        //Hesaplama Algoritmasi
        private void Hesaplama()
        {
            Random rastgele = new Random();
            progressBar1.Value = 0;
            myMen = new Men[mannumber];
            myWomen = new Women[mannumber];
            if (gauss)
            {
                double mean = 5.5;
                double stdDev = 1.38;
                int negSay = 0;
                int pozSay = 0;
                Normal normalDist = new Normal(mean, stdDev);
                Normal looks = new Normal(mean, stdDev);
                //Normal money = new Normal(2, 1.8);
                Normal status = new Normal(3.5, 3);
                //Binomial den = new Binomial(0.21, 10);
                Beta bet = new Beta(2.8, 6);
                
                Normal wMoney = new Normal(10, 5);
                for (int i = 0; i < myMen.Length; i++)
                {

                    double l = looks.Sample();
                    double m = bet.Sample()*10;
                    double s = status.Sample();
                    double degX =  10*rastgele.NextDouble();
                    double wMoneyi = wMoney.Sample();
                    if (wMoneyi >10)
                    {
                        wMoneyi = 10;
                    }
                    if (wMoneyi < 1)
                    {
                        wMoneyi = 1;
                    }
                    //listbox.Items.Add(wMoneyi.ToString());
                    int li = Convert.ToInt32(l);
                    int mi = Convert.ToInt32(m);
                    int si = Convert.ToInt32(s);
                    int wmi = Convert.ToInt32(wMoneyi);
                    myMen[i] = new Men();
                    myWomen[i] = new Women();
                    myWomen[i].weightLMS = new Vector3(rastgele.Next(1, 11), wmi, rastgele.Next(1, 11));
                    if (li > 10)
                    {
                        negSay++;
                        li = 10;
                    }
                    if (li < 1)
                    {
                        li = 1;
                        pozSay++;
                    }
                    if (mi > 10)
                    {
                        negSay++;
                        mi = 10;
                    }
                    if (mi < 1)
                    {
                        mi = 1;
                        pozSay++;
                    }
                    if (si > 10)
                    {
                        negSay++;
                        si = 10;
                    }
                    if (si < 1)
                    {
                        si = 1;
                        pozSay++;
                    }
                    myMen[i].LMS = new Vector3(li, mi, si);
                    if (writeListbox)
                    {
                       listbox.Items.Add("Sex Count: " + myMen[i].LMS.ToString() + " SMV: " + myMen[i].SMV.ToString());
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
                myMen[i].LMS = new Vector3(rastgele.Next(1, 11), rastgele.Next(1, 11), rastgele.Next(1, 11));
                myWomen[i] = new Women();
                myWomen[i].weightLMS = new Vector3(rastgele.Next(1, 11), rastgele.Next(1, 11), rastgele.Next(1, 11));
                if (writeListbox)
                {
                   listbox.Items.Add("MEN: Sex Count: " + myMen[i].SexCount.ToString() + " LMS: " + myMen[i].LMS.ToString());
                   listbox.Items.Add("Women LMS: " + myWomen[i].weightLMS.ToString());

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
                float maxVal = 0;
                int index = -1;
                int randomGroupNumber = rastgele.Next(Int32.Parse(numericUpDown2.Value.ToString()), Int32.Parse(numericUpDown1.Value.ToString()) + 1);
                for (int a = 1; a < randomGroupNumber + 1; a++)
                {
                    my[a] = rastgele.Next(0, myMen.Length);
                    foradd = foradd + myMen[my[a]].LMS.ToString() + ";";
                    myMen[my[a]].IDsofGroups = myMen[my[a]].IDsofGroups + i.ToString() + ";";
                    myMen[my[a]].attempted++;
                    SMV[a] = myMen[my[a]].SMV;
                    float thisNum =  Vector3.Dot( myWomen[i].weightLMS,myMen[my[a]].LMS);
                    if (thisNum > maxVal)
                    {
                        maxVal = thisNum;
                        index = a;
                    }

                }
                myMen[my[index]].SexCount++;
                
                if (writeListbox)
                {
                    groupList.Items.Add("Women wLMS: "+ myWomen[i].weightLMS.ToString() +"MEN: " + foradd +"Max Value" + maxVal.ToString());
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
                   listbox.Items.Add("ID: " + i.ToString() + " Sex Count: " + myMen[i].SexCount.ToString() + " LMS: " + myMen[i].LMS.ToString());
                }
                //Progress Bar Code
                progressBar1.Maximum = myMen.Length;
                progressBar1.Value++;
            }
        }
        string[,] allLMSmen = new string[10, 10];
        //Topla Algoritmasi
        private void toplaf()
        {
            progressBar1.Value = 0;
            groupList.Items.Clear();
            int[] toplam = new int[11];
            int[] toplamPeople = new int[11];
            float[] avrSex = new float[11];
            int toplamSex = 0;
            Vector3[] toplamLMS = new Vector3[11];
            Vector3[] toplamPeopleLMS = new Vector3[11];
            Vector3[] avrSexLMS = new Vector3[11];
            
            for (int i = 0; i < myMen.Length; i++)
            {
                toplam[myMen[i].SMV] = toplam[myMen[i].SMV] + myMen[i].SexCount;
                toplamLMS[Convert.ToInt32(myMen[i].LMS.X)].X = toplamLMS[Convert.ToInt32(myMen[i].LMS.X)].X + myMen[i].SexCount;
                toplamLMS[Convert.ToInt32(myMen[i].LMS.Y)].Y = toplamLMS[Convert.ToInt32(myMen[i].LMS.Y)].Y + myMen[i].SexCount;
                toplamLMS[Convert.ToInt32(myMen[i].LMS.Z)].Z = toplamLMS[Convert.ToInt32(myMen[i].LMS.Z)].Z + myMen[i].SexCount;

                toplamPeople[myMen[i].SMV]++;
                toplamPeopleLMS[Convert.ToInt32(myMen[i].LMS.X)].X++;
                toplamPeopleLMS[Convert.ToInt32(myMen[i].LMS.Y)].Y++;
                toplamPeopleLMS[Convert.ToInt32(myMen[i].LMS.Z)].Z++;
                toplamSex = toplamSex + myMen[i].SexCount;
                //////////////Progress Bar Code
                progressBar1.Maximum = myMen.Length + toplamPeople.Length + toplam.Length;
                progressBar1.Value++;
            }
            for (int i = 1; i < toplamPeopleLMS.Length; i++)
            {
                groupList.Items.Add(toplamPeopleLMS[i].ToString());

                //////////////Progress Bar Code
                progressBar1.Value++;
            }
            groupList.Items.Add("AAAAAAAAAAAAAAA");
            for (int i = 0; i < toplamLMS.Length; i++)
            {
                groupList.Items.Add(i.ToString() + ";" + toplamLMS[i]);
                //////////////Progress Bar Code
                progressBar1.Value++;
            }
            groupList.Items.Add("AAAAAAAAAAA");
            groupList.Items.Add(toplamSex);
            groupList.Items.Add("AAAAAAAAAAA");
            for (int i = 1; i < toplam.Length; i++)
            {
                Vector3 a = toplamLMS[i];
                Vector3 b = toplamPeopleLMS[i];
                avrSexLMS[i].X = a.X / b.X;
                avrSexLMS[i].Y = a.Y / b.Y;
                avrSexLMS[i].Z = a.Z / b.Z;
                groupList.Items.Add(avrSexLMS[i].ToString());
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
            if(cmdLine.Text == "cal -sexn")
            {
                double totalSex = 0;
                double attemptedSex = 0;
                for(int i = 0; i < myMen.Length; i++)
                {
                    totalSex = totalSex +  Convert.ToDouble( myMen[i].SexCount);
                    attemptedSex =attemptedSex + Convert.ToDouble(myMen[i].attempted);
                }
                listbox.Items.Add("Total Sex: " + totalSex.ToString());
                listbox.Items.Add("Total Attempted: " + attemptedSex.ToString());
                double ratio = 100*totalSex / attemptedSex;
                listbox.Items.Add("Ratio: %" + ratio.ToString());
            }
            if(cmdLine.Text == "save -id -lms" || cmdLine.Text == "save -lms -id")
            {
                string[] ids = new string[myMen.Length];
                for (int i = 0; i < myMen.Length; i++)
                {
                    
                    ids[i] = i.ToString() + ";" + myMen[i].LMS.ToString() + ";" + myMen[i].SexCount.ToString()+";"+myMen[i].attempted.ToString()+";"+myMen[i].IDsofGroups;

                }
                SaveArayAsCSV(ids);
            }
            if (cmdLine.Text == "save -id -lms -al" || cmdLine.Text == "save -lms -id -al")
            {
                string[] ids = new string[myMen.Length+1];
                ids[0] = "ID;Looks;Money;Status;Sex Count;Sex Attempted;IDs";
                for (int i = 0; i < myMen.Length; i++)
                {

                    ids[i+1] = i.ToString() + ";" + myMen[i].LMS.X +";" + +myMen[i].LMS.Y +";" + +myMen[i].LMS.Z +";" + myMen[i].SexCount.ToString() + ";" + myMen[i].attempted.ToString() + ";" + myMen[i].IDsofGroups;

                }
                SaveArayAsCSV(ids);
            }
            if (cmdLine.Text == "save -id")
            {
                string[] ids = new string[myMen.Length];
                for(int i=0; i < myMen.Length; i++)
                {
                    ids[i] = myMen[i].IDsofGroups;
                }
                SaveArayAsCSV(ids);
                
            }
            if (cmdLine.Text == "save -lms")
            {
                string[] SMV = new string[myMen.Length + 1];
                SMV[0] = "ID;LMS;Sex Count";
                for (int i = 0; i < myMen.Length; i++)
                {
                    SMV[i + 1] = i.ToString() + ";" + myMen[i].LMS.ToString() + ";" + myMen[i].SexCount.ToString();
                }
                SaveArayAsCSV(SMV);
            }
            if (cmdLine.Text == "save -g")
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
        public Vector3 LMS {get; set;}
        public int attempted { get; set; }
        public string IDsofGroups { get; set; }
        public Men ()
        {
            SexCount = 0;
            SMV = 0;
            LMS = new Vector3(0, 0, 0);
            IDsofGroups = "";
            attempted = 0;
        }
        
                
    }
    public class Women
    {
        public Vector3 weightLMS { get; set; }
        public Women()
        {
            weightLMS = new Vector3(0, 0, 0);

        }


    }
   

}
