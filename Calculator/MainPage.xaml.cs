using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        char[] results;
        int count=0;
        char previous_op;
        float x, y, z;
        String a="", b="";



        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String n = result.Text;


            if(n.Length>0)
            n = n.Remove(n.Length - 1);

            result.Text = n;
        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "0";

        

        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "1";

           
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "2";

         

        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "3";

            
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "4";

        

        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "5";

           

        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "6";

          

        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "7";

          

        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "8";

           

        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "9";


        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "+";
            count++;
            previous_op = '+';

            if (count > 1)
            {
                calc();
                count--;
            }
        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "";
            count = 0;



        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            calculate();
        }

        public String return_a(int i) {

            a = "";
            for (int j = 0; j < i; j++)
            {
                a = a + results[j];
            }

            return a;

        }

        public String return_b(int i)
        {

            b = "";
            for (int j = i+1; j < results.Length; j++)
            {
                b = b + results[j];
            }

            return b;

        }

        public void calculate()
        {
            a = "";
            b = "";
            results = result.Text.ToCharArray();

            result.Text = "";

            for (int i = 0; i < results.Length; i++)
            {


                if (results[i] == '+')
                {




                    return_a(i);
                    return_b(i);

                    x = float.Parse(a);
                    y = float.Parse(b);

                    z = operate(x, y, '+');

                    result.Text = z.ToString();



                }

                if (results[i] == '-')
                {

                    return_a(i);
                    return_b(i);



                    x = float.Parse(a);
                    y = float.Parse(b);

                    z = operate(x, y, '-');

                    result.Text = z.ToString();



                }
                if (results[i] == '*')
                {
                    return_a(i);
                    return_b(i);

                    x = float.Parse(a);
                    y = float.Parse(b);

                    z = operate(x, y, '*');

                    result.Text = z.ToString();



                }
                if (results[i] == '/')
                {

                    return_a(i);
                    return_b(i);


                    x = float.Parse(a);
                    y = float.Parse(b);

                    z = operate(x, y, '/');

                    result.Text = z.ToString();



                }
                if (results[i] == '%')
                {

                    return_a(i);
                    return_b(i);

                    float x, y, z;

                    x = float.Parse(a);
                    y = float.Parse(b);
                    z = x % y;

                    result.Text = z.ToString();



                }

            }
        }

        public float operate(float a, float b, char op)
        {
            switch(op)
            {
                case '+':
                   return a + b;
                    
                case '-':
                    return a - b; 
                case '*':
                    return a * b;
                case '%':
                    return a % b;
                default:
                    return 0;
            }   
        }
        

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "-";
            count++;
            previous_op = '-';

            if (count >1)
            {
                calc();
                count--;
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "*";
            count++;
            previous_op = '*';

            if (count > 1)
            {
                calc();
                count--;
            }


        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "/";
            count++;
            previous_op = '/';

            if (count > 1)
            {
                calc();
                count--;
            }

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + "%";
            count++;
            previous_op = '%';

            if (count > 1)
            {
                calc();
                count--;
            }

        }

        public void calc( )
        {
            a = "";
            b = "";
            results = result.Text.ToCharArray();

            results[results.Length-1] = ' ';

            result.Text = "";

            for (int i = 0; i < results.Length; i++)
            {


                if (results[i] == '+')
                {




                    return_a(i);
                    return_b(i);

                    x = float.Parse(a);
                    y = float.Parse(b);

                    z = operate(x, y, '+');

                    result.Text = z.ToString()+previous_op;



                }

                if (results[i] == '-')
                {

                    return_a(i);
                    return_b(i);



                    x = float.Parse(a);
                    y = float.Parse(b);

                    z = operate(x, y, '-');

                    result.Text = z.ToString() + previous_op;



                }
                if (results[i] == '*')
                {
                    return_a(i);
                    return_b(i);

                    x = float.Parse(a);
                    y = float.Parse(b);

                    z = operate(x, y, '*');

                    result.Text = z.ToString() + previous_op;



                }
                if (results[i] == '/')
                {

                    return_a(i);
                    return_b(i);


                    x = float.Parse(a);
                    y = float.Parse(b);

                    z = operate(x, y, '/');

                    result.Text = z.ToString() + previous_op;



                }
                if (results[i] == '%')
                {

                    return_a(i);
                    return_b(i);

                    float x, y, z;

                    x = float.Parse(a);
                    y = float.Parse(b);
                    z = x % y;

                    result.Text = z.ToString()+previous_op;



                }

            }

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text + ".";

        }
    }
}
