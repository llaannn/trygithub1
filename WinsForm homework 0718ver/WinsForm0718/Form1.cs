using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinsForm0718
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init();
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker2.Visible = false;
            this.lbls.Visible = false;
            this.lble.Visible = false;
            this.Alldays.Visible = false;
        }

        private void radyear_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker2.Visible = false;
        }
        private void radpart_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Visible = true;
            this.dateTimePicker2.Visible = true;
            this.lbls.Visible = true;
            this.lble.Visible = true;
            this.Alldays.Visible = true;
        }
        private void radpart_Click(object sender, EventArgs e)
        {
            this.dateTimePicker1.Visible = true;
            this.dateTimePicker2.Visible = true;

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Init();
        }


        private void btnCalculator_Click(object sender, EventArgs e)
        {
            //this.cbxCar_Click();
       

            if (radyear.Checked)
            {


                this.Ans();

                
                //bool isLeapYear = DateTime.IsLeapYear(DateTime.Now.Year);
                //int luneYear;

                //if (DateTime.IsLeapYear(DateTime.Now.Year))
                //{
                //    luneYear = 366;
                //}
                //else
                //{
                //    luneYear = 365;
                //}


                //DateTime startDate = new DateTime(2021, 1, 1);
                //DateTime endtDate = new DateTime(2022, 1, 1);
                //(endtDate - startDate).Days.ToString();



                //這邊要記得加警語
                //this.lbls.Text = "已選取:" +
                //this.dateTimePicker1.Value.ToString("2021/01/01");
                //this.lble.Text = "已選取:" +
                //this.dateTimePicker1.Value.ToString("2022/12/31");
                //Alldays.Text = "365天";

                //this.AllResult.Text = "使用期間:" + startDate.ToString("yyyy/MM/dd") + "~" + endtDate.ToString("yyyy/MM/dd")
                //             + Environment.NewLine
                //             + "所有天數" + Convert.ToInt32(newDate).ToString() + "天"
                //             + Environment.NewLine
                //             + "用途:" + this.cbxCar.SelectedItem as String
                //             + Environment.NewLine
                //             + "用途:" + this.cbxgasbic.SelectedItem as String
                //             + Environment.NewLine;
            }
            else if (radpart.Checked)
            {
                this.lbls.Text = "已選取:" +
                this.dateTimePicker1.Value.ToString("yyyy/MM/dd");
                this.lble.Text = "已選取:" +
                this.dateTimePicker2.Value.ToString("yyyy/MM/dd");


                DateTime sDatep = Convert.ToDateTime(dateTimePicker1.Value);
                DateTime eDatep = Convert.ToDateTime(dateTimePicker2.Value);



                TimeSpan ts = eDatep - sDatep;

                int days = (int)ts.TotalDays + 1;

                Alldays.Text = "所有天數" + Convert.ToInt32(days).ToString() + "天";



                var taxAns = this.GetTax();
                decimal result = taxAns * Convert.ToInt32(days) / 366;
                String taxend = this.cbxCar.SelectedItem.ToString();



                if (taxend == "機車")

                    this.AllResult.Text = "使用期間:" + sDatep.ToString("yyyy/MM/dd") + "~" + eDatep.ToString("yyyy/MM/dd")
                                         + Environment.NewLine
                                         + "所有天數" + Convert.ToInt32(days).ToString() + "天"
                                         + Environment.NewLine
                                         + "用途:" + this.cbxCar.SelectedItem as String
                                         + Environment.NewLine
                                         + "規格:" + this.cbxgasbic.SelectedItem as String
                                         + Environment.NewLine;
                //+ "計算方式:"{ taxAns.ToString()} *{ days.ToString} = { result.("#,0")}"元"
                ////+ Environment.NewLine


                else if (taxend == "貨車")
                {
                    this.AllResult.Text = "使用期間:" + sDatep.ToString("yyyy/MM/dd") + "~" + eDatep.ToString("yyyy/MM/dd")
                                     + Environment.NewLine
                                     + "所有天數" + Convert.ToInt32(days).ToString() + "天"
                                     + Environment.NewLine
                                     + "用途:" + this.cbxCar.SelectedItem as String
                                     + Environment.NewLine
                                     + "規格:" + this.cbxtruck.SelectedItem as String
                                     + Environment.NewLine;
                }


                else if (taxend == "大客車")
                {
                    this.AllResult.Text = "使用期間:" + sDatep.ToString("yyyy/MM/dd") + "~" + eDatep.ToString("yyyy/MM/dd")
                                     + Environment.NewLine
                                     + "所有天數" + Convert.ToInt32(days).ToString() + "天"
                                     + Environment.NewLine
                                     + "用途:" + this.cbxCar.SelectedItem as String
                                     + Environment.NewLine
                                     + "規格:" + this.cbxbus.SelectedItem as String
                                     + Environment.NewLine;
                }

                else if (taxend == "自用小客車")
                {
                    this.AllResult.Text = "使用期間:" + sDatep.ToString("yyyy/MM/dd") + "~" + eDatep.ToString("yyyy/MM/dd")
                                     + Environment.NewLine
                                     + "所有天數" + Convert.ToInt32(days).ToString() + "天"
                                     + Environment.NewLine
                                     + "用途:" + this.cbxCar.SelectedItem as String
                                     + Environment.NewLine
                                     + "規格:" + this.cbxcari.SelectedItem as String
                                     + Environment.NewLine;
                }

                else if (taxend == "營業用小客車")
                {
                    this.AllResult.Text = "使用期間:" + sDatep.ToString("yyyy/MM/dd") + "~" + eDatep.ToString("yyyy/MM/dd")
                                     + Environment.NewLine
                                     + "所有天數" + Convert.ToInt32(days).ToString() + "天"
                                     + Environment.NewLine
                                     + "用途:" + this.cbxCar.SelectedItem as String
                                     + Environment.NewLine
                                     + "規格:" + this.cbxcarb.SelectedItem as String
                                     + Environment.NewLine;
                }




            }




        }

        //private double cbxCar_Click()
        //{
        //    double perc =
        //    if (perc == 0)
        //    {
        //        this.cbxCar.Text = "請輸入選項";


        //    }
        //    return = "請輸入選項";
        //}

        #region
        private void cbxCar_SelectedIndexChanged(object sender, EventArgs e)
        {

            var carlist = this.cbxCar.SelectedItem.ToString();

            if (carlist == "機車")
            {
                cbxgasbic.Visible = true;
                cbxtruck.Visible = false;
                cbxbus.Visible = false;
                cbxcari.Visible = false;
                cbxcarb.Visible = false;
            }
            else if (carlist == "貨車")
            {
                cbxgasbic.Visible = false;
                cbxtruck.Visible = true;
                cbxbus.Visible = false;
                cbxcari.Visible = false;
                cbxcarb.Visible = false;
            }
            else if (carlist == "大客車")
            {
                cbxgasbic.Visible = false;
                cbxtruck.Visible = false;
                cbxbus.Visible = true;
                cbxcari.Visible = false;
                cbxcarb.Visible = false;
            }
            else if (carlist == "自用小客車")
            {
                cbxgasbic.Visible = false;
                cbxtruck.Visible = false;
                cbxbus.Visible = false;
                cbxcari.Visible = true;
                cbxcarb.Visible = false;
            }
            else if (carlist == "營業用小客車")
            {
                cbxgasbic.Visible = false;
                cbxtruck.Visible = false;
                cbxbus.Visible = false;
                cbxcari.Visible = false;
                cbxcarb.Visible = true;
            }




        }



        private void Init()//重設的方法
        {
            this.lbls.Text = "0";
            this.lble.Text = "0";
            this.lbls.Visible = false;
            this.lble.Visible = false;
            this.Alldays.Visible = false;

            this.dateTimePicker1.Visible = false;
            this.dateTimePicker2.Visible = false;
            this.AllResult.Text = "0";


        }
        private decimal GetTax()
        {

            var alltax = this.cbxCar.SelectedItem;

            switch (alltax)
            {
                case "機車":
                    var chbike = this.cbxgasbic.SelectedItem;
                    int[] arrbike = { 0, 800, 1620, 2160, 4320, 11230 };

                    switch (chbike)
                    {
                        case 0:
                            return arrbike[0];
                        case 1:
                            return arrbike[1];
                        case 2:
                            return arrbike[2];
                        case 3:
                            return arrbike[3];
                        case 4:
                            return arrbike[4];
                        case 5:
                            return arrbike[5];
                        case 6:
                            return arrbike[6];
                        default:
                            return 0;
                    }

                case "貨車":
                    var chtruck = this.cbxtruck.SelectedItem;
                    int[] arrtruck = { 0, 800, 1620, 2160, 4320, 11230 };

                    switch (chtruck)
                    {
                        case 0:
                            return arrtruck[0];
                        case 1:
                            return arrtruck[1];
                        case 2:
                            return arrtruck[2];
                        case 3:
                            return arrtruck[3];
                        case 4:
                            return arrtruck[4];
                        case 5:
                            return arrtruck[5];
                        case 6:
                            return arrtruck[6];
                        default:
                            return 0;
                    }

                case "大客車":
                    var chbus = this.cbxtruck.SelectedItem;
                    int[] arrbus = { 0, 800, 1620, 2160, 4320, 11230 };

                    switch (chbus)
                    {
                        case 0:
                            return arrbus[0];
                        case 1:
                            return arrbus[1];
                        case 2:
                            return arrbus[2];
                        case 3:
                            return arrbus[3];
                        case 4:
                            return arrbus[4];
                        case 5:
                            return arrbus[5];
                        case 6:
                            return arrbus[6];
                        default:
                            return 0;
                    }

                case "自用小客車":
                    var chcbxcari = this.cbxtruck.SelectedItem;
                    int[] arrcbxcari = { 0, 800, 1620, 2160, 4320, 11230 };

                    switch (chcbxcari)
                    {
                        case 0:
                            return arrcbxcari[0];
                        case 1:
                            return arrcbxcari[1];
                        case 2:
                            return arrcbxcari[2];
                        case 3:
                            return arrcbxcari[3];
                        case 4:
                            return arrcbxcari[4];
                        case 5:
                            return arrcbxcari[5];
                        case 6:
                            return arrcbxcari[6];
                        default:
                            return 0;
                    }

                case "營業用用小客車":
                    var chcbxcarb = this.cbxtruck.SelectedItem;
                    int[] arrcbxcarb = { 0, 800, 1620, 2160, 4320, 11230 };

                    switch (chcbxcarb)
                    {
                        case 0:
                            return arrcbxcarb[0];
                        case 1:
                            return arrcbxcarb[1];
                        case 2:
                            return arrcbxcarb[2];
                        case 3:
                            return arrcbxcarb[3];
                        case 4:
                            return arrcbxcarb[4];
                        case 5:
                            return arrcbxcarb[5];
                        case 6:
                            return arrcbxcarb[6];
                        default:
                            return 0;
                    }
            }
            return 0;



        }

        private void cbxgasbic_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }


        private void Ans()
        {
            if (radyear.Checked)
            {
                bool isLeapYear = DateTime.IsLeapYear(DateTime.Now.Year);
                int luneYear;

                if (DateTime.IsLeapYear(DateTime.Now.Year))
                {
                    luneYear = 366;
                }
                else
                {
                    luneYear = 365;
                }


                DateTime startDate = new DateTime(2021, 1, 1);
                DateTime endtDate = new DateTime(2022, 1, 1);
                //(endtDate - startDate).Days.ToString();
                TimeSpan daycut = endtDate - startDate;







                var taxAns = this.GetTax();
                decimal result = taxAns * Convert.ToInt32(Alldays) / Convert.ToInt32(luneYear);
                String taxend = this.cbxCar.SelectedItem.ToString();



                if (taxend == "機車")
                {
                    this.AllResult.Text = "使用期間:" + startDate.ToString("yyyy/MM/dd") + "~" + endtDate.ToString("yyyy/MM/dd")
                                         + Environment.NewLine
                                         + "所有天數" + Convert.ToInt32(Alldays).ToString() + "天"
                                         + Environment.NewLine
                                         + "用途:" + this.cbxCar.SelectedItem as String
                                         + Environment.NewLine
                                         + "規格:" + this.cbxgasbic.SelectedItem as String
                                         + Environment.NewLine
                                         + $"計算方式:{ taxAns.ToString()}*{ Alldays.ToString()} / { luneYear.ToString()} = { result.ToString("#,0")} 元"
                                         + Environment.NewLine
                                         + "應繳稅額:{ result.ToString(#,0)}元";

                }
                else if (taxend == "貨車")
                {
                    this.AllResult.Text = "使用期間:" + startDate.ToString("yyyy/MM/dd") + "~" + endtDate.ToString("yyyy/MM/dd")
                                     + Environment.NewLine
                                     + "所有天數" + Convert.ToInt32(Alldays).ToString() + "天"
                                     + Environment.NewLine
                                     + "用途:" + this.cbxCar.SelectedItem as String
                                     + Environment.NewLine
                                     + "規格:" + this.cbxtruck.SelectedItem as String
                                     + Environment.NewLine;
                }


                else if (taxend == "大客車")
                {
                    this.AllResult.Text = "使用期間:" + startDate.ToString("yyyy/MM/dd") + "~" + endtDate.ToString("yyyy/MM/dd")
                                     + Environment.NewLine
                                     + "所有天數" + Convert.ToInt32(Alldays).ToString() + "天"
                                     + Environment.NewLine
                                     + "用途:" + this.cbxCar.SelectedItem as String
                                     + Environment.NewLine
                                     + "規格:" + this.cbxbus.SelectedItem as String
                                     + Environment.NewLine;
                }

                else if (taxend == "自用小客車")
                {
                    this.AllResult.Text = "使用期間:" + startDate.ToString("yyyy/MM/dd") + "~" + endtDate.ToString("yyyy/MM/dd")
                                     + Environment.NewLine
                                     + "所有天數" + Convert.ToInt32(Alldays).ToString() + "天"
                                     + Environment.NewLine
                                     + "用途:" + this.cbxCar.SelectedItem as String
                                     + Environment.NewLine
                                     + "規格:" + this.cbxcari.SelectedItem as String
                                     + Environment.NewLine;
                }

                else if (taxend == "營業用小客車")
                {
                    this.AllResult.Text = "使用期間:" + startDate.ToString("yyyy/MM/dd") + "~" + endtDate.ToString("yyyy/MM/dd")
                                     + Environment.NewLine
                                     + "所有天數" + Convert.ToInt32(Alldays).ToString() + "天"
                                     + Environment.NewLine
                                     + "用途:" + this.cbxCar.SelectedItem as String
                                     + Environment.NewLine
                                     + "規格:" + this.cbxcarb.SelectedItem as String
                                     + Environment.NewLine;
                }
            }
        } } }
        
           



        #endregion

        //日期原來的寫法
        //DateTime sDatep = Convert.ToDateTime(dateTimePicker1.Value);
        //DateTime eDatep = Convert.ToDateTime(dateTimePicker2.Value);
        ////記得用if做s-e的方式回頭做
        //TimeSpan ts = eDatep - sDatep;
        //int days = (int)ts.TotalDays + 1;
        //Alldays.Text = "所有天數" + Convert.ToInt32(days).ToString() + "天";

        ////bool isLeapYear = DateTime.IsLeapYear(DateTime.Now.Year); 



        // bool isLeapYear = DateTime.IsLeapYear(DateTime.Now.Year);//查證是否為閏年 


        //記得用if做s-e的方式回頭做 




        //private double GetTax()
        //{
        //    if (this.comboxType.SelectedIndex == 1)
        //    {
        //        return 0;
        //    }
        //    string taxType = this.comboxType.Text;


        //if (taxType=="機車")
        //{
        //    return;
        //}
        //else if(taxType =="貨車||大客車||自用小客車||營業用小客車")
        //{
        //    return;
        //}
        //else
    


