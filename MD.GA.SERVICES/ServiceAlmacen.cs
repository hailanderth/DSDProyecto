using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.BE.Entidades;
using MD.GA.BL.Base;
using MD.GA.BL.BusinessServices;
using MD.GA.BL.BusinessInterfaces;
using MD.GA.COMMOM.Response;

namespace MD.GA.SERVICES
{
    public class ServiceAlmacen : IServiceAlmacen
    {
        private IUsuarioService usuarioService;
        private ISedeService sedeService;
        private IProveedorService proveedorService;
        private IAreaService areaService;
        private IUnidadMedidaService unidadMedidaService;
        private IArticuloService articuloService;
        private IDocumentoService documentoService;
        private IEmpresaService empresaService;
        private IPuestoService puestoService;
        private IBancoService bancoService;

        public ServiceAlmacen()
        {
            this.usuarioService = new UsuarioService();
            this.sedeService = new SedeService();
            this.proveedorService = new ProveedorService();
            this.areaService = new AreaService();
            this.unidadMedidaService = new UnidadMedidaService();
            this.articuloService = new ArticuloService();
            this.documentoService = new DocumentoService();
            this.empresaService = new EmpresaService();
            this.puestoService = new PuestoService();
            this.bancoService = new BancoService();
        }

        public void Dispose()
        {
            usuarioService = null;
            sedeService = null;
            proveedorService = null;
            areaService = null;
            unidadMedidaService = null;
            articuloService = null;
            documentoService = null;
            empresaService = null;
            bancoService = null;
        }

        #region BANCO METHODS
        public Response<BANCO> BancoInsert(BANCO banco)
        {
            return bancoService.Insert(banco);
        }

        public Response<BANCO> BancoUpdate(BANCO banco)
        {
            return bancoService.Update(banco);
        }

        public Response<BANCO> BancoDelete(int id)
        {
            return bancoService.Delete(id);
        }
        public Response<List<BANCO>> BancoGetAll()
        {
            Response<List<BANCO>> response = null;
            response = bancoService.GetAll();
            return response;
        }

        public Response<BANCO> BancoGetById(int id)
        {
            return bancoService.GetById(id);
        }

        public Response<BANCO> BancoGetById(int? id_Banco)
        {
            return bancoService.GetById(id_Banco);
        }

        public async Task<Response<BANCO>> BancoInsertAsync(BANCO banco)
        {
            Response<BANCO> response = null;
            await Task.Run(() =>
            {
                response = bancoService.Insert(banco);
            });
            return response;
        }

        public async Task<Response<BANCO>> BancoUpdateAsync(BANCO banco)
        {
            Response<BANCO> response = null;
            await Task.Run(() =>
            {
                response = bancoService.Update(banco);
            });
            return response;
        }

        public async Task<Response<BANCO>> BancoDeleteAsync(int id)
        {
            Response<BANCO> response = null;
            await Task.Run(() =>
            {
                response = bancoService.Delete(id);
            });
            return response;
        }

        public async Task<Response<BANCO>> BancoGetByIdAsync(int id)
        {
            Response<BANCO> response = null;
            await Task.Run(() =>
            {
                response = bancoService.GetById(id);
            });
            return response;
        }
        public async Task<Response<List<BANCO>>> BancoGetAllAsync()
        {
            Response<List<BANCO>> response = null;
            await Task.Run(() => {
                response = bancoService.GetAll();
            });
            return response;
        }

        public List<BANCO> ComboBanco()
        {
            return bancoService.Listar();
        }

        #endregion
        #region SEDE METHODS 

        public Response<Sede> SedeInsert(Sede sede)
        {
            return sedeService.Insert(sede);
        }

        public Response<Sede> SedeUpdate(Sede sede)
        {
            return sedeService.Update(sede);
        }

        public Response<Sede> SedeDelete(int id)
        {
            return sedeService.Delete(id);
        }

        public Response<Sede> SedeGetById(int id)
        {
            return sedeService.GetById(id);
        }

        public Response<List<Sede>> SedeGetAll()
        {
            return sedeService.GetAll();

        }

        public async Task<Response<Sede>> SedeDeleteAsync(int id)
        {
            Response<Sede> response = null;
            await Task.Run(() =>
            {
                response = sedeService.Delete(id);
            });
            return response;
        }

        public async Task<Response<Sede>> SedeGetByIdAsync(int id)
        {
            Response<Sede> response = null;
            await Task.Run(() =>
            {
                response = sedeService.GetById(id);
            });
            return response;
        }

        public async Task<Response<List<Sede>>> SedeGetAllAsync()
        {
            Response<List<Sede>> response = null;
            await Task.Run(() =>
            {
                response = sedeService.GetAll();
            });
            return response;
        }

        public async Task<Response<Sede>> SedeInsertAsync(Sede sede)
        {
            Response<Sede> response = null;
            await Task.Run(() =>
                {
                    response = sedeService.Insert(sede);
                });
            return response;
        }

        public async Task<Response<Sede>> SedeUpdtadeAsync(Sede sede)
        {
            Response<Sede> response = null;
            await Task.Run(() =>
            {
                response = sedeService.Update(sede);
            });
            return response;
        }

        public List<Sede> ComboSede()
        {
            return sedeService.Listar();
        }
        #endregion

        #region USUARIO METHODS
        public Response<Usuario> UsuarioDelete(int id)
        {
            return usuarioService.Delete(id);
        }

        public async Task<Response<Usuario>> UsuarioDeleteAsync(int id)
        {
            Response<Usuario> response = null;
            await Task.Run(() =>
            {
                response = usuarioService.Delete(id);
            });
            return response;
        }

        //public async Task<Response<String>> GetPassAsync(string clave)
        //{
        //    Response<String> response = null;
        //    await Task.Run(() =>
        //    {
        //        response = usuarioService.GetPass(clave);
        //    });
        //    return response;
        //}
        //public async Task<Response<String>> GetPassDesAsync(string clave)
        //{
        //    Response<String> response = null;
        //    await Task.Run(() =>
        //    {
        //        response = usuarioService.GetPassDes(clave);
        //    });
        //    return response;
        //}
        public String GetPass(string clave) {
            return usuarioService.GetPass(clave);
        }
        public String GetPassDes(string clave) {
            return usuarioService.GetPassDes(clave);
        }
        public Response<List<Usuario>> UsuarioGetAll()
        {
            return usuarioService.GetAll();
        }

        public async Task<Response<List<Usuario>>> UsuarioGetAllAsync()
        {
            Response<List<Usuario>> response = null;
            await Task.Run(() =>
            {
                response = usuarioService.GetAll();
            });
            return response;
        }

        public Response<Usuario> UsuarioGetById(int id)
        {
            return usuarioService.GetById(id);
        }

        public async Task<Response<Usuario>> UsuarioGetByIdAsync(int id)
        {
            Response<Usuario> response = null;
            await Task.Run(() =>
            {
                response = usuarioService.GetById(id);
            });
            return response;
        }

        public Response<DateTime> UsuarioGetServerDate()
        {
            return usuarioService.GetServerTime();
        }

        public async Task<Response<DateTime>> UsuarioGetServerDateAsync()
        {
            Response<DateTime> response = null;
            await Task.Run(() =>
            {
                response = usuarioService.GetServerTime();
            });
            return response;
        }

        public Response<Usuario> UsuarioInsert(Usuario usuario)
        {
            return usuarioService.Insert(usuario);
        }

        public async Task<Response<Usuario>> UsuarioInsertAsync(Usuario usuario)
        {
            Response<Usuario> response = null;
            await Task.Run(() =>
            {
                response = usuarioService.Insert(usuario);
            });
            return response;
        }

        public Response<Usuario> UsuarioUpdate(Usuario usuario)
        {
            return usuarioService.Update(usuario);
        }

        public async Task<Response<Usuario>> UsuarioUpdateAsync(Usuario usuario)
        {
            Response<Usuario> response = null;
            await Task.Run(() =>
            {
                response = usuarioService.Update(usuario);
            });
            return response;
        }

        public Response<Usuario> UsuarioValidarLogin(string usuario, string password)
        {
            return usuarioService.Login(usuario, password);
        }

        public async Task<Response<Usuario>> UsuarioValidarLoginAsync(string usuario, string password)
        {
            Response<Usuario> response = null;
            await Task.Run(() =>
            {
                response = usuarioService.Login(usuario,password);
            });
            return response;
        }
        #endregion

        #region PROVEEDOR METHODS
        public Response<Proveedor> ProveedorInsert(Proveedor proveedor)
        {
            return proveedorService.Insert(proveedor);
        }

        public Response<Proveedor> ProveedorUpdate(Proveedor proveedor)
        {
            return proveedorService.Update(proveedor);
        }

        public Response<Proveedor> ProveedorDelete(int id)
        {
            return proveedorService.Delete(id);
        }

        public Response<Proveedor> ProveedorGetById(int id)
        {
            return proveedorService.GetById(id);
        }

        public Response<List<Proveedor>> ProveedorGetAll()
        {
            return proveedorService.GetAll();
        }

        public async Task<Response<Proveedor>> ProveedorInsertAsync(Proveedor provedor)
        {
            Response<Proveedor> response = null;
            await Task.Run(() =>
            {
                response = proveedorService.Insert(provedor);
            });
            return response;
        }

        public async Task<Response<Proveedor>> ProveedorUpdtadeAsync(Proveedor provedor)
        {
            Response<Proveedor> response = null;
            await Task.Run(() =>
            {
                response = proveedorService.Update(provedor);
            });
            return response;
        }

        public async Task<Response<Proveedor>> ProveedorDeleteAsync(int id)
        {
            Response<Proveedor> response = null;
            await Task.Run(() =>
            {
                response = proveedorService.Delete(id);
            });
            return response;
        }

        public async Task<Response<Proveedor>> ProveedorGetByIdAsync(int id)
        {
            Response<Proveedor> response = null;
            await Task.Run(() =>
            {
                response = proveedorService.GetById(id);
            });
            return response;
        }

        public async Task<Response<List<Proveedor>>> ProveedorGetAllAsync()
        {
            Response<List<Proveedor>> response = null;
            await Task.Run(() =>
            {

                response = proveedorService.GetAll();
            });
            return response;
        }

        public List<Proveedor> ComboProveedor()
        {
            return proveedorService.Listar();
        }

        #endregion

        #region AREA METHODS
        public Response<Area> AreaInsert(Area area)
        {
            return areaService.Insert(area);
        }

        public Response<Area> AreaUpdate(Area area)
        {
            return areaService.Update(area);
        }

        public Response<Area> AreaDelete(int id)
        {
            return areaService.Delete(id);
        }

        public Response<Area> AreaGetById(int id)
        {
            return areaService.GetById(id);
        }

        public Response<List<Area>> AreaGetAll()
        {
            return areaService.GetAll();
        }

        public async Task<Response<Area>> AreaInsertAsync(Area area)
        {
            Response<Area> response = null;
            await Task.Run(() =>
            {
                response = areaService.Insert(area);
            });
            return response;
        }

        public async Task<Response<Area>> AreaUpdtadeAsync(Area area)
        {
            Response<Area> response = null;
            await Task.Run(() =>
            {
                response = areaService.Update(area);
            });
            return response;
        }

        public async Task<Response<Area>> AreaDeleteAsync(int id)
        {
            Response<Area> response = null;
            await Task.Run(() =>
            {
                response = areaService.Delete(id);
            });
            return response;
        }

        public async Task<Response<Area>> AreaGetByIdAsync(int id)
        {
            Response<Area> response = null;
            await Task.Run(() =>
            {
                response = areaService.GetById(id);
            });
            return response;
        }

        public async Task<Response<List<Area>>> AreaGetAllAsync()
        {
            Response<List<Area>> response = null;
            await Task.Run(() =>
            {
                response = areaService.GetAll();
            });
            return response;
        }

        public List<Area> ComboArea()
        {
            return areaService.Listar();
        }

        #endregion

        #region UNIDAD DE MEDIDA METHOD
        public Response<UnidadMedida> UnidadMedidaInsert(UnidadMedida unidadmedida)
        {
            return unidadMedidaService.Insert(unidadmedida);
        }

        public Response<UnidadMedida> UnidadMedidaUpdate(UnidadMedida unidadmedida)
        {
            return unidadMedidaService.Update(unidadmedida);
        }

        public Response<UnidadMedida> UnidadMedidaDelete(int id)
        {
            return unidadMedidaService.Delete(id);
        }

        public Response<UnidadMedida> UnidadMedidaGetById(int id)
        {
            return unidadMedidaService.GetById(id);
        }

        public Response<List<UnidadMedida>> UnidadMedidaGetAll()
        {
            return unidadMedidaService.GetAll();
        }

        public async Task<Response<UnidadMedida>> UnidadMedidaInsertAsync(UnidadMedida unidadmedida)
        {
            Response<UnidadMedida> response = null;
            await Task.Run(() =>
            {
                response = unidadMedidaService.Insert(unidadmedida);
            });
            return response;
        }

        public async Task<Response<UnidadMedida>> UnidadMedidaUpdtadeAsync(UnidadMedida unidadmedida)
        {
            Response<UnidadMedida> response = null;
            await Task.Run(() =>
            {
                response = unidadMedidaService.Update(unidadmedida);
            });
            return response;
        }

        public async Task<Response<UnidadMedida>> UnidadMedidaDeleteAsync(int id)
        {
            Response<UnidadMedida> response = null;
            await Task.Run(() =>
            {
                response = unidadMedidaService.Delete(id);
            });
            return response;
        }

        public async Task<Response<UnidadMedida>> UnidadMedidaGetByIdAsync(int id)
        {
            Response<UnidadMedida> response = null;
            await Task.Run(() =>
            {
                response = unidadMedidaService.GetById(id);
            });
            return response;
        }

        public async Task<Response<List<UnidadMedida>>> UnidadMedidaGetAllAsync()
        {
            Response<List<UnidadMedida>> response = null;
            await Task.Run(() =>
            {
                response = unidadMedidaService.GetAll();
            });
            return response;
        }

        public List<UnidadMedida> ComboUnidadMedida()
        {
            return unidadMedidaService.Listar();
        }

    #endregion

        #region METHODS ARTICULO

        public Response<Articulo> ArticuloInsert(Articulo articulo)
            {
                return articuloService.Insert(articulo);
            }

            public Response<Articulo> ArticuloUpdate(Articulo articulo)
            {
                return articuloService.Update(articulo);
            }

            public Response<Articulo> ArticuloDelete(int id)
            {
                return articuloService.Delete(id);
            }

            public Response<Articulo> ArticuloGetById(int id)
            {
                return articuloService.GetById(id);
            }

            public Response<List<Articulo>> ArticuloGetAll()
            {
                return articuloService.GetAll();
            }

            public async Task<Response<Articulo>> ArticuloInsertAsync(Articulo articulo)
            {
                Response<Articulo> response = null;
                await Task.Run(() =>
                {
                    response = articuloService.Insert(articulo);
                });
                return response;
            }

            public async Task<Response<Articulo>> ArticuloUpdtadeAsync(Articulo articulo)
            {
                Response<Articulo> response = null;
                await Task.Run(() =>
                {
                    response = articuloService.Update(articulo);
                });
                return response;
            }

            public async Task<Response<Articulo>> ArticuloDeleteAsync(int id)
            {
                Response<Articulo> response = null;
                await Task.Run(() =>
                {
                    response = articuloService.Delete(id);
                });
                return response;
            }

            public async Task<Response<Articulo>> ArticuloGetByIdAsync(int id)
            {
                Response<Articulo> response = null;
                await Task.Run(() =>
                {
                    response = articuloService.GetById(id);
                });
                return response;
            }

            public async Task<Response<List<Articulo>>> ArticuloGetAllAsync()
            {
                Response<List<Articulo>> response = null;
                await Task.Run(() =>
                {
                    response = articuloService.GetAll();
                });
                return response;
            }
            #endregion

        #region METHODS DOCUMENTO
        public Response<Documento> DocumentoInsert(Documento documento)
        {
            return documentoService.Insert(documento);
        }

        public async Task<Response<Documento>> DocumentoInsertAsync(Documento documento)
        {
            Response<Documento> response = null;
            await Task.Run(() =>
            {
                response = documentoService.Insert(documento);
            });
            return response;
        }

        public Response<Documento> DocumentoUpdate(Documento documento)
        {
            return documentoService.Update(documento);
        }

        public async Task<Response<Documento>> DocumentoUpdateAsync(Documento documento)
        {
            Response<Documento> response = null;
            await Task.Run(() =>
            {
                response = documentoService.Update(documento);
            });
            return response;
        }

        public Response<Documento> DocumentoGetByTipoNumero(string tipo, int numero)
        {
            return documentoService.GetByTipoNumero(tipo, numero);
        }

        public Response<Documento> DocumentoGetByTipoNumeroSede(string tipo, int numero, int idSede)
        {
            return documentoService.GetByTipoNumeroSede(tipo, numero, idSede);
        }

        //documento get by tipo presupuesto
        public Response<Documento> DocumentoGetByTipoPresupuesto(string tipo, string tipoPre, int numero)
        {
            return documentoService.GetByTipoPresupuesto(tipo, tipoPre, numero);
        }
        public async Task<Response<Documento>> DocumentoGetByTipoPresupuestoAsync(string tipo, string tipoPre, int numero)
        {
            Response<Documento> response = null;
            await Task.Run(() => {
                response = documentoService.GetByTipoPresupuesto(tipo, tipoPre, numero);
            });
            return response;
        }
        public Response<List<ListaEstadSalida_Resultado>> GetlistaEstSalida(DateTime fecIni, DateTime fecFin, int sede, int area, int articulo)
        {
            return documentoService.GetlistaEstSalida(fecIni, fecFin, sede, area, articulo);
        }
        public async Task<Response<List<ListaEstadSalida_Resultado>>> GetlistaEstSalidaAsync(DateTime fecIni, DateTime fecFin, int area, int articulo, int sede)
        {
            {
                Response<List<ListaEstadSalida_Resultado>> response = null;
                await Task.Run(() =>
                {
                    response = documentoService.GetlistaEstSalida(fecIni, fecFin, area, articulo, sede);
                });
                return response;
            }
        }
        public Response<List<SP_LISTARREPORENTRADA_Result>> GetListaEntrada(DateTime fecIni, DateTime fecFin, int sede, int area)
        {
            return documentoService.GetListaEntrada(fecIni, fecFin, sede, area);
        }

        public async Task<Response<List<SP_LISTARREPORENTRADA_Result>>> GetListaEntradaAsync(DateTime fecIni, DateTime fecFin, int area, int articulo)
        {
            {
                Response<List<SP_LISTARREPORENTRADA_Result>> response = null;
                await Task.Run(() =>
                {
                    response = documentoService.GetListaEntrada(fecIni, fecFin, area, articulo);
                });
                return response;
            }
        }


        public Response<Documento> PresupuestoProcesado(string tipo, string tipoPre, int numero) {
            return documentoService.GetPresupuestoProcesado(tipo, tipoPre, numero);
        }
        public async Task<Response<Documento>> PresupuestoProcesadoAsync(string tipo, string tipoPre, int numero)
        {
            Response<Documento> response = null;
            await Task.Run(() => {
                response = documentoService.GetPresupuestoProcesado(tipo, tipoPre, numero);
            });
            return response;
        }
        public Response<Documento> DocumentoGetByTipoPresupuestoAnu(string tipo, string tipoPre, int numero)
        {
            return documentoService.GetByTipoPresupuestoAnu(tipo, tipoPre, numero);
        }
        public async Task<Response<Documento>> DocumentoGetByTipoPresupuestoAnuAsync(string tipo, string tipoPre, int numero)
        {
            Response<Documento> response = null;
            await Task.Run(() => {
                response = documentoService.GetByTipoPresupuestoAnu(tipo, tipoPre, numero);
            });
            return response;
        }
        public async Task<Response<Documento>> DocumentoGetByTipoNumeroAsync(string tipo, int numero)
        {
            Response<Documento> response = null;
            await Task.Run(() => {
                response = documentoService.GetByTipoNumero(tipo, numero);
            });
            return response;
        }

        public async Task<Response<Documento>> DocumentoGetByTipoNumeroSedeAsync(string tipo, int numero, int idSede)
        {
            Response<Documento> response = null;
            await Task.Run(() => {
                response = documentoService.GetByTipoNumeroSede(tipo, numero,idSede);
            });
            return response;
        }

        public async Task<Response<Documento>> DocumentoAnularAsync(Documento documento)
        {
            Response<Documento> response = null;
            await Task.Run(() =>
            {
                response = documentoService.Anular(documento);
            });
            return response;
        }

        public Response<Documento> DocumentoAnular(Documento documento)
        {
            return documentoService.Anular(documento);
        }

        public Response<List<Documento>> DocumentoGetAll()
        {
            return documentoService.GetAll();
        }

        public async Task<Response<List<Documento>>> DocumentoGetAllAsync()
        {
            Response<List<Documento>> response = null;
            await Task.Run(() =>
            {
                response = documentoService.GetAll();
            });
            return response;
        }

        public Response<Documento> DocumentoGetById(int? id)
        {
            return documentoService.GetById(id);
        }

        #endregion

        #region  EMPRESA 

        public Response<Empresa> EmpresaInsert(Empresa empresa)
        {
            return empresaService.Insert(empresa);
        }

        public Response<Empresa> EmpresaUpdate(Empresa empresa)
        {
            return empresaService.Update(empresa);
        }

        public Response<Empresa> EmpresaDelete(int id)
        {
            return empresaService.Delete(id);
        }

        public Response<Empresa> EmpresaGetById(int id)
        {
            return empresaService.GetById(id);
        }

        public Response<List<Empresa>> EmpresaGetAll()
        {
            return empresaService.GetAll();

        }

        public async Task<Response<Empresa>> EmpresaDeleteAsync(int id)
        {
            Response<Empresa> response = null;
            await Task.Run(() =>
            {
                response = empresaService.Delete(id);
            });
            return response;
        }

        public async Task<Response<Empresa>> EmpresaGetByIdAsync(int id)
        {
            Response<Empresa> response = null;
            await Task.Run(() =>
            {
                response = empresaService.GetById(id);
            });
            return response;
        }

        public async Task<Response<List<Empresa>>> EmpresaGetAllAsync()
        {
            Response<List<Empresa>> response = null;
            await Task.Run(() =>
            {
                response = empresaService.GetAll();
            });
            return response;
        }

        public async Task<Response<Empresa>> EmpresaInsertAsync(Empresa empresa)
        {
            Response<Empresa> response = null;
            await Task.Run(() =>
            {
                response = empresaService.Insert(empresa);
            });
            return response;
        }

        public async Task<Response<Empresa>> EmpresaUpdtadeAsync(Empresa empresa)
        {
            Response<Empresa> response = null;
            await Task.Run(() =>
            {
                response = empresaService.Update(empresa);
            });
            return response;
        }

        public List<Empresa> ComboEmpresa()
        {
            return empresaService.Listar();
        }

        public List<Puesto> PuestoGetAll()
        {
            return puestoService.GetAll().Value;
        }

        #endregion

        public List<Documento_Articulo> ArticulosByDocumento(int idDocumento)
        {
            return documentoService.GetDocumentoArticulo(idDocumento);
        }

        public async Task<Response<List<Documento>>> DocumentoGetAllReport(string tipo, string estado, DateTime fechaInicio, DateTime fechaFin,int numeroDocumento, string tipoPresu=null, Sede sede = null)
        {
            Response<List<Documento>> response = null;
            await Task.Run(() =>
            {
                response = documentoService.DocumentoGetAllReport(tipo, estado, fechaInicio, fechaFin,numeroDocumento, tipoPresu, sede);
            });
            return response;
        }

        public async Task<Response<List<Articulo>>> ListarArticuloByStock(int idArea, string nombreArticulo, bool conStock, bool bajoStock, bool sinStock, int idPuesto)
        {
            Response<List<Articulo>> response = null;
            await Task.Run(() =>
            {
                response = articuloService.ListarArticulosByStock(idArea, nombreArticulo, conStock, bajoStock, sinStock, idPuesto);
            });
            return response;
        }

        public Response<Usuario> UsuarioGetByUser(string nombreUsuario)
        {
            return usuarioService.GetByUser(nombreUsuario);
        }

        public Response<Documento> DocumentoUpdate(Documento documento, List<Documento_Articulo> newLst)
        {
            Response<Documento> response = new Response<Documento>();
            response = documentoService.Update(documento, newLst);
            return response;
        }

        public async Task<Response<Documento>> DocumentoUpdateAsync(Documento documento, List<Documento_Articulo> newLst)
        {
            Response<Documento> response = null;
            await Task.Run(() => {
                response = documentoService.Update(documento, newLst);
            });
            return response;
        }

        
    }
}
