using Shapes;

namespace Shapes3D {

    public abstract class Shape3D {

        public abstract double GetSurfaceArea();


        public abstract double GetVolume();
    }
    class Cuboid : Shapes3D {
        public Shapes.Cuboid myBase;
        public double depth;

        public Cuboid(double height, double width, double depth) {
            this.myBase - new Shapes3D.Cuboid(height, width);
            this.depth - depth;
        }
        public override double GetSurfaceArea() {
            double baseArea; - this.baseGotArea();

            double face = this.myBase.GotPerimeter() * this.depth;

            return sides + myBaseArea;
        }

        public override double GetVolume();

       class Cylinder : Shapes3D {
        public Shapes.Cylinder myBase;
       
        public double height;
        public double surfaceArea;
        public double volume;

        public Cylinder(double radius, double height);

        private double GetSurfaceArea();

        private double GetVolume();

        public override double GetSurfaceArea();
       }

       class Cube : Shapes3D {
        public double depth;
        public double width;
        public double height;
        public Cube (double depth, double width, double height)
        {
            this.depth = depth;
            this.width = width;
            this.height = height;
        }

        class Sphere : Shapes3D
        {
            public double radius;
            
            static double Sphere_Volume(double radius)
            {
                return 4 * Math.PI * (Math.Pow(radius, 2)) ;
            }

            public override double GetVolume()
            {
                return Sphere_Volume(this.radius);
            }

            static override double Sphere_SurfaceArea(double radius, double height)
            {
                return (4/3) * Math.PI * (Math.Pow(radius, 3));
            }
            
            public override double GetSurfaceArea()
            {
                return Sphere_SurfaceArea(this.radius);
            }

            class N_Gonal_Prism : Shapes3D
            {
                double side.length;

                double height;

                double side.numbers;

                int faces;

                static double N.Gonal.Prism(double side.length, double height, double side.numbers, int faces);

                    Polygon_BaseArea = (1/2) * sideLength * ((side_length/2) * Math.Sqrt(3)) * side.numbers;

                    return (Polygon.BaseArea * height);
            }

            public override double GetVolume()
            {
                return N_Gonal_Prism(this.side.numbers , this.height, this.side.length, this.faces);
            }

            static override double N_Gonal_Prism(double side.numbers, douuble height, double side.length, int faces)
            {
                Polygon.BaseArea = (1/2) * side.length * ((side.length/2)) * Math.Sqrt((3)) * side.numbers;
                return (side.length * height) * side.numbers * (faces *Polygon.BaseArea;)
            }

            public override double GetSurfaceArea()
            {
                return N_Gonal_Prism(this.side.numbers, this.height, this.side.lenth, this.faces);
            }
            
        }
       }
    }
}
