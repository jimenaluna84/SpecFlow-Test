using NUnit.Framework;
using GeometricFigureExercise;
using Rectangle = GeometricFigureExercise.Rectangle;
using System.Reflection.Metadata;


namespace SpecFlowProject4.StepDefinitions
{
    [Binding]
    public class CalculateAreaPerimeterSteps

    {
        private readonly ScenarioContext scenarioContext;
        private const double TolerancePercentage = 1.0;
        public CalculateAreaPerimeterSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }


        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("Before Tests!!");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("After Test!!");
        }


        [Given(@"we have a square side of (.*)")]
        public void GivenWeHaveASquareSide(double side)
        {
            GeometricFigure Figure = new Square(side, "cm");
            scenarioContext["Figure"] = Figure;
        }


        [When(@"we calculate the area and perimeter")]
        public void WhenWeCalculateAreaAndPerimeter()
        {

            GeometricFigure Figure = (GeometricFigure)scenarioContext["Figure"];
            scenarioContext["area"] = Figure.Area;
            scenarioContext["perimeter"] = Figure.Perimeter;

        }

        [Then(@"the area should be (.*)")]
        public void ThenAreaShouldBe(double expectedArea)
        {
            double actualArea = (double)scenarioContext["area"];
            ValidateValue(actualArea, expectedArea, "area");


        }

        [Then(@"the perimeter should be (.*)")]
        public void ThenPerimeterShouldBe(double expectedPerimeter)
        {
            double actualPerimeter = (double)scenarioContext["perimeter"];
            ValidateValue(actualPerimeter, expectedPerimeter, "perimeter");
        }

        private static void ValidateValue(double actualValue, double expectedValue, string valueName)
        {
            double maxAllowedDifference = expectedValue * (TolerancePercentage / 100.0);
            Assert.That(actualValue, Is.EqualTo(expectedValue).Within(maxAllowedDifference),
                        $"The actual {valueName} ({actualValue}) is not within {TolerancePercentage}% of the expected {valueName} ({expectedValue}).");
        }

        [Given(@"we have a triangle base of (.*) and a height of (.*)")]
        public void SetTriangleBaseAndHeight(double baseTriangle, double height)
        {
            GeometricFigure Figure = new Triangle(baseTriangle, height, "cm");
            scenarioContext["Figure"] = Figure;
        }

        [Given(@"we have a rhombus with diagonals of lengths (.*) and (.*)")]
        public void GivenWeHaveARhombusWithDiagonals(double MajorDiagonal, double MinorDiagonal)
        {
            GeometricFigure Figure = new Rhombus(MajorDiagonal, MinorDiagonal, "cm");
            scenarioContext["Figure"] = Figure;
        }

        [Given(@"we have a rectangle with length (.*) and width (.*)")]
        public void GivenWeHaveARectangleWithLengthAndWidth(double Height, double width)
        {
            GeometricFigure Figure = new Rectangle(width, Height, "cm");
            scenarioContext["Figure"] = Figure;

        }
        [Given(@"we have a circle with a radius of (.*)")]
        public void GivenWeHaveACircleWithRadius(double radius)
        {
            GeometricFigure Figure = new Circle(radius, "cm");
            scenarioContext["Figure"] = Figure;
        }


        [Given(@"we have an ellipse with a major axis of (.*) and a minor axis of (.*)")]
        public void GivenWeHaveAnEllipseWithMajorAndMinorAxis(double RadiusMajorAxis, double RadiusMinorAxis)
        {
            GeometricFigure Figure = new Ellipse(RadiusMajorAxis, RadiusMinorAxis, "cm");
            scenarioContext["Figure"] = Figure;
        }



    }
}



