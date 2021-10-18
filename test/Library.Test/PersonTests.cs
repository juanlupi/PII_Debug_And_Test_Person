using NUnit.Framework;

namespace UnitTestAndDebug
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de pruebaaquí
            Person p = new Person("Juan", "8.765.432-1","25/10/2002");
            string expected = "Juan";
            Assert.AreEqual(expected, p.Name);
        }
        [Test]
        public void TestId() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de pruebaaquí
            Person p = new Person("Juan", "5.273.328-7","25/10/2002");
            string expected = null;
            Assert.AreEqual(expected, p.ID);
        }
        [Test]
        public void TestDate() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de pruebaaquí
            Person p = new Person("Juan", "5.273.328-7","25/10/2002");
            string expected = "25/10/2002";
            Assert.AreEqual(expected, p.Date);
        }
    }
}