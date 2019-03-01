using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezelo.Test
{
    [TestFixture]
    class Teszteles
    {
        JaratKezelo j;
    

    [SetUp]
    public void setUp()
    {
        j = new JaratKezelo();

    }
        [Test]
        public void UjJarat()
        {
            j.UjJarat("655","New York","London", DateTime.Now);
            Assert.IsNotEmpty(j.Jaratok);

        }
        [Test]
        public void VanKeses()
        {
            j.Keses("6322", 10);
            Assert.AreEqual(10, 10);

        }
       














    }
}
