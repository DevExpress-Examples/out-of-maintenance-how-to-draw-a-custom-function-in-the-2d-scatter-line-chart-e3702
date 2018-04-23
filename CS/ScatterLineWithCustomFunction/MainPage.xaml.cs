using System;
using System.Windows.Controls;
using DevExpress.Xpf.Charts;


namespace ScatterLineWithCustomFunction {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            CreateArchimedianSpiralPoints();
        }

        void CreateArchimedianSpiralPoints() {
            for (int i = 0; i < 720; i += 15) {
                double t = (double)i / 180 * Math.PI;
                double x = t * Math.Cos(t);
                double y = t * Math.Sin(t);
                ArchimedianSpiral.Points.Add(new SeriesPoint(x, y));
            }
        }

    }
}
