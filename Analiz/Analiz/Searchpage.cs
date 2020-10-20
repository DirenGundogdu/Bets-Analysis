using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analiz
{
    public partial class Searchpage : Form
    {
        public Searchpage()
        {
            InitializeComponent();
        }
        DataManager dm = new DataManager();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string var1, var2;
        private void button1_Click(object sender, EventArgs e)
        {
            var1 = comboBox1.Text;
            var2 = comboBox2.Text;
            dataGridView1.DataSource = null;
            if (var1 == "" || var2 == "")
            {
                MessageBox.Show("Lütfen iki seçeneğide doldurun");
                return;

            }
            if (var1 == "MaçSonucu1")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir,MacSonucu1,MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,KGVar from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,KGYok from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,IY15A from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,IY15U from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,AU15A from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,AU15U from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,AU25A from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,AU25U from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,AU35A from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,AU35U from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,TG01 from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,TG23 from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,TG46 from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu1,TG7 from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,TG7");
                }
            }
            else if (var1 == "MaçSonucuX")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, MacSonucuX, MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,KGVar from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,KGYok from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,IY15A from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,IY15U from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,AU15A from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,AU15U from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,AU25A from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,AU25U from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,AU35A from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,AU35U from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,TG01 from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,TG23 from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,TG46 from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucuX,TG7 from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,TG7");
                }
            }
            else if (var1 == "MaçSonucu2")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,KGVar from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,KGYok from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,IY15A from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,IY15U from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,AU15A from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,AU15U from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,AU25A from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,AU25U from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,AU35A from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,AU35U from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,TG01 from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,TG23 from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,TG46 from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,MacSonucu2,TG7 from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,TG7");
                }
            }

            else if (var1 == "IlkYari1")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,MacSonucu1 from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,MacSonucuX from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir,IYEvSahibi,IYMisafir, IlkYari1,MacSonucu2 from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1 from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,IlkYariX from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,IlkYari2 from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,KGVar from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,KGYok from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,CifteSans1X from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,CifteSans12 from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,CifteSansX2 from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,IY15A from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,IY15U from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,AU15A from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,AU15U from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,AU25A from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,AU25U from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,AU35A from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,AU35U from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,TG01 from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,TG23 from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,TG46 from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari1,TG7 from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir order by IlkYari1,TG7");
                }
            }
            else if (var1 == "IlkYariX")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,MacSonucu1 from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,MacSonucuX from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, IlkYariX,MacSonucu2 from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,IlkYari1 from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,IlkYari2 from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,KGVar from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,KGYok from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,CifteSans1X from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,CifteSans12 from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,CifteSansX2 from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,IY15A from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,IY15U from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,AU15A from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,AU15U from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,AU25A from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,AU25U from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,AU35A from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,AU35U from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,TG01 from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,TG23 from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,TG46 from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYariX,TG7 from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir order by IlkYariX,TG7");
                }
            }
            else if (var1 == "IlkYari2")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,MacSonucu1 from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,MacSonucuX from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir,IYEvSahibi,IYMisafir, IlkYari2,MacSonucu2 from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,IlkYari1 from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,IlkYariX from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2 from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,KGVar from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,KGYok from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,CifteSans1X from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,CifteSans12 from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,CifteSansX2 from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,IY15A from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,IY15U from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,AU15A from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,AU15U from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,AU25A from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,AU25U from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,AU35A from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,AU35U from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,TG01 from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,TG23 from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,TG46 from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,IYEvSahibi,IYMisafir,IlkYari2,TG7 from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir order by IlkYari2,TG7");
                }
            }
            else if (var1 == "KGVar")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, KGVar,MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,KGYok from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,IY15A from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,IY15U from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,AU15A from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,AU15U from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,AU25A from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,AU25U from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,AU35A from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,AU35U from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,TG01 from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,TG23 from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,TG46 from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGVar,TG7 from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 order by KGVar,TG7");
                }
            }
            else if (var1 == "KGYok")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,MacSonucu1 from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,MacSonucuX from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, KGYok,MacSonucu2 from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,IlkYari1 from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,IlkYariX from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,IlkYari2 from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,KGVar from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,CifteSans1X from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,CifteSans12 from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,CifteSansX2 from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,IY15A from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,IY15U from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,AU15A from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,AU15U from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,AU25A from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,AU25U from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,AU35A from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,AU35U from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,TG01 from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,TG23 from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,TG46 from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,KGYok,TG7 from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) order by KGYok,TG7");
                }
            }
            else if (var1 == "CifteSans1X")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,MacSonucu1 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,MacSonucuX from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, CifteSans1X,MacSonucu2 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,IlkYari1 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,IlkYariX from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,IlkYari2 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,KGVar from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,KGYok from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,CifteSans12 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,CifteSansX2 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,IY15A from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,IY15U from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,AU15A from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,AU15U from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,AU25A from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,AU25U from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,AU35A from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,AU35U from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,TG01 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,TG23 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,TG46 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans1X,TG7 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) order by CifteSans1X,TG7");
                }
            }
            else if (var1 == "CifteSans12")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,MacSonucu1 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,MacSonucuX from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, CifteSans12,MacSonucu2 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,IlkYari1 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,IlkYariX from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,IlkYari2 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,KGVar from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,KGYok from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,CifteSans1X from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,CifteSansX2 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,IY15A from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,IY15U from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,AU15A from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,AU15U from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,AU25A from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,AU25U from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,AU35A from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,AU35U from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,TG01 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,TG23 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,TG46 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSans12,TG7 from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSans12,TG7");
                }
            }
            else if (var1 == "CifteSansX2")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,MacSonucu1 from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,MacSonucuX from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, CifteSansX2,MacSonucu2 from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,IlkYari1 from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,IlkYariX from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,IlkYari2 from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,KGVar from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,KGYok from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,CifteSans1X from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,CifteSans12 from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2 from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,IY15A from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,IY15U from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,AU15A from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,AU15U from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,AU25A from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,AU25U from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,AU35A from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,AU35U from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,TG01 from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,TG23 from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,TG46 from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,CifteSansX2,TG7 from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) order by CifteSansX2,TG7");
                }
            }
            else if (var1 == "IY15A")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,MacSonucu1 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,MacSonucuX from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, IY15A,MacSonucu2 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,IlkYari1 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,IlkYariX from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,IlkYari2 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,KGVar from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,KGYok from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,CifteSans1X from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,CifteSans12 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,CifteSansX2 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,IY15U from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,AU15A from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,AU15U from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,AU25A from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,AU25U from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,AU35A from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,AU35U from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,TG01 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,TG23 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,TG46 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15A,TG7 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,TG7");
                }
            }
            else if (var1 == "IY15U")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,MacSonucu1 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,MacSonucuX from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, IY15U,MacSonucu2 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,IlkYari1 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,IlkYariX from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,IlkYari2 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,KGVar from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,KGYok from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,CifteSans1X from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,CifteSans12 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,CifteSansX2 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,IY15A from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,AU15A from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,AU15U from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,AU25A from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,AU25U from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,AU35A from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,AU35U from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,TG01 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,TG23 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,TG46 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,IY15U,TG7 from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 order by IY15U,TG7");
                }
            }
            else if (var1 == "AU15A")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, AU15A,MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,KGVar from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,KGYok from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,IY15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,IY15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,AU15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,AU25A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,AU25U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,AU35A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,AU35U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,TG01 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,TG23 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,TG46 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15A,TG7 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 order by AU15A,TG7");
                }
            }
            else if (var1 == "AU15U")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, AU15U,MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,KGVar from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,KGYok from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,IY15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,IY15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,AU15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,AU25A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,AU25U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,AU35A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,AU35U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,TG01 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,TG23 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,TG46 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU15U,TG7 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 order by AU15U,TG7");
                }
            }
            else if (var1 == "AU25A")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, AU25A,MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,KGVar from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,KGYok from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,IY15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,IY15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,AU15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,AU15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,AU25U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,AU35A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,AU35U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,TG01 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,TG23 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,TG46 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25A,TG7 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 order by AU25A,TG7");
                }
            }
            else if (var1 == "AU25U")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, AU25U,MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,KGVar from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,KGYok from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,IY15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,IY15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,AU15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,AU15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,AU25A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,AU35A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,AU35U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,TG01 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,TG23 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,TG46 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU25U,TG7 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,TG7");
                }
            }
            else if (var1 == "AU35A")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, AU35A,MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,KGVar from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,KGYok from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,IY15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,IY15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,AU15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,AU15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,AU25A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,AU25U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,AU35U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,TG01 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,TG23 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,TG46 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35A,TG7 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,TG7");
                }
            }
            else if (var1 == "AU35U")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, AU35U,MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,KGVar from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,KGYok from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,IY15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,IY15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,AU15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,AU15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,AU25A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,AU25U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,AU35A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,TG01 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,TG23 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,TG46 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,AU35U,TG7 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,TG7");
                }
            }
            else if (var1 == "TG01")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, TG01,MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,KGVar from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,KGYok from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,IY15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,IY15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,AU15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,AU15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,AU25A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,AU25U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,AU35A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,AU35U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,TG23 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,TG46 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG01,TG7 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,TG7");
                }
            }
            else if (var1 == "TG23")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, TG23,MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,KGVar from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,KGYok from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,IY15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,IY15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,AU15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,AU15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,AU25A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,AU25U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,AU35A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,AU35U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,TG01 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,TG46 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG23,TG7 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,TG7");
                }
            }
            else if (var1 == "TG46")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, TG46,MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,KGVar from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,KGYok from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,IY15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,IY15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,AU15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,AU15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,AU25A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,AU25U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,AU35A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,AU35U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,TG01 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,TG23 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG46,TG7 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 order by TG46,TG7");
                }
            }
            else if (var1 == "TG7")
            {
                if (var2 == "MaçSonucu1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,MacSonucu1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,MaçSonucu1");
                }
                else if (var2 == "MaçSonucuX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,MacSonucuX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,MaçSonucuX");
                }
                else if (var2 == "MaçSonucu2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi, Misafir, MSEvsahibi, MSMisafir, TG7,MacSonucu2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,MaçSonucu2");
                }
                else if (var2 == "IlkYari1")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,IlkYari1 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,IlkYari1");
                }
                else if (var2 == "IlkYariX")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,IlkYariX from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,IlkYariX");
                }
                else if (var2 == "IlkYari2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,IlkYari2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,IlkYari2");
                }
                else if (var2 == "KGVar")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,KGVar from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,KGVar");
                }
                else if (var2 == "KGYok")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,KGYok from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,KGYok");
                }
                else if (var2 == "CifteSans1X")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,CifteSans1X from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,CifteSans1X");
                }
                else if (var2 == "CifteSans12")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,CifteSans12 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,CifteSans12");
                }
                else if (var2 == "CifteSansX2")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,CifteSansX2 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,CifteSansX2");
                }
                else if (var2 == "IY15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,IY15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,IY15A");
                }
                else if (var2 == "IY15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,IY15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,IY15U");
                }
                else if (var2 == "AU15A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,AU15A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,AU15A");
                }
                else if (var2 == "AU15U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,AU15U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,AU15U");
                }
                else if (var2 == "AU25A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,AU25A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,AU25A");
                }
                else if (var2 == "AU25U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,AU25U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,AU25U");
                }
                else if (var2 == "AU35A")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,AU35A from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,AU35A");
                }
                else if (var2 == "AU35U")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,AU35U from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,AU35U");
                }
                else if (var2 == "TG01")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,TG01 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,TG01");
                }
                else if (var2 == "TG23")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,TG23 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,TG23");
                }
                else if (var2 == "TG46")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7,TG46 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,TG46");
                }
                else if (var2 == "TG7")
                {
                    dataGridView1.DataSource = dm.ExecuteDataTable("select EvSahibi,Misafir,MSEvsahibi,MSMisafir,TG7 from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7");
                }
            }

        }
    }
}
