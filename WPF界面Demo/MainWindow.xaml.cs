using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Visifire.Charts;

namespace WPF界面Demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            topPanel.MouseDown += TopPanel_MouseDown;

            LoadChart();
        }

        /// <summary>
        /// 窗口拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        void LoadChart()
        {
            chart.Titles.Clear();
            chart.Series.Clear();
            Visifire.Charts.Title title = new Visifire.Charts.Title();
            title.Text = "释义常用分布图";
            chart.Titles.Add(title);
            DataSeries dataSeries = new DataSeries();
            dataSeries.RenderAs = RenderAs.Column;
            dataSeries.LabelEnabled = true;
            dataSeries.LabelStyle = LabelStyles.OutSide;

            DataPoint dataPoint;
           
            for (int i = 0; i < 10; i++)
            {
                dataPoint = new DataPoint();
                dataPoint.AxisXLabel ="张三的分"+i;
                dataPoint.YValue = i*2;
                dataSeries.DataPoints.Add(dataPoint);
            }
            chart.Series.Add(dataSeries);
        }
    }
}
