using NUnit.Framework;
using Assignment01_SENG8040;
namespace RectangleTest
{
    [TestFixture]
    public class UnitTest1
    {
        Rectangle Rc = new Rectangle();

        [Test]
        public void UnitTest_of_Getlength()
        {   
            int a = 15;
            int result = Rc.SetLength(a);
            int result1 = Rc.GetLength();
            Assert.AreEqual(result,15);
            Assert.AreEqual(result1, 15);
        }
        [Test]
        public void UnitTest_of_SetLength()
        {
            int a = 250;
            int result = Rc.SetLength(a);
            Assert.AreEqual(result, 250);
        }
        [Test]
        public void UnitTest_of_GetWidth()
        {
            int a = 7;
            int result = Rc.SetWidth(a);
            int result1 = Rc.GetWidth();
            Assert.AreEqual(result, 7);
            Assert.AreEqual(result1, 7);
        }
        [Test]
        public void UnitTest_of_SetWidth()
        {
            int a = 25;
            int result = Rc.SetWidth(a);
            Assert.AreEqual(result, 25);
        }
        [Test]
        public void UnitTest_of_Perimeter()
        {
            int a = 10, b = 10;
            Rc.SetLength(a);
            Rc.SetWidth(b);
            int result = Rc.GetPerimeter();
            Assert.AreEqual(result, 40);      
        }
        [Test]
        public void UnitTest_of_Area()
        {
            int a = 10, b = 10;
            Rc.SetLength(a);
            Rc.SetWidth(b);
            int result = Rc.GetArea();
            Assert.AreEqual(result, 100);
        }
       
    }
}
