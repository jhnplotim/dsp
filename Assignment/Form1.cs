using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    // The form displayed on launching the application
    public partial class FormLanding : Form
    {
        private SignalProcessor sp;
        private Complex[] array ;

        //variables to store x, and h values bfore performing the convolution
        private int[] x = null, h = null, y = null;

        public FormLanding()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  MessageBox.Show("Please enter comma separated integers in the text boxes");
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                //do nothing since the dft hasn't yet been computed
                doNothing();
                MessageBox.Show("Make sure you have found a DFT before plotting!");
            }
            else
            {
                if (sp != null)
                {
                    //perform dft using an instance of the signal processor
                    sp.PlotDFT(array);
                    
                }
                
            }
        }

        //Method that does nothing
        private void doNothing()
        {
            
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            //variable used to be used store the result of the convolution.
            String result = String.Empty;

            if (sp == null)
            sp = new SignalProcessor();

            
            //Start extraction and validation of the value of x entered in the text box
            string xInput = txtBoxX.Text;

            bool xValid;

            int[] xArray = ExtractAndValidate(out xValid, xInput);
            if (xValid)
            {
                labelXResult.Text = "Valid entry";
                labelXResult.Visible = true;
                x = xArray;
            }
            else
            {
                labelXResult.Text = "Invalid entry!";
                labelXResult.Visible = true;
            }
            //End x extraction

            //start extraction and validation of the value of h entered in the textbox
            string hInput = txtBoxH.Text;

            bool hValid;

            int[] hArray = ExtractAndValidate(out hValid, hInput);
            if (hValid)
            {
                labelHResult.Text = "Valid entry";
                labelHResult.Visible = true;
                h = hArray;
            }
            else
            {
                labelHResult.Text = "Invalid entry!";
                labelHResult.Visible = true;

            }
            //end h extraction

            //Perform convolution on x and h
            if (x != null && h != null)
            {
                int[] convResult = sp.FindConvolution(x, h);

                result = "[ ";
                int index = 0;
                int lastIndex = convResult.Length - 1;
                foreach (int i in convResult)
                {
                    result += i.ToString();
                    if (index != (lastIndex))
                        result += ", ";

                    index++;
                }
                result += " ]";

                txtBoxConvResult.Text = result;
                txtBoxConvResult.Visible = true;
            }
            else
            {
                txtBoxConvResult.Text = "Error!";
                txtBoxConvResult.Visible = true;
            }
            
            
            
        }

        private void btnDFT_Click(object sender, EventArgs e)
        {
            //variable used for storing the result of a DFT
            String result = String.Empty;

            if (sp == null)
            sp = new SignalProcessor();


            // Begin extraction and validation of array to be used for DFT 
            string yInput = txtBoxY.Text;

            bool yValid;

            int[] yArray = ExtractAndValidate(out yValid, yInput);
            if (yValid)
            {
                labelYResult.Text = "Valid entry";
                labelYResult.Visible = true;
                y = yArray;
            }
            else
            {
                labelYResult.Text = "Invalid entry!";
                labelYResult.Visible = true;
            }

            if(y != null)
            { 
            array = sp.FindDFT(y);
            result = "[ ";
            int index = 0;
            int lastIndex = array.Length - 1;
            foreach (Complex i in array)
            {
                if (i.Imaginary == 0 || i.Imaginary < 0.0005)
                {
                    result += string.Format("{0:0.0}", i.Real);
                }
                else if (i.Real == 0 || i.Real <0.0005)
                {
                    result += string.Format("{0:.0}i", i.Imaginary);
                }
                else
                {
                    result += string.Format("{0:.0}+{1:.0}i", i.Real, i.Imaginary);
                }

                if (index != (lastIndex))
                    result += ", ";

                index++;
            }
            result += " ]";
            
            richTxtBoxDFTResult.Text = result;
            richTxtBoxDFTResult.Visible = true;
            btnPlot.Visible = true;
            }


        }
        //Method used to pick and validate value stored in textbox and stored before it is used for convolution
        private void txtBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            // The keypressed method uses the KeyChar property to check  
            // whether the ENTER key is pressed.  

            // If the ENTER key is pressed, the Handled property is set to true,  
            // to indicate the event is handled. 
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                string xInput = txtBoxX.Text;

                bool valid;

                int[] xArray = ExtractAndValidate(out valid, xInput);
                if (valid)
                {
                    labelXResult.Text = "Valid entry";
                    labelXResult.Visible = true;
                    x = xArray;
                }
                else
                {
                    labelXResult.Text = "Invalid entry!";
                    labelXResult.Visible = true;
                }
            }

        }


        //Method used to extract array from text box and validating that they are integers
        private int[] ExtractAndValidate(out bool valid, string input)
        {
            valid = true;

            if (String.IsNullOrEmpty(input))
            {
                valid = false;
                return new int[1];
            }
            else
            {
            string[] tempResult = input.Split(',');
            int [] result = new int[tempResult.Length];
            for (int i =0; i < tempResult.Length; i ++)
            {
                try
                {
                    result[i] = int.Parse(tempResult[i]);
                }
                catch (Exception e)
                {
                    e.GetBaseException();
                    valid = false;
                    break;
                }
                
            }
                if (valid)
                {
                    return result;
                }
                else
                {
                    return new int[1];
                }

            }
            


        }

        //Method used to pick and validate value stored in textbox and stored before it is used for convolution
        private void txtBoxH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // The keypressed method uses the KeyChar property to check  
            // whether the ENTER key is pressed.  

            // If the ENTER key is pressed, the Handled property is set to true,  
            // to indicate the event is handled. 
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                string hInput = txtBoxH.Text;

                bool valid;

                int[] hArray = ExtractAndValidate(out valid, hInput);
                if (valid)
                {
                    labelHResult.Text = "Valid entry";
                    labelHResult.Visible = true;
                    h = hArray;
                }
                else
                {
                    labelHResult.Text = "Invalid entry!";
                    labelHResult.Visible = true;
                    
                }
            }
        }

        private void txtBoxY_TextChanged(object sender, EventArgs e)
        {

        }

        
        }
    }
