using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace class5sample
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		double carPositionL, carPositionT;
		public MainWindow()
		{
			InitializeComponent();
			carPositionL = ImageCar.Margin.Left;
			carPositionT = ImageCar.Margin.Top;
		}
		private void ButtonStop_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("BRAKES!!!");
			ImageSign.Visibility = Visibility.Hidden;
		}
		private void ButtonSlow_Click(object sender, RoutedEventArgs e)
		{
			int rnd = new Random().Next(2);
			ImageSign.Visibility = Visibility.Visible;

			MessageBox.Show("slowing down...");
			if (rnd == 0)
				ImageCar.Margin = new Thickness(carPositionL + 10, carPositionT, 0, 0);
			else
				ImageCar.Margin = new Thickness(carPositionL + 30, carPositionT, 0, 0);

			carPositionL = ImageCar.Margin.Left;

			if (ImageCar.Margin.Left >= ImageFinish.Margin.Left)
			{
				ImageFans.Visibility = Visibility.Visible;
				ImageSign.Visibility = Visibility.Hidden;
			}
		}
		private void ButtonGo_Click(object sender, RoutedEventArgs e)
		{
			ImageCar.Margin = new Thickness(carPositionL + 20, carPositionT, 0, 0);
			carPositionL = ImageCar.Margin.Left;

			if(ImageCar.Margin.Left >= ImageFinish.Margin.Left)
				ImageFans.Visibility = Visibility.Visible;
		}
	}
}
