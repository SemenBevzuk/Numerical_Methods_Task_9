using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Dtos;
using LiveCharts.Wpf;
using Brushes = System.Drawing.Brushes;

namespace Numerical_Methods_Task_9
{
    delegate double FunkDelegate(double x, double u);
    public partial class Form1 : Form
    {
        private int CounterOfTests = 0;
        public Form1()
        {
            InitializeComponent();
 
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Высота жидксоти",
            });
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Время"
            });

            cartesianChart1.Zoom = ZoomingOptions.X;

            dataGridView_MetodInfo.Rows.Clear();
            dataGridView_MetodInfo.Columns.Clear();
            dataGridView_MetodInfo.RowCount = 1;
            dataGridView_MetodInfo.ColumnCount = 14;
            dataGridView_MetodInfo.Columns[0].HeaderText = "i";
            dataGridView_MetodInfo.Columns[1].HeaderText = "h_(i-1)";
            dataGridView_MetodInfo.Columns[2].HeaderText = "x_i";
            dataGridView_MetodInfo.Columns[3].HeaderText = "v_i";
            dataGridView_MetodInfo.Columns[4].HeaderText = "v_i_удв";
            dataGridView_MetodInfo.Columns[5].HeaderText = "v_i - v_i_удв";
            dataGridView_MetodInfo.Columns[6].HeaderText = "S";
            dataGridView_MetodInfo.Columns[7].HeaderText = "e";
            dataGridView_MetodInfo.Columns[8].HeaderText = "v_i_уточ";
            dataGridView_MetodInfo.Columns[9].HeaderText = "v_i_итог";
            dataGridView_MetodInfo.Columns[10].HeaderText = "u_i";
            dataGridView_MetodInfo.Columns[11].HeaderText = "|u_i - v_i|";
            dataGridView_MetodInfo.Columns[12].HeaderText = "Ум. шага";
            dataGridView_MetodInfo.Columns[13].HeaderText = "Ув. шага";
            dataGridView_MetodInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_MetodInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            CounterOfTests++;
            dataGridView_MetodInfo.Rows.Clear();
            Function Func = new Function();
            Func.SetFunction(Convert.ToDouble(textBox_alfa.Text), Convert.ToDouble(textBox_sigma.Text));
            FunkDelegate function = Func.FunctionValue;

            TrueSolution trueSolution = new TrueSolution(Convert.ToDouble(textBox_alfa.Text), 
                                                         Convert.ToDouble(textBox_sigma.Text), 
                                                         Convert.ToDouble(textBox_u_0.Text));

            Runge_Kutta_2 RK_2 = new Runge_Kutta_2();

            RK_2.Init(Convert.ToDouble(textBox_x_0.Text), Convert.ToDouble(textBox_u_0.Text),
                Convert.ToDouble(textBox_h.Text), Convert.ToDouble(textBox_eps.Text),
                Convert.ToDouble(textBox_epsBorder.Text), Convert.ToInt32(textBox_max_iter.Text), function);

            RK_2.Run();

            cartesianChart1.Series.Add(new LineSeries{
                Title = "Численное решение #"+Convert.ToString(CounterOfTests), 
                Values = new ChartValues<ObservablePoint>(RK_2
                    .GetPoints()
                    .Select(_ => new ObservablePoint(_.X, _.U)))
            });

            List<MetodInfo> metodInfos = RK_2.GetMetodInfos();
            
            metodInfos.ForEach(_ => 
                dataGridView_MetodInfo.Rows.Add
                (_.Iteration, _.H, _.X, _.U, _.UHalf, _.U - _.UHalf,
                _.S, _.e, _.UCorr, _.U, trueSolution.FunctionValue(_.X), Math.Abs(trueSolution.FunctionValue(_.X) - _.U).ToString("F8"), _.CountMinusH, _.CountPlusH));

            richTextBox_log.AppendText("    Время вытекания жидкости в Тесте №"+Convert.ToString(CounterOfTests)+
                " составило "+RK_2.GetResultTime()+" секунд.\n");
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            dataGridView_MetodInfo.Rows.Clear();
            cartesianChart1.Series.Clear();
            CounterOfTests = 0;
        }

        private void button_trueSolution_Click(object sender, EventArgs e)
        {
            TrueSolution trueSolution = new TrueSolution(Convert.ToDouble(textBox_alfa.Text), 
                                                             Convert.ToDouble(textBox_sigma.Text), 
                                                             Convert.ToDouble(textBox_u_0.Text));
             trueSolution.FindPoints();
             cartesianChart1.Series.Add(new LineSeries{
                Title = "Истинное решение", 
                Values = new ChartValues<ObservablePoint>(trueSolution
                    .GetPoints()
                    .Select(_ => new ObservablePoint(_.X, _.U))),
                PointGeometry = DefaultGeometries.Square,
             });
        }
    }
}
