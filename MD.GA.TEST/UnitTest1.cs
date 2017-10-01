using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MD.GA.DA.Repositories;
using MD.GA.BE.Entidades;
using System.Collections.Generic;
using MD.GA.BL.BusinessServices;

namespace MD.GA.TEST
{
    [TestClass]
    public class UnitTest1
    {
        ArticuloRepository artRepository = new ArticuloRepository();
        DocumentoRepository docRepository = new DocumentoRepository();
        DocumentoService docService = new DocumentoService();
        EmpresaRepository empresaRespository = new EmpresaRepository();

        public UnitTest1()
        {
            
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestUpdateDocumento()
        {
            Documento doc = docRepository.GetById(3320);
            List<Documento_Articulo> lstDocArticulo = new List<Documento_Articulo>();
            for (int i = 0; i < 11; i++)
            {
                Documento_Articulo docArt = new Documento_Articulo();
                Articulo art = artRepository.GetById(i);
                if (art != null)
                {
                    docArt.Articulo = art;
                    docArt.Id_Articulo = art.Id_Articulo;
                    Empresa emp = empresaRespository.GetById(2);
                    docArt.Empresa = emp;
                    docArt.Id_Empresa = 2;
                    //docArt.empr = "KD DEVELOPERS";
                    docArt.RazonSocial = "KD UPDATE";
                    docArt.RUC = "20153045021";
                    docArt.DescripcionArticulo = "MONITOR 2000";
                    docArt.CodArea = "test AREA";
                    docArt.UnidadMedida = "TEST UM";
                    docArt.Cantidad = 200;
                    docArt.PrecioUnitario = 20;
                    docArt.Importe = 2000;
                    docArt.UsuarioCreacion = "KD.RMALDONADO";
                    docArt.FechaCreacion = DateTime.Now;
                    lstDocArticulo.Add(docArt);
                }
            }
            docService.Update(doc, lstDocArticulo);

        }
    }
}
