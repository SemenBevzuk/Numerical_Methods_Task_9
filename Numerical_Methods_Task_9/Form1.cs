using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        private List<ExperimentInfo> listExperimentInfos = new List<ExperimentInfo>();
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

            cartesianChart1.Zoom = ZoomingOptions.Xy;
            cartesianChart1.DefaultLegend = new DefaultLegend { Visibility = Visibility.Visible };
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            //cartesianChart1.Zoom = ZoomingOptions.Y;

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

            dataGridView_TaskInfo.Rows.Clear();
            dataGridView_TaskInfo.Columns.Clear();
            dataGridView_TaskInfo.RowCount = 1;
            dataGridView_TaskInfo.ColumnCount = 8;
            dataGridView_TaskInfo.Columns[0].HeaderText = "#";
            dataGridView_TaskInfo.Columns[1].HeaderText = "alfa";
            dataGridView_TaskInfo.Columns[2].HeaderText = "sigma";
            dataGridView_TaskInfo.Columns[3].HeaderText = "x0";
            dataGridView_TaskInfo.Columns[4].HeaderText = "u0";
            dataGridView_TaskInfo.Columns[5].HeaderText = "h0";
            dataGridView_TaskInfo.Columns[6].HeaderText = "e";
            dataGridView_TaskInfo.Columns[7].HeaderText = "Максимум итераций";
            dataGridView_TaskInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_TaskInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            CounterOfTests++;
            dataGridView_MetodInfo.Rows.Clear();
            dataGridView_TaskInfo.Rows.Clear();
            Function Func = new Function();
            Func.SetFunction(Convert.ToDouble(textBox_alfa.Text), Convert.ToDouble(textBox_sigma.Text));
            FunkDelegate function = Func.FunctionValue;

            TrueSolution trueSolution = new TrueSolution(Convert.ToDouble(textBox_alfa.Text),
                                                         Convert.ToDouble(textBox_sigma.Text),
                                                         Convert.ToDouble(textBox_u_0.Text));

            Runge_Kutta_2 RK_2 = new Runge_Kutta_2();

            RK_2.Init(Convert.ToDouble(textBox_x_0.Text), Convert.ToDouble(textBox_u_0.Text),
                Convert.ToDouble(textBox_h.Text), Convert.ToDouble(textBox_eps.Text),
                Convert.ToInt32(textBox_max_iter.Text), function, checkBox_StepControl.Checked);

            RK_2.Run();

            cartesianChart1.Series.Add(new LineSeries
            {
                Title = "Численное решение #" + Convert.ToString(CounterOfTests),
                Values = new ChartValues<ObservablePoint>(RK_2
                    .GetPoints()
                    .Select(_ => new ObservablePoint(_.X, _.V))),
                //Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 200)),
                //PointForeground = 
                //    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 200)),
                PointGeometrySize = 5
            });
            List<MetodInfo> metodInfos = RK_2.GetMetodInfos();

            metodInfos.ForEach(_ =>
                dataGridView_MetodInfo.Rows.Add
                (_.Iteration, _.H, _.X, _.V, _.UHalf, _.V - _.UHalf,
                _.S, _.e, _.UCorr, _.V, trueSolution.FunctionValue(_.X), Math.Abs(trueSolution.FunctionValue(_.X) - _.V).ToString("F8"), _.CountMinusH, _.CountPlusH));
            dataGridView_MetodInfo.AutoResizeColumns();

            TaskInfo taskInfo = new TaskInfo(CounterOfTests,
                                             Convert.ToDouble(textBox_alfa.Text), Convert.ToDouble(textBox_sigma.Text),
                                             Convert.ToDouble(textBox_x_0.Text), Convert.ToDouble(textBox_u_0.Text),
                                             Convert.ToDouble(textBox_h.Text), Convert.ToDouble(textBox_eps.Text),
                                             Convert.ToInt32(textBox_max_iter.Text));
            dataGridView_TaskInfo.Rows.Add(taskInfo.Number, taskInfo.Alfa, taskInfo.Sigma, taskInfo.X0, taskInfo.U0,
                                           taskInfo.h0, taskInfo.e, taskInfo.Max_iteration);

            listExperimentInfos.Add(new ExperimentInfo(taskInfo, metodInfos));
            comboBox_TaskSelector.Items.Add("Тест №" + Convert.ToString(CounterOfTests));

            richTextBox_log.AppendText("    Время вытекания жидкости в Тесте №" + Convert.ToString(CounterOfTests) +
                ": " + RK_2.GetResultTime() + " секунд.\n");
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            dataGridView_MetodInfo.Rows.Clear();
            dataGridView_TaskInfo.Rows.Clear();
            richTextBox_log.Clear();
            cartesianChart1.Series.Clear();
            listExperimentInfos.Clear();
            CounterOfTests = 0;
        }

        private void button_trueSolution_Click(object sender, EventArgs e)
        {
            TrueSolution trueSolution = new TrueSolution(Convert.ToDouble(textBox_alfa.Text),
                                                             Convert.ToDouble(textBox_sigma.Text),
                                                             Convert.ToDouble(textBox_u_0.Text));
            trueSolution.FindPoints();
            cartesianChart1.Series.Add(new LineSeries
            {
                Title = "Истинное решение",
                Values = new ChartValues<ObservablePoint>(trueSolution
                    .GetPoints()
                    .Select(_ => new ObservablePoint(_.X, _.V))),
                PointGeometry = DefaultGeometries.Square,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 69)),
                PointGeometrySize = 5
            });
        }

        private void comboBox_TaskSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_MetodInfo.Rows.Clear();
            dataGridView_TaskInfo.Rows.Clear();
            int index = comboBox_TaskSelector.SelectedIndex;
            TrueSolution trueSolution = new TrueSolution(listExperimentInfos[index].TaskInformation.Alfa,
                                                         listExperimentInfos[index].TaskInformation.Sigma,
                                                          listExperimentInfos[index].TaskInformation.U0);

            dataGridView_TaskInfo.Rows.Add(listExperimentInfos[index].TaskInformation.Number, listExperimentInfos[index].TaskInformation.Alfa, listExperimentInfos[index].TaskInformation.Sigma, listExperimentInfos[index].TaskInformation.X0, listExperimentInfos[index].TaskInformation.U0,
                                           listExperimentInfos[index].TaskInformation.h0, listExperimentInfos[index].TaskInformation.e, listExperimentInfos[index].TaskInformation.Max_iteration);
            listExperimentInfos[index].MetodInformation.ForEach(_ =>
                dataGridView_MetodInfo.Rows.Add
                (_.Iteration, _.H, _.X, _.V, _.UHalf, _.V - _.UHalf,
                _.S, _.e, _.UCorr, _.V, trueSolution.FunctionValue(_.X), Math.Abs(trueSolution.FunctionValue(_.X) - _.V).ToString("F8"), _.CountMinusH, _.CountPlusH));
        }
    }
}
