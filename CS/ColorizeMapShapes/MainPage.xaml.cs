using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using DevExpress.Xpf.Map;
namespace ColorizeMapShapes
{
    public partial class MainPage : UserControl
    {
        List<MapItem> loadedShapes;

        public MainPage()
        {
            InitializeComponent();
        }

        #region #ShapesLoaded
        private void ShapefileLoader_ShapesLoaded(object sender, ShapesLoadedEventArgs e)
        {
            loadedShapes = e.Shapes;
            PrepareShapesByPopulation();

        }
        #endregion #ShapesLoaded
        void PrepareShapesByPopulation()
        {
            if (loadedShapes != null)
                foreach (MapItem item in loadedShapes)
                {
                    MapShape shape = item as MapShape;
                    shape.Fill =
                        new SolidColorBrush(ColorGenerator.GetColorByPopulation(Convert.ToInt32((double)item.Attributes["POP_EST"].Value)));
                }
        }

    }
}
