using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_MatíasBustos
{
    public partial class Form1 : Form
    {
        double FirsValue = 0;
        string OperandoAntes;
        string LastCalculation = "";
        

        string Operator = "";
        bool Operator_click = false;
        bool SyntaxError = false;
    
        int CountResult = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Num1Button_Click(object sender, EventArgs e)
        {
            if(Result.Text == "0"||Operator_click)
            {
                Result.Clear();
            }      
            
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
            Operator_click = false;

        }

        private void DeleteAllButtonFromView_Click(object sender, EventArgs e)
        {
            Result.Clear();
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            

            FirsValue = Double.Parse(Result.Text);
            OperandoAntes = Result.Text;

            Operator = b.Text;
            Operator_click = true;


            





        }

        private void DeleteOneButtonFromView_Click(object sender, EventArgs e)
        {
            try
            {
                //Borra el ultimo elemento agregado
                Result.Text = Result.Text.Remove(Result.Text.Length - 1);
            }
            catch(Exception)
            {
            }     
        }

        private void ResultButtonOperation_Click(object sender, EventArgs e)
        {
            int countPointsBefore = Result.Text.Split(',').Length - 1;
            
            int countPointsAfter = (OperandoAntes.ToString()).Split(',').Length - 1;

            

            if (countPointsAfter > 1 || countPointsBefore > 1)
            {
                SyntaxError = true;
            }

            if (Operator == "+")
            {
                if(SyntaxError)
                {
                    Result.Text = "Syntax ERROR";
                    
                }
                else
                {
                    Result.Text = (FirsValue + Double.Parse(Result.Text)).ToString();
                }

            }
            else if (Operator == "-")
            {
                if (SyntaxError == true)
                {
                    Result.Text = "Syntax ERROR";
                    
                }
                else
                {
                    Result.Text = (FirsValue - Double.Parse(Result.Text)).ToString();
 
                }
            }
            else if (Operator == "*")
            {
                if (SyntaxError == true)
                {
                    Result.Text = "Syntax ERROR";
                    
                }
                else
                {
                    Result.Text = (FirsValue * Double.Parse(Result.Text)).ToString();
                    
                }
                
            }
            else if (Operator == ":")
            {
                string valor = (FirsValue / Double.Parse(Result.Text)).ToString();

                if (SyntaxError == true)
                {
                    Result.Text = "Syntax ERROR";
                    
                }
               
                if(valor=="\u221E")
                {
                    Result.Text = "Math ERROR";
                }
                else
                {
                    Result.Text = (FirsValue / Double.Parse(Result.Text)).ToString();
                    
                }
                


            }
            if (CountResult == 0)
            {
                LastCalculation = Result.Text;
            }

            CountResult++;
 
            Operator_click = false;
            SyntaxError = false;

        }

        private void AnsButton_Click(object sender, EventArgs e)
        {
            Result.Text = LastCalculation;
  
            CountResult = 0;
        }
    }
}
