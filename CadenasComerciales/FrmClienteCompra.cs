using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadenasComerciales {
    public partial class FrmClienteCompra : Form {
        //Variables locales:
        GestorBD.GestorBD gestorBD;
        string cadSql;
        DataSet dsCliente = new DataSet(), dsFactura = new DataSet(), dsPagos = new DataSet(), dsFecha = new DataSet(), dsArticulos = new DataSet();
        DataTable dtGeneral = new DataTable();
        Comunes comunes = new Comunes();

        public FrmClienteCompra(GestorBD.GestorBD gestorBD) {
            InitializeComponent();
            //Guardar el GestorBD en una variable local.
            this.gestorBD = gestorBD;
        }

        private void CboCliente_SelectedIndexChanged(object sender, EventArgs e) {
            //Habilita el boton de consulta
            btnCons.Enabled = true;
        }

        private void CboCompra_SelectedIndexChanged(object sender, EventArgs e) {
            //Vuelve visibles todos los elementos restantes
            lblArticulos.Visible = true; lblEtiquetaFecha.Visible = true;
            lblFechaCompra.Visible = true; lblPagos.Visible = true;
            DtgArticulos.Visible = true; DtgPagos.Visible = true;

            //Recupera la fecha de la factura seleccionada y la imprime en el label
            string folio = CboCompra.Text;
            cadSql = $"select Fecha from Factura f where f.IdFactura = {folio}";
            gestorBD.consBD(cadSql, dsFecha, "Fecha");
            lblFechaCompra.Text = dsFecha.Tables["Fecha"].Rows[0][0].ToString().Substring(0,10);

            //Muestra los articulos del folio seleccionado en un DataGridView
            cadSql = $"select pr.NomProd from FacturaProducto fp, Producto pr " +
                $"where fp.IdFactura = {folio} and pr.IdProd = fp.IdProd group by pr.NomProd";

            gestorBD.consBD(cadSql, dsArticulos, "Articulos");
            DtgArticulos.DataSource = dsArticulos.Tables["Articulos"];

            //Muestra los pagos del folio seleccionado en un DataGridView
            cadSql = $"select f.MontoTotal, COUNT(p.IdPago) as CantPagos, SUM(p.Monto) as MontoPagos, SUM(f.Saldo) as SaldoActual " +
                $"from Factura f , Pago p where f.IdFactura = {folio} and p.IdFactura = f.IdFactura group by f.MontoTotal";

            gestorBD.consBD(cadSql, dsPagos, "Pagos");
            DtgPagos.DataSource = dsPagos.Tables["Pagos"];
        }

        private void btnCons_Click(object sender, EventArgs e) {
            //Obtiene el nombre del cliente
            string nomcliente = CboCliente.Text;

            //Obtiene la fecha.
            string fecha = dtpFecha.Value.ToShortDateString();
            fecha = fecha.Substring(6, 4) + "-" + fecha.Substring(3, 2) + "-" + fecha.Substring(0, 2);

            //Obtiene todas las compras que ese cliente ha efectuado a partir de una fecha
            cadSql = $"select f.IdFactura " +
                $"from Cliente c, Factura f " +
                $"where NomClien = '{nomcliente}' and f.Fecha >= '{fecha}' and c.IdCliente = f.IdCliente " +
                $"group by f.IdFactura";

            gestorBD.consBD(cadSql, dsFactura, "Factura");

            //Manda un mensaje si la consulta está vacia, muestra el resto del menú si hay al menos un folio.
            if(dsFactura.Tables["Factura"].Rows.Count < 1) {
                //Mantiene invisible el ComboBox y su label.
                lblCompra.Visible = false;
                CboCompra.Visible = false;
                
                //Despliega un mensaje para avisar al usuario que no hubo resultados a su consulta.
                MessageBox.Show("El cliente no ha hecho ninguna compra después de la fecha " + fecha);

            } else {
                //Vuelve visible ComboBox y su label
                lblCompra.Visible = true;
                CboCompra.Visible = true;

                //Carga los folios de las facturas en el ComboBox
                comunes.cargaCombo(CboCompra, dsFactura, "Factura", "IdFactura");
            }
        }

        private void FrmClienteCompra_Load(object sender, EventArgs e) {
            //Consulta que extrae el nombre de cada cliente existente
            cadSql = "select nomclien from Cliente";
            gestorBD.consBD(cadSql,dsCliente,"Cliente");
            //Carga los nombres en el ComboBox
            comunes.cargaCombo(CboCliente, dsCliente, "Cliente", "nomclien");
        }
    }
}
