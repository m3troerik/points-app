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
        double oldX = p.X();
        double oldY = p.Y();
 
        p.Translate(5, 3);
 
        Assert.Equal(oldX + 5, p.X(), 3);
        Assert.Equal(oldY + 3, p.Y(), 3);
    }

    [Fact]
    public void TestScale()
    {
        Point p = new Point(3, 4);
        double oldX = p.X();
        double oldY = p.Y();
 
        p.Scale(2);
 
        Assert.Equal(oldX * 2, p.X(), 3);
        Assert.Equal(oldY * 2, p.Y(), 3);
    }

    [Fact]
    public void TestCentreRotate()
    {
        Point p = new Point(15, 0);
        double oldRho = p.Rho();
        double oldTheta = p.Theta();
 
        p.CentreRotate(Math.PI / 3);
 
        Assert.Equal(oldRho, p.Rho(), 3);
        Assert.Equal(oldTheta + Math.PI / 3, p.Theta(), 3);
    }

    [Fact]
    public void TestRotate()
    {
        Point p = new Point(15, 10);
        Point centre = new Point(10, 10);
        double oldDistance = centre.Distance(p);
        double oldAngle = centre.VectorTo(p).Theta();
 
        p.Rotate(centre, Math.PI / 2);
 
        Assert.Equal(oldDistance, centre.Distance(p), 3);
        Assert.Equal(oldAngle + Math.PI / 2, centre.VectorTo(p).Theta(), 3);
    }
}
