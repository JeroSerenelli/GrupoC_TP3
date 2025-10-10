using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Linq;
using System.Windows.Forms;

namespace GrupoC_TP3.CU9_CuentaCorriente
{
    public partial class CuentaCorrienteForm : Form
    {
        private readonly CuentaCorrienteModel _model = new();

        public CuentaCorrienteForm()
        {
            InitializeComponent();
            this.Load += CuentaCorriente_Load;
        }

        private void CuentaCorriente_Load(object? sender, EventArgs e)
        {
            comboBoxCuitCuil.DataSource = _model.GetCuits().ToList();

            dateTimePickerInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerInicio.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFin.Format = DateTimePickerFormat.Custom;
            dateTimePickerFin.CustomFormat = "dd/MM/yyyy";

            if (listViewCuentaCorriente.Columns.Count == 0)
            {
                listViewCuentaCorriente.View = View.Details;
                listViewCuentaCorriente.FullRowSelect = true;
                listViewCuentaCorriente.Columns.Add("Fecha", 100);
                listViewCuentaCorriente.Columns.Add("Monto", 80);
                listViewCuentaCorriente.Columns.Add("Saldo", 90);
            }

            LimpiarCabecera();
        }

        private void buttonBuscar_Click(object? sender, EventArgs e)
        {
            var cuit = comboBoxCuitCuil.SelectedItem?.ToString();

            if (!_model.IsValidCuitSelected(cuit))
            {
                MessageBox.Show("Debes seleccionar un CUIT antes de Buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxCuitCuil.Focus();
                return;
            }

            var inicio = dateTimePickerInicio.Value.Date;
            var fin = dateTimePickerFin.Value.Date;

            if (!_model.IsValidDateRange(inicio, fin))
            {
                MessageBox.Show("La fecha de fin no puede ser menor a la fecha de inicio.", "Rango de fechas inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerFin.Focus();
                return;
            }

            var cliente = _model.GetClienteByCuit(cuit!);
            if (cliente is null)
            {
                MessageBox.Show("El CUIT seleccionado no pertenece a un cliente registrado.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var estado = _model.CalcularEstadoCuenta(cuit!, inicio, fin);

            textBoxCliente.Text = estado.Cliente.RazonSocial;
            textBoxInicio.Text = estado.InicioPeriodo.ToString("dd/MM/yyyy");
            textBoxFin.Text = estado.FinPeriodo.ToString("dd/MM/yyyy");

            listViewCuentaCorriente.BeginUpdate();
            listViewCuentaCorriente.Items.Clear();

            if (estado.Items.Any())
            {
                var itemIni = new ListViewItem(estado.InicioPeriodo.ToString("dd/MM/yyyy"));
                itemIni.SubItems.Add("—");
                itemIni.SubItems.Add(estado.SaldoInicial.ToString("N2"));
                itemIni.SubItems.Add("Saldo inicial");
                listViewCuentaCorriente.Items.Add(itemIni);

                foreach (var it in estado.Items)
                {
                    var li = new ListViewItem(it.Fecha.ToString("dd/MM/yyyy"));
                    li.SubItems.Add(it.Monto.ToString("N2"));
                    li.SubItems.Add(it.Saldo.ToString("N2"));
                    listViewCuentaCorriente.Items.Add(li);
                }

                var itemFin = new ListViewItem(estado.FinPeriodo.ToString("dd/MM/yyyy"));
                itemFin.SubItems.Add("—");
                itemFin.SubItems.Add(estado.SaldoFinal.ToString("N2"));
                itemFin.SubItems.Add("Saldo final");
                listViewCuentaCorriente.Items.Add(itemFin);
            }

            listViewCuentaCorriente.EndUpdate();
        }

        private void LimpiarCabecera()
        {
            textBoxCliente.Clear();
            textBoxInicio.Clear();
            textBoxFin.Clear();
            listViewCuentaCorriente.Items.Clear();
        }
    }
}

