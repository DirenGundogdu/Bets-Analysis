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
    public partial class Graphpage : Form
    {
        public Graphpage()
        {
            InitializeComponent();
        }
        DataManager dm = new DataManager();
        DataTable dt = new DataTable();
        private void Form2_Load(object sender, EventArgs e) { }
        string var1;
        string var2;
        private void button1_Click(object sender, EventArgs e)
        {
            var1 = comboBox1.Text;
            var2 = comboBox2.Text;
            if (var1 == "MacSonucu1")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi > MSMisafir  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "MaçSonucuX")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi = MSMisafir  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "MaçSonucu2")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi < MSMisafir  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "IlkYari1")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where IYEvSahibi > IYMisafir  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "IlkYariX")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where IYEvSahibi = IYMisafir  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "IlkYari2")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where IYEvSahibi < IYMisafir  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "KGVar")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi > 0 AND MSMisafir > 0  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "KGYok")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0) group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where (MSEvsahibi+MSMisafir=0) or (MSEvsahibi>0 and MSMisafir=0) or (MSEvsahibi=0 and MSMisafir>0)  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "CifteSans1X")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir) group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi = MSMisafir)  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "CifteSans12")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir) group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where (MSEvsahibi > MSMisafir) or (MSEvsahibi < MSMisafir)  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "CifteSansX2")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir) group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where (MSEvsahibi = MSMisafir) or (MSEvsahibi < MSMisafir)  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "IY15A")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir < 2  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "IY15U")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where IYEvSahibi + IYMisafir > 1  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "AU15A")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 2  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "AU15U")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "AU25A")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 3  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "AU25U")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 2  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "AU35A")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir < 4  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "AU35U")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "TG01")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir = 0 and MSEvsahibi + MSMisafir < 2  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "TG23")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 1 and MSEvsahibi + MSMisafir < 4  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "TG46")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 3 and MSEvsahibi + MSMisafir < 7  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }
            else if (var1 == "TG7")
            {
                if (var2 == "MaçSonucu1")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu1 ,COUNT(MacSonucu1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 group by MacSonucu1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                else if (var2 == "MaçSonucuX")
                {
                    dt = dm.ExecuteDataTable("select MacSonucuX, COUNT(MacSonucuX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 group by MacSonucuX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucuX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "MaçSonucu2")
                {
                    dt = dm.ExecuteDataTable("select MacSonucu2, COUNT(MacSonucu2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 group by MacSonucu2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "MacSonucu2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari1")
                {
                    dt = dm.ExecuteDataTable("select IlkYari1, COUNT(IlkYari1) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by IlkYari1");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari1";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYariX")
                {
                    dt = dm.ExecuteDataTable("select IlkYariX,COUNT(IlkYariX) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by IlkYariX");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYariX";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IlkYari2")
                {
                    dt = dm.ExecuteDataTable("select IlkYari2, COUNT(IlkYari2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by IlkYari2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IlkYari2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGVar")
                {
                    dt = dm.ExecuteDataTable("select KGVar, COUNT(KGVar) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by KGVar");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGVar";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "KGYok")
                {
                    dt = dm.ExecuteDataTable("select KGYok, COUNT(KGYok) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by KGYok");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "KGYok";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans1X")
                {
                    dt = dm.ExecuteDataTable("select CifteSans1X, COUNT(CifteSans1X) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by CifteSans1X");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans1X";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSans12")
                {
                    dt = dm.ExecuteDataTable("select CifteSans12, COUNT(CifteSans12) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 group by CifteSans12");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSans12";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "CifteSansX2")
                {
                    dt = dm.ExecuteDataTable("select CifteSansX2, COUNT(CifteSansX2) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 group by CifteSansX2");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "CifteSansX2";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15A")
                {
                    dt = dm.ExecuteDataTable("select IY15A, COUNT(IY15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7 group by IY15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "IY15U")
                {
                    dt = dm.ExecuteDataTable("select IY15U,COUNT(IY15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by IY15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "IY15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15A")
                {
                    dt = dm.ExecuteDataTable("select AU15A,COUNT(AU15A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by AU15A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU15U")
                {
                    dt = dm.ExecuteDataTable("select AU15U,COUNT(AU15U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by AU15U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU15U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25A")
                {
                    dt = dm.ExecuteDataTable("select AU25A,COUNT(AU25A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by AU25A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU25U")
                {
                    dt = dm.ExecuteDataTable("select AU25U,COUNT(AU25U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by AU25U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU25U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35A")
                {
                    dt = dm.ExecuteDataTable("select AU35A,COUNT(AU35A) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by AU35A");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35A";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "AU35U")
                {
                    dt = dm.ExecuteDataTable("select AU35U,COUNT(AU35U) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by AU35U");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "AU35U";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG01")
                {
                    dt = dm.ExecuteDataTable("select TG01,COUNT(TG01) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by TG01");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG01";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG23")
                {
                    dt = dm.ExecuteDataTable("select TG23,COUNT(TG23) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by TG23");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG23";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG46")
                {
                    dt = dm.ExecuteDataTable("select TG46,COUNT(TG46) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by TG46");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG46";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
                else if (var2 == "TG7")
                {
                    dt = dm.ExecuteDataTable("select TG7,COUNT(TG7) as T from Mac_Oranları_Tablo where MSEvsahibi + MSMisafir > 7  group by TG7");
                    chart1.DataSource = dt;


                    chart1.Series["Series1"].XValueMember = "TG7";
                    chart1.Series["Series1"].YValueMembers = "T";
                    chart1.Series["Series1"].LabelToolTip = chart1.Series["Series1"].XValueMember;
                    chart1.ChartAreas[0].AxisX.Interval = 1;

                }
            }



        }
    }
}
