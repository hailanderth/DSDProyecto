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
using System.Globalization;
using System.Threading;
using Microsoft.Reporting.WinForms;
using System.Reflection;
using MD.GA.GUI.Session;

namespace MD.GA.GUI.GA.Almacen.Est_Egreso
{
    public partial class RptEstadEgreso : Form
    {
        private List<Area> listaArea;
        private List<Articulo> listaArticulo;
        private List<Sede> listaSede;
        private DateTime fecini;
        private DateTime fecfin;
        private int sede = 0;
        private int area = 0;
        private int articulo = 0;
        private List<ListaEstadSalida_Resultado> LstResultado;

        public RptEstadEgreso()
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
                    lstSede.Insert(0, new Sede() { Id_Sede = 0, NombreSede = "[--Todos--]" });
                    cboSede.DataSource = lstSede;
                    cboSede.DisplayMember = "NombreSede";
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
        private async void LoadAreas()
        {
            try
            {
                IServiceAlmacen service = new ServiceAlmacen();
                var responseArea = await service.AreaGetAllAsync();
                var responseArticulo = await service.ArticuloGetAllAsync();

                if (responseArea.IsValid && responseArticulo.IsValid)
                {
                    listaArticulo = responseArticulo.Value;
                    listaArea = responseArea.Value;
                    List<Area> lstArea = listaArea;
                    lstArea.Insert(0, new Area() { Id_Area = 0, CodArea = "[--Todos--]" });
                    cboArea.DataSource = lstArea;
                    cboArea.DisplayMember = "CodArea";
                }
                else
                {
                    MessageBox.Show(responseArticulo.ErrorMensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarCombos(ComboBox box)
        {
            box.AutoCompleteSource = AutoCompleteSource.ListItems;
            box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
       
        
        private void RptEstadEgreso_Load(object sender, EventArgs e)
        {
            ConfigurarCombos(cboSede);
            ConfigurarCombos(cboArea);
            ConfigurarCombos(cboArticulo);
            LoadComboSede();
            LoadAreas();
            EnableControlsByRol();
        }

        private void cboArticulo_Leave(object sender, EventArgs e)
        {
            Articulo articulo = cboArticulo.SelectedItem as Articulo;
            if (articulo == null)
            {
                articulo = listaArticulo.Where(tx => tx.Descripcion.ToUpper() == cboArticulo.Text.ToUpper()).FirstOrDefault();

                if (articulo != null)
                {
                    if (cboArticulo.Items.IndexOf(articulo) != -1)
                    {
                        cboArticulo.SelectedItem = articulo;
                        cboArticulo.Text = articulo.Descripcion;
                        //cbcell.Value = articulo.Descripcion;
                    }
                }

            }
        }

        private void cboArea_Leave(object sender, EventArgs e)
        {
            Area area = cboArea.SelectedItem as Area;
            if (area == null)
            {
                area = listaArea.Where(tx => tx.CodArea.ToUpper() == cboArea.Text.ToUpper()).FirstOrDefault();
            }
            if (area != null)
            {
                cboArea.Text = area.CodArea;
                List<Articulo> lstArticulo = listaArticulo.Where(tx => tx.Id_Area == area.Id_Area).ToList();
                lstArticulo.Insert(0, new Articulo() { Id_Articulo = 0, Descripcion = "[--Todos--]" });
                cboArticulo.DataSource = lstArticulo;
                cboArticulo.DisplayMember = "Descripcion";
            }
        }

        private void btnEstEgreGen_Click(object sender, EventArgs e)
        {
            generarDocumento();
        }

        private bool Validar()
        {
            fecini = dtpFechaEstEgreI.Value.Date;
            fecfin = dtpFechaEstEgreF.Value.Date + (new TimeSpan(23, 59, 59));
            if (fecfin < fecini)
            {
                return false;
            }else
            {
                return true;
            }
        }
        private async void generarDocumento()
        {
            if (Validar())
            {
                try
                {

                    if (cboSede.SelectedIndex == 0)
                    {
                        sede = 0;
                    }
                    else
                    {
                        Sede sd = cboSede.SelectedValue as Sede;
                        sede = sd.Id_Sede;
                    }
                    if (cboArea.SelectedIndex == 0)
                    {
                        area = 0;
                    }
                    else
                    {
                        Area ar = cboArea.SelectedValue as Area;
                        area = ar.Id_Area;
                    }
                    if (cboArticulo.SelectedIndex == 0 || cboArticulo.SelectedIndex == -1)
                    {
                        articulo = 0;
                    }
                    else
                    {
                        Articulo art = cboArticulo.SelectedValue as Articulo;
                        articulo = art.Id_Articulo;
                    }

                    IServiceAlmacen service = new ServiceAlmacen();
                    var response = await service.GetlistaEstSalidaAsync(fecini, fecfin, area, articulo, sede);
                    if (response.IsValid)
                    {
                        LstResultado = response.Value;
                        rptEstEgre.ProcessingMode = ProcessingMode.Local;
                        rptEstEgre.LocalReport.DataSources.Clear();
                        ReportDataSource Reporte = new ReportDataSource("DataSet1", LstResultado);
                        rptEstEgre.LocalReport.DataSources.Add(Reporte);

                        List<ReportParameter> parametros = new List<ReportParameter>();
                        parametros.Add(new ReportParameter("fechaInicio", dtpFechaEstEgreI.Value.ToString("dd/MM/yyyy")));
                        parametros.Add(new ReportParameter("fechaFin", dtpFechaEstEgreF.Value.ToString("dd/MM/yyyy")));

                        this.rptEstEgre.LocalReport.SetParameters(parametros);
                        rptEstEgre.RefreshReport();
                        rptEstEgre.Focus();
                    }
                    else
                    {
                        MessageBox.Show(response.ErrorMensaje);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error..." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Ocurrió un error. Verificar las fechas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EnableControlsByRol()
        {
            if (CurrentSession.Usuario.Id_Puesto == (int)Roles.Administrador)
            {
            }
            else if (CurrentSession.Usuario.Id_Puesto == (int)Roles.Operador)
            {
                DisableExportFormats(rptEstEgre, "EXCELOPENXML");
                DisableExportFormats(rptEstEgre, "WORDOPENXML");
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

      
    }
}
