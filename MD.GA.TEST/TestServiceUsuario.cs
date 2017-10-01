using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MD.GA.TEST
{
    [TestClass]
    public class TestServiceUsuario
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

            //Declaramos el Proxy
        ProxyUsuario.ServiceUsuarioClient proxy = new ProxyUsuario.ServiceUsuarioClient();
        [TestMethod]
        public void UsuarioValidarLoginOK()
        {


            //Declaramos la entidad con los datos a registrar
            string user = "rodolfo";
            string pass = "spectrum";

            //Recibir resultado
            var resultado = proxy.UsuarioValidarLogin(user,pass);

            //Comparar valor de resultado con valor esperado
            Assert.AreEqual(true, resultado.IsValid);
        }

        [TestMethod]
        public void UsuarioValidarLoginError()
        {
            //Declaramos la entidad con los datos a registrar
            string user = "rodolfo";
            string pass = "1233";

            //Recibir resultado
            var resultado = proxy.UsuarioValidarLogin(user, pass);

            //Comparar valor de resultado con valor esperado
            Assert.AreEqual(true, resultado.IsValid);
        }


    }
}
