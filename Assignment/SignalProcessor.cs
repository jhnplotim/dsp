using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{

    public class SignalProcessor
    {
        private int convResultSize = 0, hSize, dftSize =0;
        public int[] FindConvolution(int[] x, int[] h)
        {
            //Get size of the result array
            convResultSize = (x.Length + h.Length) - 1;

            //Get impulse response size
            hSize = h.Length;



            int[] conv = new int[GetSize()];

            //Compute the convolution of x and h
            for (int n = 0; n < convResultSize; n++)
            {
                for (int j = 0; j < (hSize); j++) 
                {
                    try
                    {
                        conv[n] += h[j]*x[n - j];
                    }
                    catch (Exception e)
                    {
                        e.GetBaseException();
                        
                    }
                } 
            }

            return conv;
        }

        public Complex[] FindDFT(int[] sample)
        {
            dftSize = sample.Length;
            
            //Convert integer array to complex array
            Complex[] complexSample = GetComplexFromIntArray(sample);
            
            // Initialize the complex array that will store the result of the dft
            Complex[] dftResult = new Complex[dftSize];

            //perform dft on sample
            for (int k = 0; k < dftSize; k++)
            {
                double realPartial = (2) * (System.Math.PI) * k  / dftSize;
                double imaginaryPartial = (-2)*(System.Math.PI)*k/dftSize;
                for (int n = 0; n < dftSize; n++)
                {
                   double real = System.Math.Cos(realPartial*n);
                   double imaginary = System.Math.Sin(imaginaryPartial*n);
                    try
                    {
                        dftResult[k] =  Complex.Add(dftResult[k] , Complex.Multiply(new Complex(real, imaginary), complexSample[n]));

                    }
                    catch (Exception e)
                    {
                        e.GetBaseException();

                    }
                }
            } //end dft
            return dftResult;
        }

        public void PlotDFT(Complex[] complex)
        {
            //Display DFT plot in a new window and pass it an array of complex numbers
            FormPlot fp = new FormPlot(complex);
            fp.Show();
            
        }

        //Method to convert an Integer array into a Complex Array
        private Complex[] GetComplexFromIntArray(int [] sample)
        {
            int size = sample.Length;
            Complex[] result = new Complex[size];
            for(int i = 0; i < size; i++)
            {
                result[i] = new Complex(sample[i], 0);

            }
            return result;

        }

        private int GetSize()
        {
            return convResultSize;
        }

        //Static Method used to convert DFT array into an array of magnitudes to be used for plotting the chart
        public static double[] GetAbsolutes(Complex[] array)
        {
            double[] resultArray = new double[array.Length];
            int i = 0;
            foreach (Complex c in array)
            {
                resultArray[i] = Complex.Abs(c);
                i++;
            }
            return resultArray;
        }
    }
}
