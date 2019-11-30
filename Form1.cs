using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorguOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime zaman = DateTime.Now;
        int yil1 = 0, ay1 = 0, gun1 = 0, yil2 = 0, ay2 = 0, gun2 = 0, sonucYil = 0, sonucAy = 0, sonucGun = 0;


        private void btnTarihBugun_Click(object sender, EventArgs e)
        {

            yil1 = zaman.Year;
            ay1 = zaman.Month;
            gun1 = zaman.Day;

            txtYil.Text = yil1.ToString();
            txtAy.Text = ay1.ToString();
            txtGun.Text = gun1.ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            yil2 = Convert.ToInt16(txtYil2.Text);
            ay2 = Convert.ToInt16(txtAy2.Text);
            gun2 = Convert.ToInt16(txtGun2.Text);


            if (txtYil.Text == "" || txtAy.Text == "" || txtGun.Text == "" || txtYil2.Text == "" || txtAy2.Text == "" || txtGun2.Text == "")
            {
                MessageBox.Show("Alanlar boş geçilemez!");
                return;
            }
            if (yil1 >= yil2)
            {
                if (gun1 >= gun2)
                {

                    sonucGun = gun1 - gun2;

                }
                else
                {
                    if (ay1 == ay2)
                    {
                        sonucGun = gun2 - gun1;
                    }
                    else
                    {
                        ay1--;
                        gun1 += 30;
                        sonucGun = gun1 - gun2;
                    }

                }


                if (ay1 >= ay2)
                {
                    sonucAy = ay1 - ay2;
                }
                else
                {
                    yil1--;
                    ay1 += 12;
                    sonucAy = ay1 - ay2;

                }

                sonucYil = yil1 - yil2;
            }
            else
            {
                if (gun2 >= gun1)
                {
                    sonucGun = gun2 - gun1;
                }
                else
                {
                    ay2--;
                    gun2 += 30;
                    sonucGun = gun2 - gun1;
                }
                if (ay2 >= ay1)
                {
                    sonucAy = ay2 - ay1;
                }
                else
                {
                    yil2--;
                    ay2 += 12;
                    sonucAy = ay2 - ay1;

                }

                sonucYil = yil2 - yil1;

            }

            lblYil.Text = sonucYil.ToString();
            lblAy.Text = sonucAy.ToString();
            lblGun.Text = sonucGun.ToString();

        }
    }
}
