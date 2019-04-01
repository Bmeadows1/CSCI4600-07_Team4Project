using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Threading;

namespace wpfspin
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Init(new Point3D(0, -5, 0));
        }

        private Timer _timer;
        private readonly List<ModelVisual3D> _models = new List<ModelVisual3D>();
        //private double _angle; not needed unless we wish to rotate


        public void Init(Point3D firstPoint)
        {
            _models.Add(CreateSphere(firstPoint, 10, 10, 10, Colors.AliceBlue));
            //_models.Add(CreateSphere(secondPoint, 10, 10, 10, Colors.AliceBlue));
            //_models.Add(GetCylinder(GetSurfaceMaterial(Colors.Red), secondPoint, 2, midPoint.Z));

            _models.ForEach(x => mainViewport.Children.Add(x));
            _timer = new Timer(10);
            _timer.Elapsed += TimerElapsed;
            _timer.Enabled = true;
        }


        void TimerElapsed(object sender, ElapsedEventArgs e)
        {
           Dispatcher.Invoke(DispatcherPriority.Normal, new Action<double>(Transform), 0.5d);
        }

        /* This not needed for the code as of yet
        public MaterialGroup GetSurfaceMaterial(Color colour)
        {
            var materialGroup = new MaterialGroup();
            var emmMat = new EmissiveMaterial(new SolidColorBrush(colour));
            materialGroup.Children.Add(emmMat);
            materialGroup.Children.Add(new DiffuseMaterial(new SolidColorBrush(colour)));
            var specMat = new SpecularMaterial(new SolidColorBrush(Colors.White), 30);
            materialGroup.Children.Add(specMat);
            return materialGroup;
        }
        */

        private Model3DGroup CreateTriangleModel(Material material, Point3D p0, Point3D p1, Point3D p2)
        {
            var mesh = new MeshGeometry3D();
            mesh.Positions.Add(p0);
            mesh.Positions.Add(p1);
            mesh.Positions.Add(p2);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            var normal = CalculateNormal(p0, p1, p2);
            mesh.Normals.Add(normal);
            mesh.Normals.Add(normal);
            mesh.Normals.Add(normal);

            var model = new GeometryModel3D(mesh, material);

            var group = new Model3DGroup();
            group.Children.Add(model);
            return group;
        }


        private Vector3D CalculateNormal(Point3D p0, Point3D p1, Point3D p2)
        {
            var v0 = new Vector3D(p1.X - p0.X, p1.Y - p0.Y, p1.Z - p0.Z);
            var v1 = new Vector3D(p2.X - p1.X, p2.Y - p1.Y, p2.Z - p1.Z);
            return Vector3D.CrossProduct(v0, v1);
        }


        void Transform(double adjustBy)
        {
            //this causes it to spin around
            // _angle += adjustBy;


            var rotateTransform3D = new RotateTransform3D { CenterX = 0, CenterZ = 0 };
            //var axisAngleRotation3D = new AxisAngleRotation3D { Axis = new Vector3D(1, 1, 1), Angle = _angle };
            //rotateTransform3D.Rotation = axisAngleRotation3D;
            var myTransform3DGroup = new Transform3DGroup();
            myTransform3DGroup.Children.Add(rotateTransform3D);
            _models.ForEach(x => x.Transform = myTransform3DGroup);
        }


        public ModelVisual3D CreateSphere(Point3D center, double radius, int u, int v, Color color)
        {
            Model3DGroup sphere = new Model3DGroup();

            if (u < 2 || v < 2)
                return null;
            Point3D[,] pts = new Point3D[u, v];
            for (int i = 0; i < u; i++)
            {
                for (int j = 0; j < v; j++)
                {
                    pts[i, j] = GetPosition(radius,
                    i * 180 / (u - 1), j * 360 / (v - 1));
                    pts[i, j] += (Vector3D)center;
                }
            }

            Point3D[] p = new Point3D[4];
            for (int i = 0; i < u - 1; i++)
            {
                for (int j = 0; j < v - 1; j++)
                {
                    p[0] = pts[i, j];
                    p[1] = pts[i + 1, j];
                    p[2] = pts[i + 1, j + 1];
                    p[3] = pts[i, j + 1];
                    sphere.Children.Add(CreateTriangleFace(p[0], p[1], p[2], color));
                    sphere.Children.Add(CreateTriangleFace(p[2], p[3], p[0], color));
                }
            }
            ModelVisual3D model = new ModelVisual3D();
            model.Content = sphere;
            return model;
        }


        private Point3D GetPosition(double radius, double theta, double phi)
        {
            Point3D pt = new Point3D();
            double snt = Math.Sin(theta * Math.PI / 180);
            double cnt = Math.Cos(theta * Math.PI / 180);
            double snp = Math.Sin(phi * Math.PI / 180);
            double cnp = Math.Cos(phi * Math.PI / 180);
            pt.X = radius * snt * cnp;
            pt.Y = radius * cnt;
            pt.Z = -radius * snt * snp;
            return pt;
        }


        public Model3DGroup CreateTriangleFace(Point3D p0, Point3D p1, Point3D p2, Color color)
        {
            MeshGeometry3D mesh = new MeshGeometry3D(); mesh.Positions.Add(p0); mesh.Positions.Add(p1); mesh.Positions.Add(p2); mesh.TriangleIndices.Add(0); mesh.TriangleIndices.Add(1); mesh.TriangleIndices.Add(2);

            //This is not needed but might save it for later
            /*Vector3D normal = VectorHelper.CalcNormal(p0, p1, p2);
            mesh.Normals.Add(normal);
            mesh.Normals.Add(normal);
            mesh.Normals.Add(normal);
            */

            Material material = new DiffuseMaterial(
                new SolidColorBrush(color));
            GeometryModel3D model = new GeometryModel3D(
                mesh, material);
            Model3DGroup group = new Model3DGroup();
            group.Children.Add(model);
            return group;
        }

        /*
        private class VectorHelper
        {
            public static Vector3D CalcNormal(Point3D p0, Point3D p1, Point3D p2)
            {
                Vector3D v0 = new Vector3D(p1.X - p0.X, p1.Y - p0.Y, p1.Z - p0.Z);
                Vector3D v1 = new Vector3D(p2.X - p1.X, p2.Y - p1.Y, p2.Z - p1.Z);
                return Vector3D.CrossProduct(v0, v1);
            }
        }
        */
    }
}