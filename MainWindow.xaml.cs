using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatrixSumAndMultiple
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBox[,] leftMatrix, rightMatrix;
        private int? matrixSizeNow = null;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void clearAndGenerate(object sender, RoutedEventArgs e)
        {
            /*if  (sizeInit.Text != String.Empty || (int.Parse(sizeInit.Text) > 1 ))
            {
            }
            else
            { MessageBox.Show("Введите пожалуйста размер матрицы", "Ошибка."); } */
            leftMatrix = GenerateGrid(LeftMatrix, int.Parse(sizeInit.Text));
            rightMatrix = GenerateGrid(RightMatrix, int.Parse(sizeInit.Text));
        }

        private TextBox[,] GenerateGrid(UniformGrid Grid, int size)
        {
            matrixSizeNow = size;
            TextBox[,] result = new TextBox[size, size];

            Grid.Rows = size;
            Grid.Columns = size;
            Grid.Children.Clear();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = new TextBox();
                    result[i, j].Text = "0";
                    Grid.Children.Add(result[i, j]);
                }
            }
            return result;
        }

        private void RandomValues(object sender, RoutedEventArgs e)
        {
            RandomValuesMatrix(leftMatrix);
            RandomValuesMatrix(rightMatrix);
        }

        private void RandomValuesMatrix(TextBox[,] textBoxes)
        {
            if(matrixSizeNow != null)
            {
                Random rand = new Random(DateTime.Now.Second + DateTime.Now.Millisecond);
                foreach (TextBox item in textBoxes)
                {
                    item.Text = rand.Next(0, 10).ToString();
                }
            }
            
        }


        private void ResultValues(object sender, RoutedEventArgs e)
        {

        }


    }
}

