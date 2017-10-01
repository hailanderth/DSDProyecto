using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.BE.Entidades;
using MD.GA.BL.Base;
using MD.GA.BL.BusinessServices;
using MD.GA.COMMOM.Response;

namespace MD.GA.SERVICES
{
    public interface IServiceAlmacen : IDisposable
    {
        //Usuario
        Response<Usuario> UsuarioGetByUser(string nombreUsuario);
        Response<Usuario> UsuarioValidarLogin(string usuario, string password);
        Response<DateTime> UsuarioGetServerDate();
        Response<Usuario> UsuarioGetById(int id);
        Response<Usuario> UsuarioDelete(int id);
        Response<List<Usuario>> UsuarioGetAll();
        Response<Usuario> UsuarioInsert(Usuario usuario);
        Response<Usuario> UsuarioUpdate(Usuario usuario);
        Task<Response<Usuario>> UsuarioValidarLoginAsync(string usuario, string password);
        Task<Response<DateTime>> UsuarioGetServerDateAsync();
        Task<Response<Usuario>> UsuarioGetByIdAsync(int id);
        Task<Response<Usuario>> UsuarioDeleteAsync(int id);
        Task<Response<List<Usuario>>> UsuarioGetAllAsync();
        Task<Response<Usuario>> UsuarioInsertAsync(Usuario usuario);
        Task<Response<Usuario>> UsuarioUpdateAsync(Usuario usuario);
        String GetPass(string clave);
        //Task<Response<String>> GetPassAsync(string clave);
        String GetPassDes(string clave);
        //Task<Response<String>> GetPassDesAsync(string clave);


        //Sede
        Response<Sede> SedeInsert(Sede sede);
        Response<Sede> SedeUpdate(Sede sede);
        Response<Sede> SedeDelete(int id);
        Response<Sede> SedeGetById(int id);
        Response<List<Sede>> SedeGetAll(); 
        Task<Response<Sede>> SedeInsertAsync(Sede sede);
        Task<Response<Sede>> SedeUpdtadeAsync(Sede sede);
        Task<Response<Sede>> SedeDeleteAsync(int id);
        Task<Response<Sede>> SedeGetByIdAsync(int id);
        Task<Response<List<Sede>>> SedeGetAllAsync();
        List<Sede> ComboSede();

        //Proveedor
        Response<Proveedor> ProveedorInsert(Proveedor provedor);
        Response<Proveedor> ProveedorUpdate(Proveedor provedor);
        Response<Proveedor> ProveedorDelete(int id);
        Response<Proveedor> ProveedorGetById(int id);
        Response<List<Proveedor>> ProveedorGetAll();
        Task<Response<Proveedor>> ProveedorInsertAsync(Proveedor provedor);
        Task<Response<Proveedor>> ProveedorUpdtadeAsync(Proveedor provedor);
        Task<Response<Proveedor>> ProveedorDeleteAsync(int id);
        Task<Response<Proveedor>> ProveedorGetByIdAsync(int id);
        Task<Response<List<Proveedor>>> ProveedorGetAllAsync();
        List<Proveedor> ComboProveedor();

        //Area
        Response<Area> AreaInsert(Area area);
        Response<Area> AreaUpdate(Area area);
        Response<Area> AreaDelete(int id);
        Response<Area> AreaGetById(int id);
        Response<List<Area>> AreaGetAll();
        Task<Response<Area>> AreaInsertAsync(Area area);
        Task<Response<Area>> AreaUpdtadeAsync(Area area);
        Task<Response<Area>> AreaDeleteAsync(int id);
        Task<Response<Area>> AreaGetByIdAsync(int id);
        Task<Response<List<Area>>> AreaGetAllAsync();
        List<Area> ComboArea();
        //Unidad de medida
        Response<UnidadMedida> UnidadMedidaInsert(UnidadMedida unidadmedida);
        Response<UnidadMedida> UnidadMedidaUpdate(UnidadMedida unidadmedida);
        Response<UnidadMedida> UnidadMedidaDelete(int id);
        Response<UnidadMedida> UnidadMedidaGetById(int id);
        Response<List<UnidadMedida>> UnidadMedidaGetAll();
        Task<Response<UnidadMedida>> UnidadMedidaInsertAsync(UnidadMedida unidadmedida);
        Task<Response<UnidadMedida>> UnidadMedidaUpdtadeAsync(UnidadMedida unidadmedida);
        Task<Response<UnidadMedida>> UnidadMedidaDeleteAsync(int id);
        Task<Response<UnidadMedida>> UnidadMedidaGetByIdAsync(int id);
        Task<Response<List<UnidadMedida>>> UnidadMedidaGetAllAsync();
        List<UnidadMedida> ComboUnidadMedida();

        //Articulo
        Response<Articulo> ArticuloInsert(Articulo articulo);
        Response<Articulo> ArticuloUpdate(Articulo articulo);
        Response<Articulo> ArticuloDelete(int id);
        Response<Articulo> ArticuloGetById(int id);
        Response<List<Articulo>> ArticuloGetAll();
        Task<Response<List<Articulo>>> ListarArticuloByStock(int idArea, string nombreArticulo, bool conStock, bool bajoStock, bool sinStock, int idPuesto);
        Task<Response<Articulo>> ArticuloInsertAsync(Articulo articulo);
        Task<Response<Articulo>> ArticuloUpdtadeAsync(Articulo articulo);
        Task<Response<Articulo>> ArticuloDeleteAsync(int id);
        Task<Response<Articulo>> ArticuloGetByIdAsync(int id);
        Task<Response<List<Articulo>>> ArticuloGetAllAsync();


        //Documento
        Response<Documento> DocumentoUpdate(Documento documento, List<Documento_Articulo> newLst);
        Task<Response<Documento>> DocumentoUpdateAsync(Documento documento, List<Documento_Articulo> newLst);
        Response<Documento> DocumentoInsert(Documento documento);
        Task<Response<Documento>> DocumentoInsertAsync(Documento documento);
        Response<Documento> DocumentoGetByTipoNumero(string tipo, int numero);
        Task<Response<Documento>> DocumentoGetByTipoNumeroAsync(string tipo, int numero);
        List<Documento_Articulo> ArticulosByDocumento(int idDocumento);
        Response<Documento> DocumentoUpdate(Documento documento);
        Task<Response<Documento>> DocumentoUpdateAsync(Documento documento);
        Task<Response<List<Documento>>> DocumentoGetAllReport(string tipo, string estado, DateTime fechaInicio, DateTime fechaFin, int numeroDocumento, string tipoPresu=null, Sede sede = null);
        Response<List<ListaEstadSalida_Resultado>> GetlistaEstSalida(DateTime fecIni, DateTime fecFin, int sede, int area, int articulo);
        Task<Response<List<ListaEstadSalida_Resultado>>> GetlistaEstSalidaAsync(DateTime fecIni, DateTime fecFin, int area, int articulo, int sede);
        Response<List<SP_LISTARREPORENTRADA_Result>> GetListaEntrada(DateTime fecIni, DateTime fecFin, int sede, int area);
        Task<Response<List<SP_LISTARREPORENTRADA_Result>>> GetListaEntradaAsync(DateTime fecIni, DateTime fecFin, int area, int articulo);
        


            //presupuesto
            Response<Documento> PresupuestoProcesado(string tipo, string tipoPre, int numero);
        Task<Response<Documento>> PresupuestoProcesadoAsync(string tipo, string tipoPre, int numero);
        Response<Documento> DocumentoGetByTipoPresupuesto(string tipo, string tipoPre, int numero);
        Task<Response<Documento>> DocumentoGetByTipoPresupuestoAsync(string tipo, string tipoPre, int numero);
        Response<Documento> DocumentoGetByTipoPresupuestoAnu(string tipo, string tipoPre, int numero);
        Task<Response<Documento>> DocumentoGetByTipoPresupuestoAnuAsync(string tipo, string tipoPre, int numero);
        Response<Documento> DocumentoGetByTipoNumeroSede(string tipo, int numero, int idSede);
        Task<Response<Documento>> DocumentoGetByTipoNumeroSedeAsync(string tipo, int numero, int idSede);
        Task<Response<Documento>> DocumentoAnularAsync(Documento documento);
        Response<Documento> DocumentoAnular(Documento documento);
        Task<Response<List<Documento>>> DocumentoGetAllAsync();
        Response<List<Documento>> DocumentoGetAll();
        Response<Documento> DocumentoGetById(int? id);

        //Empresa
        Response<Empresa> EmpresaInsert(Empresa empresa);
        Response<Empresa> EmpresaUpdate(Empresa empresa);
        Response<Empresa> EmpresaDelete(int id);
        Response<Empresa> EmpresaGetById(int id);
        Response<List<Empresa>> EmpresaGetAll();
        Task<Response<Empresa>> EmpresaDeleteAsync(int id);
        Task<Response<Empresa>> EmpresaGetByIdAsync(int id);
        Task<Response<List<Empresa>>> EmpresaGetAllAsync();
        Task<Response<Empresa>> EmpresaInsertAsync(Empresa empresa);
        Task<Response<Empresa>> EmpresaUpdtadeAsync(Empresa empresa);
        List<Empresa> ComboEmpresa();

        //Puesto

        List<Puesto> PuestoGetAll();


        //Banco
        Response<BANCO> BancoInsert(BANCO banco);
        Response<BANCO> BancoUpdate(BANCO banco);
        Response<BANCO> BancoDelete(int id);
        Response<BANCO> BancoGetById(int id);
        Response<BANCO> BancoGetById(int? id_Banco);
        Response<List<BANCO>> BancoGetAll();
        Task<Response<BANCO>> BancoInsertAsync(BANCO banco);
        Task<Response<BANCO>> BancoUpdateAsync(BANCO banco);
        Task<Response<BANCO>> BancoDeleteAsync(int id);
        Task<Response<BANCO>> BancoGetByIdAsync(int id);
        Task<Response<List<BANCO>>> BancoGetAllAsync();
        List<BANCO> ComboBanco();

        
        

        
        
    }
}
