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
    public partial class Winlist : Form
    {
        public Winlist()
        {
            InitializeComponent();
        }
        DataManager dm = new DataManager();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string var1;
        private void button1_Click(object sender, EventArgs e)
        {
            var1 = comboBox1.Text;
            if (var1 == "MaçSonucu1")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir order by MacSonucu1,MacSonucuX,MacSonucu2");
            }
            else if (var1 == "MaçSonucuX")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir order by MacSonucuX,MacSonucu1,MacSonucu2");
            }
            else if (var1 == "MaçSonucu2")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir order by MacSonucu2,MacSonucu1,MacSonucuX");
            }
            else if (var1 == "IlkYari1")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  order by IlkYari1,IlkYariX,IlkYari2");
            }
            else if (var1 == "IlkYariX")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  order by IlkYariX,IlkYari1,IlkYari2");
            }
            else if (var1 == "IlkYari2")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  order by IlkYari2,IlkYari1,IlkYariX");
            }
            else if (var1 == "KGVar")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  order by KGVar,KGYok");
            }
            else if (var1 == "KGYok")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  order by KGYok,KGVar");
            }
            else if (var1 == "CifteSans1X")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  order by CifteSans1X,CifteSans12,CifteSansX2");
            }
            else if (var1 == "CifteSans12")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  order by CifteSans12,CifteSans1X,CifteSansX2");
            }
            else if (var1 == "CifteSansX2")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  order by CifteSansX2,CifteSans1X,CifteSans12");
            }
            else if (var1 == "IY15A")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 order by IY15A,IY15U");
            }
            else if (var1 == "IY15U")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  order by IY15U,IY15A");
            }
            else if (var1 == "AU15A")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir <2 order by AU15A,AU15U");
            }
            else if (var1 == "AU15U")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir >1 order by AU15U,AU15A");
            }
            else if (var1 == "AU25A")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir <3 order by AU25A,AU25U");
            }
            else if (var1 == "AU25U")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 order by AU25U,AU25A");
            }
            else if (var1 == "AU35A")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 order by AU35A,AU35U");
            }
            else if (var1 == "AU35U")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 order by AU35U,AU35A");
            }
            else if (var1 == "TG01")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 order by TG01,TG23,TG46,TG7");
            }
            else if (var1 == "TG23")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 order by TG23,TG01,TG46,TG7");
            }
            else if (var1 == "TG46")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  order by TG46,TG01,TG23,TG7");
            }
            else if (var1 == "TG7")
            {
                dataGridView1.DataSource = dm.ExecuteDataTable("select * from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 order by TG7,TG01,TG23,TG46");
            }


        }
    }
}
