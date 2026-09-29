using Xunit;
using geom;


public class PointTests
{
    [Fact]
    public void TestConstructor()
    {
        Point p = new Point(10, 20);

        Assert.Equal(10, p.X(), 3);
        Assert.Equal(20, p.Y(), 3);
    }

    [Fact]
    public void TestX()
    {
        Point p = new Point(10, 20);

        Assert.Equal(10, p.X(), 3);
    }

    [Fact]
    public void TestY()
    {
        Point p = new Point(10, 20);

        Assert.Equal(20, p.Y(), 3);
    }

    [Fact]
    public void TestRho()
    {
        Point p = new Point(3, 4);

        Assert.Equal(5, p.Rho(), 3);
    }

    [Fact]
    public void TestTheta()
    {
        Point p = new Point(0, 15);

        Assert.Equal(Math.PI / 2, p.Theta(), 3);
    }

    [Fact]
    public void TestVectorTo()
    {
        Point p1 = new Point(10, 20);
        Point p2 = new Point(-20, 60);

        Point v = p1.VectorTo(p2);

        Assert.Equal(-30, v.X(), 3);
        Assert.Equal(40, v.Y(), 3);
    }

    [Fact]
    public void TestDistance()
    {
        Point p1 = new Point(10, 20);
        Point p2 = new Point(-20, 60);

        Assert.Equal(50, p1.Distance(p2), 3);
    }

    [Fact]
    public void TestTranslate()
    {
        Point p = new Point(10, 20);

        p.Translate(5, 3);

        Assert.Equal(15, p.X(), 3);
        Assert.Equal(23, p.Y(), 3);
    }

    [Fact]
    public void TestScale()
    {
        Point p = new Point(3, 4);

        p.Scale(2);

        Assert.Equal(6, p.X(), 3);
        Assert.Equal(8, p.Y(), 3);
    }

    [Fact]
    public void TestCentreRotate()
    {
        Point p = new Point(15, 0);

        p.CentreRotate(Math.PI / 3);

        Assert.Equal(15, p.Rho(), 3);
        Assert.Equal(Math.PI / 3, p.Theta(), 3);
    }

    [Fact]
    public void TestRotate()
    {
        Point p = new Point(15, 10);
        Point centre = new Point(10, 10);

        p.Rotate(centre, Math.PI / 2);

        Assert.Equal(10, p.X(), 3);
        Assert.Equal(15, p.Y(), 3);
    }
}
