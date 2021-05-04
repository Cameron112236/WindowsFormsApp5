using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5 { 
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;
            label1.Text = $"{playerName} is number {playerNumber}";
             



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = pi * (radius * radius);
            
            label1.Text = $"The area of circle with a radius of {radius}cm is {area}cm^2 ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length*width;
            double totalCost= area*costPerMeter;

            label1.Text = $" The area of a room with dimensions {length}m x {width}m is {area}m ^ 2 \n \n The cost to carpet this area at 19.95 per square metre is ${totalCost}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double shirt = 12.49;
            double tax = (shirt / 100) * 13;
            double total = shirt + tax;
            double tendered = 20.00;
            double change = tendered - total;
            label1.Text = $" Bill of Sale \n \n shirt:               {shirt} \n \n tax:                   {tax} \n total:               {total} \n \n tendered:        {tendered} \n Change:            {change}";
        }
    }
}
