using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.ComponentModel;


namespace OxyPlot_charts_working_example
{
    class ViewModel : INotifyPropertyChanged
    {
        private PlotModel plotModel;

        public PlotModel PlotModel
        {
            get { return plotModel; }
            set { plotModel = value; OnPropertyChanged("PlotModel"); }
        }

        public ViewModel()
        {
            PlotModel = new PlotModel();
            SetUpModel();
            //LoadData();

        }

        private void SetUpModel()
        {
            PlotModel.Title = "AreaSeries with default style";

            var linearAxis1 = new LinearAxis();
            linearAxis1.Position = AxisPosition.Bottom;
            PlotModel.Axes.Add(linearAxis1);

            var linearAxis2 = new LinearAxis();
            PlotModel.Axes.Add(linearAxis2);

        }

        public void LoadData()
        {
            var areaSeries1 = new AreaSeries();
            areaSeries1.Points2.Add(new DataPoint(0, 60));
            areaSeries1.Points2.Add(new DataPoint(5, 80));
            areaSeries1.Points2.Add(new DataPoint(20, 70));
            areaSeries1.Points.Add(new DataPoint(0, 50));
            areaSeries1.Points.Add(new DataPoint(10, 40));
            areaSeries1.Points.Add(new DataPoint(20, 60));
            PlotModel.Series.Add(areaSeries1);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

