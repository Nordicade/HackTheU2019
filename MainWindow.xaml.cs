using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.UI;
using System.Windows;
using System.Windows.Media;
using test2;
using System;
namespace ArcGISApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GraphicsOverlay mapGraphics;
        public MainWindow()
        {

             
             mapGraphics = new GraphicsOverlay();
            SettingsGUI gui = new SettingsGUI();
            gui.run();
            
            InitializeComponent();



            //Create a point geometry
            //var point = new MapPoint(-118.29507 + i, 34.13501 + i, SpatialReferences.Wgs84);
            string currentline;

            // Read the file and display it line by line.  
            System.IO.StreamReader  tempFile= new System.IO.StreamReader(@"C:\Users\jljut\Desktop\test.txt");
            while ((currentline = tempFile.ReadLine()) != null)
            {
                char[] space = { ' ' };
                string[] logLat = currentline.Split(space);
                double.TryParse(logLat[0], out double log);
                double.TryParse(logLat[1], out double lat);
                Console.WriteLine("test");
                var point = new MapPoint(log, lat, SpatialReferences.Wgs84);


                //Create point symbol with outline
                var pointSymbol = new SimpleMarkerSymbol(SimpleMarkerSymbolStyle.Diamond, System.Drawing.Color.FromArgb(226, 119, 40), 10);
                pointSymbol.Outline = new SimpleLineSymbol(SimpleLineSymbolStyle.Solid, System.Drawing.Color.FromArgb(0, 0, 255), 2);

                //Create point graphic with geometry & symbol
                var pointGraphic = new Graphic(point, pointSymbol);

                //Add point graphic to graphic overlay
                MapGraphics.Graphics.Add(pointGraphic);
            }
            
            

        }

        
        // Map initialization logic is contained in MapViewModel.cs
    }
}
