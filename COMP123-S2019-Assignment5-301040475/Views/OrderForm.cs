using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5_301040475.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            OrderInfoFilled();
        }


        public void OrderInfoFilled()
        {
            ConditionTextLabel.Text = Program.product.condition;
            PlatformTextLabel.Text = Program.product.platform;
            ManufacturerTextLabel.Text = Program.product.manufacturer;
            ModelTextLabel.Text = Program.product.model;
            LCDSizeDataLabel.Text = Program.product.screensize;
            MemoryDataLabel.Text = Program.product.RAM_size;
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            CPUNumberDataLabel.Text = Program.product.CPU_number;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            HDDDataLabel.Text = Program.product.HDD_size;
            GPUDataLabel.Text = Program.product.CPU_type;
            WebCamDataLabel.Text = Program.product.webcam;
            OSDataLabel.Text = Program.product.OS;
            PriceTextLabel.Text = Program.product.cost.Value.ToString("C2");
            TaxTextLabel.Text = (Program.product.cost * 13 / 100).Value.ToString("C2");
            TotalTextLabel.Text = (Program.product.cost * 113 / 100).Value.ToString("C2");
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the event handler for the FinishButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your order! Your order will be processed in 7 - 10 business days.",
                "Ordered Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
