using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MD.GA.SERVICES;
using MD.GA.BE.Entidades;
using MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.RazSocial;
using MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.Sedes;
using MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.Proveedores;
using MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.ManArea;
using MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.UniMedida;
using MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.Banco;

namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion
{
    public partial class Registrodeinformacion : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();
        private List<Empresa> listaEmpresa;
        private List<Sede> listaSede;
        private List<Proveedor> listaProveedores;
        private List<Area> listaArea;
        private List<UnidadMedida> listaUnidadMedida;
        private List<BANCO> listaBanco;

        public Registrodeinformacion()
        {
            InitializeComponent();
        }

        private void BtnArtbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Configuracion.Registro_de_Informacion.RazSocial.CrearRazSocial crearRazSoc = new RazSocial.CrearRazSocial();
            crearRazSoc.ShowDialog();
            this.Show();
        }

        private void BtnArtbutton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Configuracion.Registro_de_Informacion.Sedes.CrearSedes crearSedes = new Sedes.CrearSedes();
            crearSedes.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Configuracion.Registro_de_Informacion.Proveedores.CrearProveedor crearProveedor = new Proveedores.CrearProveedor();
            crearProveedor.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Configuracion.Registro_de_Informacion.ManArea.CrearArea crearArea = new ManArea.CrearArea();
            crearArea.ShowDialog();
            this.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Configuracion.Registro_de_Informacion.UniMedida.CrearUniMedida crearUniMedida = new UniMedida.CrearUniMedida();
            crearUniMedida.ShowDialog();
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        #region Carga de combos

        private async void CargarComboEmpresa()
        {
            try
            {
                List<Empresa> listaEmpresa;

                var responseComboEmpresa = await servicio.EmpresaGetAllAsync();
                listaEmpresa = responseComboEmpresa.Value;

                Empresa empresa = new Empresa
                {
                    Id_Empresa = 0,
                    RazonSocial = "--- Todos ---"
                };

                listaEmpresa.Insert(0, empresa);

                cboEmpresa.DataSource = listaEmpresa;
                cboEmpresa.DisplayMember = "RazonSocial";
                cboEmpresa.ValueMember = "Id_Empresa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarComboSede()
        {
            try
            {
                List<Sede> listaSede;
                var responseComboSede = await servicio.SedeGetAllAsync();
                listaSede = responseComboSede.Value;

                Sede sede = new Sede
                {
                    Id_Sede = 0,
                    NombreSede = "--- Todos ---"
                };

                listaSede.Insert(0, sede);
                cboSede.DataSource = listaSede;
                cboSede.DisplayMember = "NombreSede";
                cboSede.ValueMember = "Id_Sede";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarComboProveedor()
        {
            try
            {
                List<Proveedor> listaProveedor;

                var responseComboProveedor = await servicio.ProveedorGetAllAsync();
                listaProveedor = responseComboProveedor.Value;
                cboProveedor.DataSource = listaProveedor;

                Proveedor proveedor = new Proveedor
                {
                    Id_Proveedor = 0,
                    RazonSocial = "--- Todos ---"
                };

                listaProveedor.Insert(0, proveedor);
                cboProveedor.DisplayMember = "RazonSocial";
                cboProveedor.ValueMember = "Id_Proveedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarComboUnidadMedida()
        {
            try
            {
                List<UnidadMedida> listaUnidadMedida;

                var responseComboUnidadMedida = await servicio.UnidadMedidaGetAllAsync();
                listaUnidadMedida = responseComboUnidadMedida.Value;
                cboUnidadMedida.DataSource = listaUnidadMedida;

                UnidadMedida unidadMedida = new UnidadMedida
                {
                    Id_UnidadMedida = 0,
                    Descripcion = "--- Todos ---"
                };

                listaUnidadMedida.Insert(0, unidadMedida);
                cboUnidadMedida.DisplayMember = "Descripcion";
                cboUnidadMedida.ValueMember = "Id_UnidadMedida";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarComboArea()
        {
            try
            {
                List<Area> listaArea;

                var responseComboaArea = await servicio.AreaGetAllAsync();
                listaArea = responseComboaArea.Value;
                cboArea.DataSource = listaArea;

                Area area = new Area
                {
                    Id_Area = 0,
                    NombreArea = "--- Todos ---"
                };

                listaArea.Insert(0, area);
                cboArea.DisplayMember = "NombreArea";
                cboArea.ValueMember = "Id_Area";                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void CargarComboBanco()
        {
            try
            {
                List<BANCO> listaBanco;
                var responseBanco = await servicio.BancoGetAllAsync();
                listaBanco = responseBanco.Value;
                cboBanco.DataSource = listaBanco;

                BANCO banco = new BANCO
                {
                    Id_Banco = 0,
                    Nombre = "--- Todos ---"
                };

                listaBanco.Insert(0, banco);
                cboBanco.DisplayMember = "Nombre";
                cboBanco.ValueMember = "Id_Banco";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Configuraciones iniciales
        private void Registrodeinformacion_Load(object sender, EventArgs e)
        {
            ConfigurarGrillas();
            CargaCombos();
        }

        private void CargaCombos()
        {
            CargarComboArea();
            CargarComboEmpresa();
            CargarComboProveedor();
            CargarComboSede();
            CargarComboUnidadMedida();
            CargarComboBanco();
        }

        private void ConfigurarGrillas()
        {
            dgvArea.AutoGenerateColumns = false;
            dgvProveedor.AutoGenerateColumns = false;
            dgvEmpresa.AutoGenerateColumns = false;
            dgvSede.AutoGenerateColumns = false;
            dgvUnidadMedida.AutoGenerateColumns = false;
            dgvBanco.AutoGenerateColumns = false;
        }

        #endregion

        #region Cargar Grillas
        public async void CargarGrillaEmpresa()
        {
            var responseEmpresa = await servicio.EmpresaGetAllAsync();
            listaEmpresa = responseEmpresa.Value;
            dgvEmpresa.DataSource = listaEmpresa;

            foreach (DataGridViewRow row in dgvEmpresa.Rows)
            {
                string estado = row.Cells["EstadoEmpresa"].Value.ToString();

                row.Cells["EstadoModEmpresa"].Value = estado == "A" ? "Activo" : "Inactivo";
            }

        }

        public async void CargarGrillaSede()
        {
            var responseSede = await servicio.SedeGetAllAsync();
            listaSede = responseSede.Value;
            dgvSede.DataSource = listaSede;

              foreach (DataGridViewRow row in dgvSede.Rows)
              {
                    string estado = row.Cells["EstadoSede"].Value.ToString();

                    row.Cells["EstadoModSede"].Value = estado == "A" ? "Activo" : "Inactivo";
              }

              
        }

        public async void CargarGrillaProveedor()
        {
            var responseProveedor = await servicio.ProveedorGetAllAsync();
            listaProveedores = responseProveedor.Value;
            dgvProveedor.DataSource = listaProveedores;

            foreach (DataGridViewRow row in dgvProveedor.Rows)
            {
                string estado = row.Cells["EstadoProveedor"].Value.ToString();

                row.Cells["EstadoModProveedor"].Value = estado == "A" ? "Activo" : "Inactivo";
            }

        }
        public async void CargarGrillaArea()
        {
            var responseArea = await servicio.AreaGetAllAsync();
            listaArea = responseArea.Value;
            dgvArea.DataSource = listaArea;

            foreach (DataGridViewRow row in dgvArea.Rows)
            {
                string estado = row.Cells["EstadoArea"].Value.ToString();

                row.Cells["EstadoModArea"].Value = estado == "A" ? "Activo" : "Inactivo";
            }
        }

        public async void CargarGrillaUnidadMedida()
        {
            var responseUnidadMedida = await servicio.UnidadMedidaGetAllAsync();
            listaUnidadMedida = responseUnidadMedida.Value;
            dgvUnidadMedida.DataSource = listaUnidadMedida;

            foreach (DataGridViewRow row in dgvUnidadMedida.Rows)
            {
                string estado = row.Cells["EstadoUnidadMedida"].Value.ToString();

                row.Cells["EstadoModUnidadMedida"].Value = estado == "A" ? "Activo" : "Inactivo";
            }

        }
        public async void CargarGrillaBanco()
        {
            var responseBanco = await servicio.BancoGetAllAsync();
            listaBanco = responseBanco.Value;
            dgvBanco.DataSource = listaBanco;

            foreach (DataGridViewRow row in dgvBanco.Rows)
            {
                string estado = row.Cells["EstadoBanco"].Value.ToString();

                row.Cells["EstadoModBanco"].Value = estado == "A" ? "Activo" : "Inactivo";
            }

        }
        #endregion

        #region Eventos de grillas
        private void dgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idEmpresa = Convert.ToInt32(dgvEmpresa.CurrentRow.Cells["Id_Empresa"].Value);
            try
            {
                if (e.ColumnIndex == 1)
                {
                    Empresa empresa = (Empresa)dgvEmpresa.CurrentRow.DataBoundItem;
                    EditarRazSocial razonsocial = new EditarRazSocial(empresa);
                    razonsocial.ShowDialog();
                    CargarGrillaEmpresa();
                }
                else if (e.ColumnIndex == 2)
                {
                    if (servicio.EmpresaDelete(idEmpresa).IsValid)
                    {
                        MessageBox.Show("La empresa se eliminó correctamente");
                        CargarGrillaEmpresa();
                    }
                    else
                    {
                        MessageBox.Show("Hubo inconvenientes al eliminar la empresa, por favor intente nuevamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSede_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSede = Convert.ToInt32(dgvSede.CurrentRow.Cells["Id_Sede"].Value);
            try
            {
                if (e.ColumnIndex == 1)
                {
                    Sede sede = (Sede)dgvSede.CurrentRow.DataBoundItem;
                    ManEditarSede formSede = new ManEditarSede(sede);
                    formSede.ShowDialog();
                    CargarGrillaSede();
                }
                else if (e.ColumnIndex == 2)
                {
                    if (servicio.SedeDelete(idSede).IsValid)
                    {
                        MessageBox.Show("La sede se eliminó correctamente");
                        CargarGrillaSede();
                    }
                    else
                    {
                        MessageBox.Show("Hubo inconvenientes al eliminar la sede, por favor intente nuevamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProveedor = Convert.ToInt32(dgvProveedor.CurrentRow.Cells["Id_Proveedor"].Value);
            try
            {
                if (e.ColumnIndex == 1)
                {
                    Proveedor proveedor = (Proveedor)dgvProveedor.CurrentRow.DataBoundItem;
                    EditarProveedor formProveedor = new EditarProveedor(proveedor);
                    formProveedor.ShowDialog();
                    CargarGrillaProveedor();
                }
                else if (e.ColumnIndex == 2)
                {
                    if (servicio.ProveedorDelete(idProveedor).IsValid)
                    {
                        MessageBox.Show("El proveedor se eliminó correctamente");
                        CargarGrillaProveedor();
                    }
                    else
                    {
                        MessageBox.Show("Hubo inconvenientes al eliminar el proveedor, por favor intente nuevamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idArea = Convert.ToInt32(dgvArea.CurrentRow.Cells["Id_Area"].Value);
            try
            {
                if (e.ColumnIndex == 1)
                {
                    Area area = (Area)dgvArea.CurrentRow.DataBoundItem;
                    EditarArea formArea = new EditarArea(area);
                    formArea.ShowDialog();
                    CargarGrillaArea();
                }
                else if (e.ColumnIndex == 2)
                {
                    if (servicio.AreaDelete(idArea).IsValid)
                    {
                        MessageBox.Show("El área se eliminó correctamente");
                        CargarGrillaArea();
                    }
                    else
                    {
                        MessageBox.Show("Hubo inconvenientes al eliminar el área, por favor intente nuevamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUnidadMedida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idUnidadMedida = Convert.ToInt32(dgvUnidadMedida.CurrentRow.Cells["Id_UnidadMedida"].Value);
            try
            {
                if (e.ColumnIndex == 1)
                {
                    UnidadMedida unidadMedida = (UnidadMedida)dgvUnidadMedida.CurrentRow.DataBoundItem;
                    EditarUniMedida formUnidadMedida = new EditarUniMedida(unidadMedida);
                    formUnidadMedida.ShowDialog();
                    CargarGrillaUnidadMedida();
                }
                else if (e.ColumnIndex == 2)
                {
                    if (servicio.UnidadMedidaDelete(idUnidadMedida).IsValid)
                    {
                        MessageBox.Show("La unidad de medida se eliminó correctamente");
                        CargarGrillaUnidadMedida();
                    }
                    else
                    {
                        MessageBox.Show("Hubo inconvenientes al eliminar la unidad de medida, por favor intente nuevamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvBanco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idBanco = Convert.ToInt32(dgvBanco.CurrentRow.Cells["Id_Banco"].Value);
            try
            {
                if (e.ColumnIndex == 1)
                {
                    BANCO banco = (BANCO)dgvBanco.CurrentRow.DataBoundItem;
                    EditarBanco formBanco = new EditarBanco(banco);
                    formBanco.ShowDialog();  
                    CargarGrillaBanco();
                }
                else if (e.ColumnIndex == 2)
                {
                    if (servicio.BancoDelete(idBanco).IsValid)
                    {
                        MessageBox.Show("El banco se eliminó correctamente");                        
                        CargarGrillaBanco();                        
                    }
                    else
                    {
                        MessageBox.Show("Hubo inconvenientes al eliminar el banco, por favor intente nuevamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Acciones boton buscar

        private void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            List<Empresa> listaEmpresa = new List<Empresa>();

            if (cboEmpresa.SelectedIndex == 0)
            {
                listaEmpresa = servicio.EmpresaGetAll().Value;
            }
            else
            {
                int idEmpresa = Convert.ToInt32(cboEmpresa.SelectedValue);
                Empresa empresa = servicio.EmpresaGetById(idEmpresa).Value;
                listaEmpresa.Add(empresa);
            }

            dgvEmpresa.DataSource = listaEmpresa;

            foreach (DataGridViewRow row in dgvEmpresa.Rows)
            {
                string estado = row.Cells["EstadoEmpresa"].Value.ToString();

                row.Cells["EstadoModEmpresa"].Value = estado == "A" ? "Activo" : "Inactivo";
            }
        }

        private void btnBuscarSedes_Click(object sender, EventArgs e)
        {
    
            List<Sede> listaSede = new List<Sede>();

            if(cboSede.SelectedIndex == 0)
            {
                listaSede = servicio.SedeGetAll().Value;
            }
            else
            {
                int idSede = Convert.ToInt32(cboSede.SelectedValue);
                Sede sede = servicio.SedeGetById(idSede).Value;
                listaSede.Add(sede);
            }
            
            dgvSede.DataSource = listaSede;

            foreach (DataGridViewRow row in dgvSede.Rows)
            {
                string estado = row.Cells["EstadoSede"].Value.ToString();

                row.Cells["EstadoModSede"].Value = estado == "A" ? "Activo" : "Inactivo";
            }
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {

            List<Proveedor> listaProveedor = new List<Proveedor>();

            if (cboProveedor.SelectedIndex == 0)
            {
                listaProveedor = servicio.ProveedorGetAll().Value;
            }
            else
            {
                int idProveedor = Convert.ToInt32(cboProveedor.SelectedValue);
                Proveedor proveedor = servicio.ProveedorGetById(idProveedor).Value;
                listaProveedor.Add(proveedor);
            }

            dgvProveedor.DataSource = listaProveedor;

            foreach (DataGridViewRow row in dgvProveedor.Rows)
            {
                string estado = row.Cells["EstadoProveedor"].Value.ToString();

                row.Cells["EstadoModProveedor"].Value = estado == "A" ? "Activo" : "Inactivo";
            }
        }

        private void btnBuscarArea_Click(object sender, EventArgs e)
        {

            List<Area> listaArea = new List<Area>();

            if(cboArea.SelectedIndex == 0)
            {
                listaArea = servicio.AreaGetAll().Value;
            }
            else
            {
                int idArea = Convert.ToInt32(cboArea.SelectedValue);
                Area area = servicio.AreaGetById(idArea).Value;
                listaArea.Add(area);
            }

            dgvArea.DataSource = listaArea;

            foreach (DataGridViewRow row in dgvArea.Rows)
            {
                string estado = row.Cells["EstadoArea"].Value.ToString();

                row.Cells["EstadoModArea"].Value = estado == "A" ? "Activo" : "Inactivo";
            }
        }

        private void btnBuscarUnidadMedida_Click(object sender, EventArgs e)
        {

            List<UnidadMedida> listaUnidadMedida = new List<UnidadMedida>();

            if(cboUnidadMedida.SelectedIndex ==0)
            {
                listaUnidadMedida = servicio.UnidadMedidaGetAll().Value;
            }
            else
            {
                int idUnidadMedida = Convert.ToInt32(cboUnidadMedida.SelectedValue);
                UnidadMedida unidadMedida = servicio.UnidadMedidaGetById(idUnidadMedida).Value;
                listaUnidadMedida.Add(unidadMedida);
            }
            
            dgvUnidadMedida.DataSource = listaUnidadMedida;

            foreach (DataGridViewRow row in dgvUnidadMedida.Rows)
            {
                string estado = row.Cells["EstadoUnidadMedida"].Value.ToString();

                row.Cells["EstadoModUnidadMedida"].Value = estado == "A" ? "Activo" : "Inactivo";
            }

        }
        private void btnBuscarBanco_Click(object sender, EventArgs e)
        {
            List<BANCO> listaBanco = new List<BANCO>();

            if (cboBanco.SelectedIndex == 0)
            {
                listaBanco = servicio.BancoGetAll().Value;
            }
            else
            {
                int idBanco = Convert.ToInt32(cboBanco.SelectedValue);
                BANCO banco = servicio.BancoGetById(idBanco).Value;
                listaBanco.Add(banco);
            }

            dgvBanco.DataSource = listaBanco;

            foreach (DataGridViewRow row in dgvBanco.Rows)
            {
                string estado = row.Cells["EstadoBanco"].Value.ToString();

                row.Cells["EstadoModBanco"].Value = estado == "A" ? "Activo" : "Inactivo";
            }
        }


        #endregion

        private void btnNuevoBanco_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Configuracion.Registro_de_Informacion.Banco.CrearBanco crearBanco = new Banco.CrearBanco();
            crearBanco.ShowDialog();
            this.Show();
        }

        private void btnSalirBanco_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
