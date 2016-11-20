using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Deducciones;

namespace ClassLibrary1
{

    [TestFixture]

    public class Class1
    {
       [Test]
        public void Test1()
        {
            Empleado e = new Empleado();

            int resultado = e.Calcular(false, 15000, 0, 0);
            Assert.AreEqual(resultado, 0);
            int resultado1 = e.Calcular(false, 15000, 0, 1);
            Assert.AreEqual(resultado1, 13600);
            int resultado2 = e.Calcular(false, 15000, 0, 2);
            Assert.AreEqual(resultado2, 15600);
        }

       [Test]
       public void Test2()
       {
           Empleado e = new Empleado();

          int resultado = e.Calcular(true, 15000, 500, 0);
           Assert.AreEqual(resultado, 13300);
           int resultado1 = e.Calcular(true, 15000, 500, 1);
           Assert.AreEqual(resultado1, 14700);
           int resultado2 = e.Calcular(true, 15000, 500, 2);
           Assert.AreEqual(resultado2, 16900);
       }

        [Test]
        public void Text3()
       {
           Empleado e = new Empleado();
           int resultado = e.Calcular(true, 15000, 2000, 0);
           Assert.AreEqual(resultado, 11100);
           int resultado1 = e.Calcular(true, 15000, 3000, 1);
           Assert.AreEqual(resultado1, 11880);
           int resultado2 = e.Calcular(true, 15000, 3000, 5);
           Assert.AreEqual(resultado2, 12519);
       }

    }
}
