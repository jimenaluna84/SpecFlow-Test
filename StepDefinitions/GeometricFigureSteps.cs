using NUnit.Framework;
using GeometricFigureExercise;
using Rectangle = GeometricFigureExercise.Rectangle;

namespace SpecFlowProject4.StepDefinitions
{
    [Binding]
    public class CalculateAreaPerimeterSteps
    {
        private GeometricFigure? Figure;
        private IGeometricFigure? CircularFigure;
        private double ResultArea;
        private double ResultPerimeter;
        private const double TolerancePercentage = 2.0;

        [Given(@"we have a square side of (.*)")]
        public void GivenWeHaveASquareSide(double side)
        {
            Figure = new Square(side, "cm");
        }


        [When(@"we calculate the area and perimeter")]
        public void WhenWeCalculateAreaAndPerimeter()
        {
            ResultArea = Figure.Area;
            ResultPerimeter = Figure.Perimeter;

        }

        [Then(@"the area should be (.*)")]
        public void ThenAreaShouldBe(double area)
        {
            double maxAllowedDifference = area * (TolerancePercentage / 100.0);
            Assert.That(area, Is.EqualTo(ResultArea).Within(maxAllowedDifference),
                        $"The actual area ({ResultArea}) is not within {TolerancePercentage}% of the expected area ({area}).");
        }


        [Then(@"the perimeter should be (.*)")]
        public void ThenPerimeterShouldBe(double perimeter)
        {

            double maxAllowedDifference = perimeter * (TolerancePercentage / 100.0);
            Assert.That(perimeter, Is.EqualTo(ResultPerimeter).Within(maxAllowedDifference),
                        $"The actual area ({ResultPerimeter}) is not within {TolerancePercentage}% of the expected perimeter ({perimeter}).");

        }

        [Given(@"we have a triangle base of (.*) and a height of (.*)")]
        public void SetTriangleBaseAndHeight(double baseTriangle, double height)
        {
            Figure = new Triangle(baseTriangle, height, "cm");

        }

        [Given(@"we have a rhombus with diagonals of lengths (.*) and (.*)")]
        public void GivenWeHaveARhombusWithDiagonals(double MajorDiagonal, double MinorDiagonal)
        {
            Figure = new Rhombus(MajorDiagonal, MinorDiagonal, "cm");

        }

        [Given(@"we have a rectangle with length (.*) and width (.*)")]
        public void GivenWeHaveARectangleWithLengthAndWidth(double Height, double width)
        {
            Figure = new Rectangle(width, Height, "cm");

        }
        [Given(@"we have a circle with a radius of (.*)")]
        public void GivenWeHaveACircleWithRadius(double radius)
        {
            CircularFigure = new Circle(radius, "cm");

        }

        [When(@"we calculate CircularFigure area and perimeter")]
        public void WhenWeCalculateFigure2AreaAndPerimeter()
        {
            ResultArea = CircularFigure.Area;
            ResultPerimeter = CircularFigure.Perimeter;

        }

        [Given(@"we have an ellipse with a major axis of (.*) and a minor axis of (.*)")]
        public void GivenWeHaveAnEllipseWithMajorAndMinorAxis(double RadiusMajorAxis, double RadiusMinorAxis)
        {
            CircularFigure = new Ellipse(RadiusMajorAxis, RadiusMinorAxis, "cm");
        }



    }
}
