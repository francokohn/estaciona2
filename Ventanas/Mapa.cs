using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstacionamiento.Ventanas
{
    public partial class Mapa : Form
    {
        public Mapa()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(700, 151);
        }
        private Clases.BaseDeDatos BD = new Clases.BaseDeDatos();
        public void Base(Clases.BaseDeDatos b)
        {
            BD = b.Abrir();
        }
        public void colorear(int num)
        {

            switch (num)
            {
                case 1: P1.BackColor = Color.GreenYellow; break;
                case 2: P2.BackColor = Color.GreenYellow; break;
                case 3: P3.BackColor = Color.GreenYellow; break;
                case 4: P4.BackColor = Color.GreenYellow; break;
                case 5: P5.BackColor = Color.GreenYellow; break;
                case 6: P6.BackColor = Color.GreenYellow; break;
                case 7: P7.BackColor = Color.GreenYellow; break;
                case 8: P8.BackColor = Color.GreenYellow; break;
                case 9: P9.BackColor = Color.GreenYellow; break;
                case 10: P10.BackColor = Color.GreenYellow; break;
                case 11: P11.BackColor = Color.GreenYellow; break;
                case 12: P12.BackColor = Color.GreenYellow; break;
                case 13: P13.BackColor = Color.GreenYellow; break;
                case 14: P14.BackColor = Color.GreenYellow; break;
                case 15: P15.BackColor = Color.GreenYellow; break;
                case 16: P16.BackColor = Color.GreenYellow; break;
                case 17: P17.BackColor = Color.GreenYellow; break;
                case 18: P18.BackColor = Color.GreenYellow; break;
                case 19: P19.BackColor = Color.GreenYellow; break;
                case 20: P20.BackColor = Color.GreenYellow; break;
                case 21: P21.BackColor = Color.GreenYellow; break;
                case 22: P22.BackColor = Color.GreenYellow; break;
                case 23: P23.BackColor = Color.GreenYellow; break;
                case 24: P24.BackColor = Color.GreenYellow; break;
                case 25: P25.BackColor = Color.GreenYellow; break;
                case 26: P26.BackColor = Color.GreenYellow; break;
                case 27: P27.BackColor = Color.GreenYellow; break;
                case 28: P28.BackColor = Color.GreenYellow; break;
                case 29: P29.BackColor = Color.GreenYellow; break;
                case 30: P30.BackColor = Color.GreenYellow; break;
                case 31: P31.BackColor = Color.GreenYellow; break;
                case 32: P32.BackColor = Color.GreenYellow; break;
                case 33: P33.BackColor = Color.GreenYellow; break;
                case 34: P34.BackColor = Color.GreenYellow; break;
                case 35: P35.BackColor = Color.GreenYellow; break;
                case 36: P36.BackColor = Color.GreenYellow; break;
                case 37: P37.BackColor = Color.GreenYellow; break;
                case 38: P38.BackColor = Color.GreenYellow; break;
                case 39: P39.BackColor = Color.GreenYellow; break;
                case 40: P40.BackColor = Color.GreenYellow; break;
                case 41: P41.BackColor = Color.GreenYellow; break;
                case 42: P42.BackColor = Color.GreenYellow; break;
                case 43: P43.BackColor = Color.GreenYellow; break;
                case 44: P44.BackColor = Color.GreenYellow; break;
            }
        }

        private void P1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            
            tool.SetToolTip(P1, BuscarLugar(1));
        }
        private void P2_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P2, BuscarLugar(2));
        }
        private void P3_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P3, BuscarLugar(3));
        }
        private void P4_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P4, BuscarLugar(4));
        }
        private void P5_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P5, BuscarLugar(5));
        }
        private void P6_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P6, BuscarLugar(6));
        }
        private void P7_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P7, BuscarLugar(7));
        }
        private void P8_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P8, BuscarLugar(8));
        }
        private void P9_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P9, BuscarLugar(9));
        }
        private void P10_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P10, BuscarLugar(10));
        }
        private void P11_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P11, BuscarLugar(11));
        }
        private void P12_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P12, BuscarLugar(12));
        }
        private void P13_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P13, BuscarLugar(13));
        }
        private void P14_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P14, BuscarLugar(14));
        }
        private void P15_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P15, BuscarLugar(15));
        }
        private void P16_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P16, BuscarLugar(16));
        }
        private void P17_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P17, BuscarLugar(17));
        }
        private void P18_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P18, BuscarLugar(18));
        }
        private void P19_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P19, BuscarLugar(19));
        }
        private void P20_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P20, BuscarLugar(20));
        }
        private void P21_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P21, BuscarLugar(21));
        }
        private void P22_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P22, BuscarLugar(22));
        }
        private void P23_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P23, BuscarLugar(23));
        }
        private void P24_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P24, BuscarLugar(24));
        }
        private void P25_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P25, BuscarLugar(25));
        }
        private void P26_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P26, BuscarLugar(26));
        }
        private void P27_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P27, BuscarLugar(27));
        }
        private void P28_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P28, BuscarLugar(28));
        }
        private void P29_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P29, BuscarLugar(29));
        }
        private void P30_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P30, BuscarLugar(30));
        }
        private void P31_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P31, BuscarLugar(31));
        }
        private void P32_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P32, BuscarLugar(32));
        }
        private void P33_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P33, BuscarLugar(33));
        }
        private void P34_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P34, BuscarLugar(34));
        }
        private void P35_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P35, BuscarLugar(35));
        }
        private void P36_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P36, BuscarLugar(36));
        }
        private void P37_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P37, BuscarLugar(37));
        }
        private void P38_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P38, BuscarLugar(38));
        }
        private void P39_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P39, BuscarLugar(39));
        }
        private void P40_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P40, BuscarLugar(40));
        }
        private void P41_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P41, BuscarLugar(41));
        }
        private void P42_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P42, BuscarLugar(42));
        }
        private void P43_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P43, BuscarLugar(43));
        }
        private void P44_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();

            tool.SetToolTip(P44, BuscarLugar(44));
        }

        private string BuscarLugar(int num)
        {
            string aux = "";bool bande = true;
            for (int i = 0; i < BD.tarifas.Count && bande; i++)
            {
                if (BD.tarifas[i].Casillero == num )
                {
                    bande = false;
                    aux += BD.propietarios[i].Apellido+"\n";
                    aux += BD.propietarios[i].Nombre + "\n";
                    aux += BD.propietarios[i].Vehiculo.Patente + "\n";
                }
            }
            if (aux == "")
            {
                aux = "Disponible";
            }
            return aux;
        }
    }
}
