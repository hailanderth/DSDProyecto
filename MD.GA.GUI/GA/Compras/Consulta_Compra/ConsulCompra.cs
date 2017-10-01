using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MD.GA.SERVICES;
using MD.GA.BE.Entidades;
using System.Threading;
using System.Globalization;
using System.Reflection;
using MD.GA.GUI.Session;

namespace MD.GA.GUI.GA.Compras.Consulta_Compra
{
    public partial class ConsulCompra : Form
    {
        private List<Documento> listaNumDocumento;
        private String valor = "";
        private Documento documento;
        public ConsulCompra()
        {
            InitializeComponent();
        }
        private async void LoadComboSede()
        {
            try
            {
                IServiceAlmacen service = new ServiceAlmacen();
                var response = await service.SedeGetAllAsync();
                if (response.IsValid)
                {
                    List<Sede> lstSede = response.Value;
                    lstSede.Insert(0, new Sede() { Id_Sede = 0, Codigo = "[--Todas--]" });
                    cboSede.DataSource = lstSede;
                    cboSede.DisplayMember = "Codigo";
                }
                else
                {
                    MessageBox.Show(response.ErrorMensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void EnableControlsByRol()
        {
            if (CurrentSession.Usuario.Id_Puesto == (int)Roles.Administrador)
            {
                btnCondSal2.Visible = true;
            }
            else if (CurrentSession.Usuario.Id_Puesto == (int)Roles.Operador)
            {
                DisableExportFormats(rptPresupuesto, "EXCELOPENXML");
                DisableExportFormats(rptPresupuesto, "WORDOPENXML");
                DisableExportFormats(rptConsultaSalida, "EXCELOPENXML");
                DisableExportFormats(rptConsultaSalida, "WORDOPENXML");
                DisableExportFormats(rptOdenCompra, "WORDOPENXML");
                DisableExportFormats(rptOdenCompra, "EXCELOPENXML");
                btnCondSal2.Visible = false;
            }
        }
        public void DisableExportFormats(ReportViewer ReportViewerID, string strFormatName)
        {
            FieldInfo info;
            foreach (RenderingExtension extension in ReportViewerID.LocalReport.ListRenderingExtensions())
            {
                if (extension.Name.Trim().ToUpper() == strFormatName.Trim().ToUpper())
                {
                    info = extension.GetType().GetField("m_isVisible", BindingFlags.Instance | BindingFlags.NonPublic);
                    info.SetValue(extension, false);
                }
            }

        }
        private void ConsulCompra_Load(object sender, EventArgs e)
        {
            Init();
            SetIndexCombo();
            EnableControlsByRol();
            HideControls();
            LoadComboSede();

        }

        private void Init()
        {
            dgvDocumentos.AutoGenerateColumns = false;
        }

        private void SetIndexCombo()
        {
            cboTipoPre.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            cboTipoDoc.SelectedIndex = 0;
        }

        private void HideControls()
        {
            cboTipoPre.Visible = false;
            rptPresupuesto.Visible = false;
            rptOdenCompra.Visible = false;
            rptConsultaSalida.Visible = false;
        }

        private void btnConsulCom1_Click(object sender, EventArgs e)
        {
            loadDocumento();
        }

        private void btnConCom2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MostrarControlTipo(string tipo)
        {
            txtNumd.Text = "";

            btnConCom1.Enabled = true;
            switch (tipo)
            {
                case "RS":
                    cboSede.Visible = true;
                    cboTipoPre.Visible = false;
                    txtTipodoc.Visible = false;
                    break;
                case "PR":
                    cboTipoPre.Visible = true;
                    cboSede.Visible = false;
                    txtTipodoc.Visible = false;
                    break;
                case "OD":
                    cboTipoPre.Visible = true;
                    cboSede.Visible = false;
                    break;
                case "TODOS":
                    cboTipoPre.Visible = false;
                    cboSede.Visible = false;
                    txtTipodoc.Visible = false;
                    break;
            }
        }
        private void LoadComboNumDocumento()
        {
            try
            {
                if (cboTipoDoc.SelectedItem.ToString() == "PRESUPUESTO")
                {
                    valor = "PR";
                    MostrarControlTipo(valor);

                }
                else if (cboTipoDoc.SelectedItem.ToString() == "REGISTRO DE SALIDA")
                {
                    valor = "RS";
                    MostrarControlTipo(valor);

                }
                else if (cboTipoDoc.SelectedItem.ToString() == "ORDEN DE COMPRA")
                {
                    valor = "OD";
                    MostrarControlTipo(valor);

                }
                else if (cboTipoDoc.SelectedIndex == 0)
                {
                    valor = "TODOS";
                    MostrarControlTipo("TODOS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public async void loadDocumento()
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date.AddDays(1);
            int nroDocumento;
            if (!txtNumd.Text.Trim().Equals(String.Empty))
            {
                nroDocumento = Convert.ToInt16(txtNumd.Text);
            }
            else
            {
                nroDocumento = 0;
            }
            string estado = "";
            switch (cboEstado.SelectedIndex)
            {
                case 0: estado = "T"; break;
                case 1: estado = "A"; break;
                case 2: estado = "I"; break;
            }

            if (valor == "TODOS")
            {
                string tipoDocumento = valor;
                IServiceAlmacen service = new ServiceAlmacen();
                var response = await service.DocumentoGetAllReport(tipoDocumento, estado, fechaInicio, fechaFin, nroDocumento);
                List<Documento> listaDocumento = response.Value;
                List<DocumentoDetalle> listaDetalles = new List<DocumentoDetalle>();
                foreach (Documento d in listaDocumento)
                {
                    DocumentoDetalle det = new DocumentoDetalle(d);
                    listaDetalles.Add(det);
                }
                dgvDocumentos.DataSource = listaDetalles;
            }
            else if (valor == "PR")
            {
                string tipoDocumento = valor;
                string tipoPre = "";
                if ((string)cboTipoPre.SelectedItem == "VAR") { tipoPre = "VAR"; }
                if ((string)cboTipoPre.SelectedItem == "PLA") { tipoPre = "PLA"; }
                if ((string)cboTipoPre.SelectedItem == "LAB") { tipoPre = "LAB"; }
                IServiceAlmacen service = new ServiceAlmacen();
                var response = await service.DocumentoGetAllReport(tipoDocumento, estado, fechaInicio, fechaFin, nroDocumento, tipoPre);
                if (response.IsValid)
                {
                    List<Documento> listaDocumento = response.Value;
                    List<DocumentoDetalle> listaDetalles = new List<DocumentoDetalle>();
                    foreach (Documento d in listaDocumento)
                    {
                        DocumentoDetalle det = new DocumentoDetalle(d);
                        listaDetalles.Add(det);
                    }
                    dgvDocumentos.DataSource = listaDetalles;
                }
                else
                {
                    MessageBox.Show(response.ErrorMensaje);
                }
            }
            else if (valor == "RS")
            {
                string tipoDocumento = "RS";
                Sede sede = cboSede.SelectedItem as Sede;
                IServiceAlmacen service = new ServiceAlmacen();
                var response = await service.DocumentoGetAllReport(tipoDocumento, estado, fechaInicio, fechaFin, nroDocumento, "", sede);
                List<Documento> listaDocumento = response.Value;
                List<DocumentoDetalle> listaDetalles = new List<DocumentoDetalle>();
                foreach (Documento d in listaDocumento)
                {
                    DocumentoDetalle det = new DocumentoDetalle(d);
                    listaDetalles.Add(det);
                }
                dgvDocumentos.DataSource = listaDetalles;
            }
            else if (valor == "OD")
            {
                string tipoDocumento = "OC";
                string tipoPre = string.Empty;
                if ((string)cboTipoPre.SelectedItem == "VAR") { tipoPre = "VAR"; }
                if ((string)cboTipoPre.SelectedItem == "PLA") { tipoPre = "PLA"; }
                if ((string)cboTipoPre.SelectedItem == "LAB") { tipoPre = "LAB"; }

                IServiceAlmacen service = new ServiceAlmacen();
                var response = await service.DocumentoGetAllReport(tipoDocumento, estado, fechaInicio, fechaFin, nroDocumento, tipoPre);

                if (response.IsValid)
                {
                    List<Documento> listaDocumento = response.Value;
                    List<DocumentoDetalle> listaDetalles = new List<DocumentoDetalle>();
                    foreach (Documento d in listaDocumento)
                    {
                        DocumentoDetalle det = new DocumentoDetalle(d);
                        listaDetalles.Add(det);
                    }
                    dgvDocumentos.DataSource = listaDetalles;
                }
                else
                {
                    MessageBox.Show(response.ErrorMensaje);
                }
            }
        }

        private class DocumentoDetalle : Documento
        {
            public DocumentoDetalle(Documento doc)
            {
                this.TipoDocumento = doc.TipoDocumento;
                this.TipoPresupuesto = doc.TipoPresupuesto;
                this.NroDocumento = doc.NroDocumento;
                this.UsuarioCreacion = doc.UsuarioCreacion;
                this.FechaCreacion = doc.FechaCreacion;
                this.Estado = doc.Estado;
                this.FechaModificacion = doc.FechaModificacion;
                this.UsuarioModificacion = doc.UsuarioModificacion;
                this.Sede = doc.Sede;
                this.Documento_Articulo = doc.Documento_Articulo;
            }
            public String Detalle
            {
                get
                {
                    switch (this.TipoDocumento)
                    {
                        case "RS": return this.Sede.NombreSede;
                    }
                    return "";
                }
            }
            public String Detalle2
            {
                get
                {
                    switch (this.TipoDocumento)
                    {
                        case "PR":
                        case "OC":
                            switch (this.TipoPresupuesto)
                            {
                                case "VAR": return "Varios";
                                case "PLA": return "Placas";
                                case "LAB": return "Laboratorios";
                            }
                            return "";
                    }
                    return "";
                }
            }

            public String EstadoDocumento
            {
                get
                {
                    switch (this.TipoDocumento)
                    {
                        case "RS":
                        case "OC":
                            switch (this.Estado)
                            {
                                case "A": return "Activo";
                                case "I": return "Anulado";
                            }
                            return "";
                        case "PR":
                            switch (this.Estado)
                            {
                                case "A": return "Activo";
                                case "I": return "Anulado";
                                case "P": return "Procesado";
                            }
                            return "";
                    }
                    return "";
                }
            }

        }


        private void cbBConCom1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComboNumDocumento();

        }

        private void btnCondSal2_Click(object sender, EventArgs e)
        {
            DocumentoDetalle det = dgvDocumentos.SelectedRows[0].DataBoundItem as DocumentoDetalle;



            switch (det.TipoDocumento)
            {
                case "RS":
                    try
                    {
                        if (det.Estado == "A")
                        {
                            DialogResult dialog = MessageBox.Show("¿Seguro de eliminar el registro de salida RS-" + det.Sede.Codigo + "-" + det.NroDocumento.ToString("00000000") + "\n Esta operación no se podra revertir", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (DialogResult.Yes == dialog)
                            {
                                IServiceAlmacen service = new ServiceAlmacen();
                                var responseDoc = service.DocumentoGetByTipoNumeroSede(det.TipoDocumento, det.NroDocumento, det.Sede.Id_Sede);
                                documento = responseDoc.Value;
                                documento.UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1;
                                var response = service.DocumentoAnular(documento);
                                if (response.IsValid)
                                {
                                    MessageBox.Show("Documento anulado correctamente", "Aviso");
                                    rptConsultaSalida.Clear();
                                    loadDocumento();
                                }
                                else
                                {
                                    MessageBox.Show(response.ErrorMensaje, "No se anulo el documento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El documento se encuentra anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error " + ex.Message, "Aviso");
                    }
                    break;

                case "PR":
                    try
                    {
                        if (det.Estado == "A" || det.Estado == "P")
                        {
                            DialogResult dialog = MessageBox.Show("¿Seguro de eliminar el presupuesto N° PR - " + det.TipoPresupuesto + " - " + det.NroDocumento.ToString("0000000") + "\n Esta operación no se podra revertir", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (DialogResult.Yes == dialog)
                            {
                                IServiceAlmacen service = new ServiceAlmacen();
                                var responseDoc = service.DocumentoGetByTipoPresupuesto(det.TipoDocumento, det.TipoPresupuesto, det.NroDocumento);
                                documento = responseDoc.Value;
                                documento.UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1;
                                var response = service.DocumentoAnular(documento);
                                if (response.IsValid)
                                {
                                    MessageBox.Show("Documento anulado correctamente", "Aviso");
                                    loadDocumento();
                                }
                                else
                                {
                                    MessageBox.Show(response.ErrorMensaje, "No se anulo el documento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("El documento se encuentra anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error " + ex.Message, "Aviso");
                    }
                    break;

                case "OC":
                    try
                    {
                        if (det.Estado == "A")
                        {
                            DialogResult dialog = MessageBox.Show("¿Seguro de eliminar la orden de compra N° OC -" + det.TipoPresupuesto + " - " + det.NroDocumento.ToString("000000") + "\n Esta operación no se podra revertir", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (DialogResult.Yes == dialog)
                            {
                                IServiceAlmacen service = new ServiceAlmacen();
                                var responseDoc = service.DocumentoGetByTipoPresupuesto(det.TipoDocumento, det.TipoPresupuesto, det.NroDocumento);
                                documento = responseDoc.Value;
                                documento.UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1;
                                var response = service.DocumentoAnular(documento);
                                if (response.IsValid)
                                {
                                    MessageBox.Show("Documento anulado correctamente", "Aviso");
                                    loadDocumento();
                                }
                                else
                                {
                                    MessageBox.Show(response.ErrorMensaje, "No se anulo el documento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error " + ex.Message, "Aviso");
                    }
                    break;
            }
        }

        private void txtNumd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }


        private async void dgvDocumentos_DoubleClick(object sender, EventArgs e)
        {
            DocumentoDetalle doc = dgvDocumentos.SelectedRows[0].DataBoundItem as DocumentoDetalle;
            

            if (doc.TipoDocumento == "RS")
            {
                IServiceAlmacen service = new ServiceAlmacen();

                var response = await service.DocumentoGetByTipoNumeroSedeAsync("RS", Convert.ToInt16(doc.NroDocumento), doc.Sede.Id_Sede);
                if (response.IsValid)
                {
                    Usuario usuarioCreador = new Usuario();
                    rptConsultaSalida.Visible = true;
                    rptConsultaSalida.BringToFront();
                    btnCloseReport.Visible = true;
                    btnCloseReport.Parent = rptConsultaSalida;
                    btnCloseReport.BringToFront();
                    documento = response.Value;

                    var responseUsuario = service.UsuarioGetByUser(documento.UsuarioCreacion);
                    usuarioCreador = responseUsuario.Value;            
                    string nombreUsuario = usuarioCreador.Nombres + " " + usuarioCreador.Apellidos;

                    rptConsultaSalida.ProcessingMode = ProcessingMode.Local;
                    rptConsultaSalida.LocalReport.DataSources.Clear();
                    ReportDataSource Reporte = new ReportDataSource("DataSet1", documento.Documento_Articulo);
                    rptConsultaSalida.LocalReport.DataSources.Add(Reporte);

                    List<ReportParameter> parametros = new List<ReportParameter>();
                    parametros.Add(new ReportParameter("nombreSede", "" + documento.Sede.NombreSede));
                    parametros.Add(new ReportParameter("nombreDocumento", "RS-" + documento.Sede.Codigo + "-" + documento.NroDocumento.ToString("0000000")));
                    parametros.Add(new ReportParameter("nombreUsuario",nombreUsuario));
                    parametros.Add(new ReportParameter("fechaCreacion", "" + documento.FechaCreacion));
                    //Añado parametros al reportviewer
                    this.rptConsultaSalida.LocalReport.SetParameters(parametros);

                    rptConsultaSalida.RefreshReport();
                    rptConsultaSalida.Focus();
                }
                else
                {
                    MessageBox.Show(response.ErrorMensaje);
                }
            }
            else if (doc.TipoDocumento == "PR")
            {
                IServiceAlmacen service = new ServiceAlmacen();

                var response = await service.DocumentoGetByTipoPresupuestoAsync(doc.TipoDocumento, doc.TipoPresupuesto, Convert.ToInt16(doc.NroDocumento));
                if (response.IsValid)
                {
                    Usuario usuarioCreador = new Usuario();
                    rptPresupuesto.Visible = true;
                    rptPresupuesto.BringToFront();
                    btnCloseReport.Visible = true;
                    btnCloseReport.Parent = rptPresupuesto;
                    btnCloseReport.BringToFront();
                    documento = response.Value;
                                        
                    var responseUsuario = service.UsuarioGetByUser(documento.UsuarioCreacion);
                    usuarioCreador = responseUsuario.Value;
                    string nombreUsuario = usuarioCreador.Nombres + " " + usuarioCreador.Apellidos;

                    rptPresupuesto.ProcessingMode = ProcessingMode.Local;
                    rptPresupuesto.LocalReport.DataSources.Clear();
                    ReportDataSource Reporte = new ReportDataSource("DataSet1", documento.Documento_Articulo);
                    rptPresupuesto.LocalReport.DataSources.Add(Reporte);
                    ReportDataSource Reporte2 = new ReportDataSource("DataSet2", documento.Documento_Articulo);
                    rptPresupuesto.LocalReport.DataSources.Add(Reporte2);
                    string moneda = "";
                    string estado = "";
                    if (documento.Moneda == "S") { moneda = "S/. "; } else { moneda = "US$ "; }
                    if (documento.Estado == "A") { estado = "PENDIENTE"; } else if (documento.Estado == "P") { estado = "PROCESADO"; } else { estado = "ANULADO"; }
                    List<ReportParameter> parametros = new List<ReportParameter>();
                    parametros.Add(new ReportParameter("nombreDocumento", "N° PR - " + documento.TipoPresupuesto + " - " + documento.NroDocumento.ToString("0000000")));
                    parametros.Add(new ReportParameter("nombreUsuario", nombreUsuario));
                    parametros.Add(new ReportParameter("fechaCreacion", documento.FechaCreacion.ToString("hh:mm:ss - MM/dd/yyyy ")));
                    parametros.Add(new ReportParameter("moneda", moneda));
                    parametros.Add(new ReportParameter("estado", estado));

                    this.rptPresupuesto.LocalReport.SetParameters(parametros);
                    rptPresupuesto.RefreshReport();
                    rptPresupuesto.Focus();
                }
                else
                {
                    MessageBox.Show(response.ErrorMensaje);
                }
            }
            else if (doc.TipoDocumento == "OC")
            {

                IServiceAlmacen service = new ServiceAlmacen();

                var response = await service.DocumentoGetByTipoPresupuestoAsync(doc.TipoDocumento, doc.TipoPresupuesto, Convert.ToInt16(doc.NroDocumento));
                if (response.IsValid)
                {
                    Documento presupuesto = new Documento();
                    Usuario usuarioCreador = new Usuario();
                    rptOdenCompra.Visible = true;
                    btnCloseReport.Parent = rptOdenCompra;
                    btnCloseReport.BringToFront();
                    rptOdenCompra.BringToFront();
                    btnCloseReport.Visible = true;
                    
                    documento = response.Value;
                    var responsePresupuesto = service.DocumentoGetById(documento.Id_DocumentoOrigen);
                    var responseUsuario = service.UsuarioGetByUser(documento.UsuarioCreacion);
              
                    presupuesto = responsePresupuesto.Value;
                    usuarioCreador = responseUsuario.Value;

                    rptOdenCompra.ProcessingMode = ProcessingMode.Local;
                    rptOdenCompra.LocalReport.DataSources.Clear();
                    ReportDataSource Reporte = new ReportDataSource("DataSet1", documento.Documento_Articulo);
                    rptOdenCompra.LocalReport.DataSources.Add(Reporte);
                    string estado = "";
                    if (documento.Estado == "A") { estado = "GENERADO"; } else { estado = "ANULADO"; }
                    List<ReportParameter> parametros = new List<ReportParameter>();
                    string nroOrden = "N° OC - " + documento.TipoPresupuesto + " - " + documento.NroDocumento.ToString("0000000");
                    //string nombres = Session.CurrentSession.Usuario.Nombres + " " + Session.CurrentSession.Usuario.Apellidos;
                    string nombres = usuarioCreador.Nombres + " " + usuarioCreador.Apellidos;
                    string fecha = documento.FechaCreacion.ToString("hh:mm:ss - MM/dd/yyyy ");
                    string est = estado;
                    string moneda = string.Empty;
                    if (presupuesto.Moneda == "S") { moneda = "S/. "; } else { moneda = "US$ "; }
                    string nroPrespuesto = "N° PR - " + presupuesto.TipoPresupuesto + " - " + presupuesto.NroDocumento.ToString("0000000");
                    string totalPresupuesto = moneda + string.Format("{0:0.0000}", documento.MontoDisponible);
                    string totalOrdenCompra = moneda + string.Format("{0:0.0000}", documento.MontoTotal);
                    string montoDisponible = moneda + string.Format("{0:0.0000}", documento.MontoDisponible - documento.MontoTotal); 
                    parametros.Add(new ReportParameter("nroOrdenCompra", nroOrden));
                    parametros.Add(new ReportParameter("nombre", nombres));
                    parametros.Add(new ReportParameter("fechaCreacion", fecha));
                    parametros.Add(new ReportParameter("estado", est));
                    parametros.Add(new ReportParameter("nroPresupuesto", nroPrespuesto));
                    parametros.Add(new ReportParameter("totalPresupuesto", totalPresupuesto));
                    parametros.Add(new ReportParameter("totalOrdenCompra", totalOrdenCompra));
                    parametros.Add(new ReportParameter("montoDisponible", montoDisponible));
                    this.rptOdenCompra.LocalReport.SetParameters(parametros);
                    rptOdenCompra.RefreshReport();
                    rptOdenCompra.Focus();
                }
                else
                {
                    MessageBox.Show(response.ErrorMensaje);
                }
            }
        }

        private void btnCloseReport_Click(object sender, EventArgs e)
        {
            if (rptConsultaSalida.Visible || rptPresupuesto.Visible || rptOdenCompra.Visible)
            {
                rptConsultaSalida.Visible = false;
                btnCloseReport.Visible = false;
                rptPresupuesto.Visible = false;
                rptOdenCompra.Visible = false;
            }
        }

        private void dgvDocumentos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewCellStyle green = this.dgvDocumentos.DefaultCellStyle.Clone();
            green.BackColor = Color.DarkGreen;
            green.ForeColor = Color.White;
            green.Font = new Font(green.Font, FontStyle.Bold);

            DataGridViewCellStyle red = this.dgvDocumentos.DefaultCellStyle.Clone();
            red.BackColor = Color.DarkRed;
            red.ForeColor = Color.White;
            red.Font = new Font(red.Font, FontStyle.Bold);

            DataGridViewCellStyle blue = this.dgvDocumentos.DefaultCellStyle.Clone();
            blue.BackColor = Color.DarkBlue;
            blue.ForeColor = Color.White;
            blue.Font = new Font(blue.Font, FontStyle.Bold);

            foreach (DataGridViewRow r in this.dgvDocumentos.Rows)
            {

                if (r.Cells["EstadoBD"].Value.ToString() == "I")
                {
                    r.DefaultCellStyle = red;

                }
                else if (r.Cells["EstadoBD"].Value.ToString() == "A")
                {
                    r.DefaultCellStyle = green;
                }
                else
                {
                    r.DefaultCellStyle = blue;
                }
            }
        }
    }
}
