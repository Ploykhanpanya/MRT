using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void startMRT_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region startMRT
            startMRT.Items.Add("คลองบางไผ่");
            startMRT.Items.Add("ตลาดบางใหญ่");
            startMRT.Items.Add("สามแยกบางใหญ่");
            startMRT.Items.Add("บางพลู");
            startMRT.Items.Add("บางรักใหญ่");
            startMRT.Items.Add("บางรักน้อยท่าอิฐ");
            startMRT.Items.Add("ไทรม้า");
            startMRT.Items.Add("สะพานพระนั่งเกล้า");
            startMRT.Items.Add("แยกนนทบุรี 1");
            startMRT.Items.Add("บางกระสอ");
            startMRT.Items.Add("ศูนย์ราชการนนทบุรี");
            startMRT.Items.Add("กระทรวงสาธารณสุข");
            startMRT.Items.Add("แยกติวานนท์");
            startMRT.Items.Add("วงศ์สว่าง");
            startMRT.Items.Add("บางซ่อน");
            startMRT.Items.Add("เตาปูน");
            #endregion

            #region endMRT
            endMRT.Items.Add("คลองบางไผ่");
            endMRT.Items.Add("ตลาดบางใหญ่");
            endMRT.Items.Add("สามแยกบางใหญ่");
            endMRT.Items.Add("บางพลู");
            endMRT.Items.Add("บางรักใหญ่");
            endMRT.Items.Add("บางรักน้อยท่าอิฐ");
            endMRT.Items.Add("ไทรม้า");
            endMRT.Items.Add("สะพานพระนั่งเกล้า");
            endMRT.Items.Add("แยกนนทบุรี 1");
            endMRT.Items.Add("บางกระสอ");
            endMRT.Items.Add("ศูนย์ราชการนนทบุรี");
            endMRT.Items.Add("กระทรวงสาธารณสุข");
            endMRT.Items.Add("แยกติวานนท์");
            endMRT.Items.Add("วงศ์สว่าง");
            endMRT.Items.Add("บางซ่อน");
            endMRT.Items.Add("เตาปูน");
            #endregion
        }

        private void calMRT_Click(object sender, EventArgs e)
        {
            #region คลองบางไผ่
            if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "คลองบางไผ่") 
            {
               double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "บางพลู")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "ไทรม้า")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 36, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "บางกระสอ")
            {
                double pice = 38, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 40, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "22";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "24";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "26";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "บางซ่อน")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "28";
            }

            else if (startMRT.Text == "คลองบางไผ่" && endMRT.Text == "เตาปูน")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "30";
            }

            #endregion

            #region เตาปูน

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "เตาปูน")
            {
                double pice = 16, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "บางซ่อน")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "บางกระสอ")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 36, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "ไทรม้า")
            {
                double pice = 38, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 40, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "22";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "บางพลู")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "24";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "26";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "28";
            }

            else if (startMRT.Text == "เตาปูน" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "30";
            }
            #endregion

            #region ตลาดบางใหญ่บ้านคนสวยคิคิ

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if(startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "บางพลู")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "ไทรม้า")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "บางกระสอ")
            {
                double pice = 36, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 38, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 40, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "22";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "24";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "บางซ่อน")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "26";
            }

            else if (startMRT.Text == "ตลาดบางใหญ่" && endMRT.Text == "เตาปูน")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "28";
            }

            #endregion

            #region บางซ่อน

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "เตาปูน")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "บางซ่อน")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "บางกระสอ")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "ไทรม้า")
            {
                double pice = 36, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 38, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 40, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "บางพลู")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "22";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "24";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "26";
            }

            else if (startMRT.Text == "บางซ่อน" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "28";
            }

            #endregion

            #region สามแยกบางใหญ่

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "บางพลู")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "ไทรม้า")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "บางกระสอ")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 36, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 37, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 39, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "21";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "บางซ่อน")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "23";
            }

            else if (startMRT.Text == "สามแยกบางใหญ่" && endMRT.Text == "เตาปูน")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "25";
            }

            #endregion

            #region วงศ์สว่าง

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "เตาปูน")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "บางซ่อน")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "บางกระสอ")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "ไทรม้า")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 36, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 38, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "บางพลู")
            {
                double pice = 40, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "22";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "24";
            }

            else if (startMRT.Text == "วงศ์สว่าง" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "26";
            }

            #endregion

            #region บางพลู

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "บางพลู")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 19, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "ไทรม้า")
            {
                double pice = 21, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 24, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "บางกระสอ")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 35, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 37, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 39, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "21";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "บางซ่อน")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "23";
            }

            else if (startMRT.Text == "บางพลู" && endMRT.Text == "เตาปูน")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "25";
            }

            #endregion

            #region แยกติวานนท์

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "เตาปูน")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "บางซ่อน")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "บางกระสอ")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "ไทรม้า")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 36, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "บางพลู")
            {
                double pice = 38, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 40, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "22";
            }

            else if (startMRT.Text == "แยกติวานนท์" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "24";
            }

            #endregion

            #region บางรักใหญ่

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "บางพลู")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "ไทรม้า")
            {
                double pice = 19, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 21, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 24, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "บางกระสอ")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 35, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 37, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "บางซ่อน")
            {
                double pice = 40, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "21";
            }

            else if (startMRT.Text == "บางรักใหญ่" && endMRT.Text == "เตาปูน")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "23";
            }

            #endregion

            #region กระทรวงสาธารณสุข

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "เตาปูน")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "บางซ่อน")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "บางกระสอ")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "ไทรม้า")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "บางพลู")
            {
                double pice = 36, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 38, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 40, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            else if (startMRT.Text == "กระทรวงสาธารณสุข" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 42, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "22";
            }

            #endregion

            #region บางรักน้อยท่าอิฐ

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "บางพลู")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "ไทรม้า")
            {
                double pice = 19, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 19, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 21, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "บางกระสอ")
            {
                double pice = 24, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 35, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "บางซ่อน")
            {
                double pice = 37, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "บางรักน้อยท่าอิฐ" && endMRT.Text == "เตาปูน")
            {
                double pice = 40, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "21";
            }

            #endregion

            #region ศูนย์ราชการนนทบุรี

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "เตาปูน")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "บางซ่อน")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "บางกระสอ")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "ไทรม้า")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "บางพลู")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 36, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 38, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "ศูนย์ราชการนนทบุรี" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 40, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            #endregion

            #region ไทรม้า

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "บางพลู")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "ไทรม้า")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 19, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "บางกระสอ")
            {
                double pice = 21, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 24, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "บางซ่อน")
            {
                double pice = 37, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "20";
            }

            else if (startMRT.Text == "ไทรม้า" && endMRT.Text == "เตาปูน")
            {
                double pice = 37, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "22";
            }

            #endregion

            #region สะพานพระนั่งเกล้า

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 28, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "บางพลู")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "ไทรม้า")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "บางกระสอ")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "บางซ่อน")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "สะพานพระนั่งเกล้า" && endMRT.Text == "เตาปูน")
            {
                double pice = 36, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            #endregion

            #region บางกระสอ

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "เตาปูน")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "บางซ่อน")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "บางกระสอ")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "ไทรม้า")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 37, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "บางพลู")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 35, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "บางกระสอ" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 38, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "18";
            }

            #endregion

            #region แยกนนทบุรี 1

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "คลองบางไผ่")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "16";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "ตลาดบางใหญ่")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "สามแยกบางใหญ่")
            {
                double pice = 28, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "บางพลู")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "บางรักใหญ่")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "บางรักน้อยท่าอิฐ")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "ไทรม้า")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "สะพานพระนั่งเกล้า")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "แยกนนทบุรี 1")
            {
                double pice = 14, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "0";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "บางกระสอ")
            {
                double pice = 17, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "2";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "ศูนย์ราชการนนทบุรี")
            {
                double pice = 20, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "4";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "กระทรวงสาธารณสุข")
            {
                double pice = 23, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "6";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "แยกติวานนท์")
            {
                double pice = 25, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "8";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "วงศ์สว่าง")
            {
                double pice = 27, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "10";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "บางซ่อน")
            {
                double pice = 30, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "12";
            }

            else if (startMRT.Text == "แยกนนทบุรี 1" && endMRT.Text == "เตาปูน")
            {
                double pice = 33, quan = 0, sum = 0;
                quan = double.Parse(quantityMRT.Text);
                sum = pice * quan;
                priceMRT.Text = sum.ToString("#,##.00");
                timeMRT.Text = "14";
            }

            #endregion

        }

        private void clearMRT_Click(object sender, EventArgs e)
        {
            priceMRT.Text = "";
            timeMRT.Text = "";
            quantityMRT.Text = "1";
            startMRT.Text = "";
            endMRT.Text = "";
        }
    }
}
