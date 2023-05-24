using CapaEntidades.Productos;
using CapaNegocios.Productos;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;

namespace CapaPresentacion.Productos
{
    public partial class Frm_Productos : Form
    {
        Cn_Color oCn_Color = new Cn_Color();
        Cn_Coleccion oCn_Coleccion = new Cn_Coleccion();
        Cn_Material oCn_Material = new Cn_Material();
        Cn_TipoCalzado oCn_TipoCalzado = new Cn_TipoCalzado();
        Cn_Productos oCn_Productos = new Cn_Productos();
        DataTable tabla = new DataTable();
        public Frm_Productos()
        {
            InitializeComponent();
        }
        public void LlenarCombobox()
        {
            CmbColor.DataSource = oCn_Color.ConsultarColor();
            CmbColor.ValueMember = "Id";
            CmbColor.DisplayMember = "Nombre";
            CmbColeccion.DataSource = oCn_Coleccion.ConsultarColeccion();
            CmbColeccion.ValueMember = "Id";
            CmbColeccion.DisplayMember = "Nombre";
            CmbMaterial.DataSource = oCn_Material.ConsultarMaterial();
            CmbMaterial.ValueMember = "Id";
            CmbMaterial.DisplayMember = "Nombre";
            CmbTipoCalzado.DataSource = oCn_TipoCalzado.ConsultarTipoCalzado();
            CmbTipoCalzado.ValueMember = "Id";
            CmbTipoCalzado.DisplayMember = "Nombre";
            tabla = oCn_Productos.ConsultarProducto();

        }



        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            LlenarCombobox();
            DgwProductos.DataSource = oCn_Productos.ConsultarProducto();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            byte[] data = System.IO.File.ReadAllBytes(TxtRuta.Text);
            Ce_Producto oCe_Producto = new Ce_Producto();
            oCe_Producto.NombreProducto = TxtNombreProducto.Text;
            oCe_Producto.IdColor = Convert.ToInt32(CmbColeccion.SelectedValue);
            oCe_Producto.IdColeccion = Convert.ToInt32(CmbColeccion.SelectedValue);
            oCe_Producto.IdMaterial = Convert.ToInt32(CmbMaterial.SelectedValue);
            oCe_Producto.IdTipoCalzado = Convert.ToInt32(CmbTipoCalzado.SelectedValue);
            oCe_Producto.ImagenProducto = data;
            oCn_Productos.AgregarProducto(oCe_Producto);
            MessageBox.Show("Se inserto Un Producto");
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            MemoryStream archivomemoria = new MemoryStream();
            PbImagenProducto.Image.Save(archivomemoria, ImageFormat.Bmp);
            //byte[] data = System.IO.File.ReadAllBytes(PbImagenProducto.Image)
               
            Ce_Producto oCe_Producto = new Ce_Producto();
            oCe_Producto.Id = Convert.ToInt32(TxtCodigo.Text);
            oCe_Producto.NombreProducto = TxtNombreProducto.Text;
            oCe_Producto.IdColor = Convert.ToInt32(CmbColor.SelectedValue);
            oCe_Producto.IdColeccion = Convert.ToInt32(CmbColeccion.SelectedValue);
            oCe_Producto.IdMaterial = Convert.ToInt32(CmbMaterial.SelectedValue);
            oCe_Producto.IdTipoCalzado = Convert.ToInt32(CmbTipoCalzado.SelectedValue);
            oCe_Producto.ImagenProducto = archivomemoria.GetBuffer();
            oCn_Productos.EditarProducto(oCe_Producto);
            MessageBox.Show("Se Edito Un Producto");



        }

        private void cmbEditarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        private void BtnElegirImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtRuta.Text = openFileDialog1.FileName;
            }
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {

            TxtNombreProducto.Text = DgwProductos.CurrentRow.Cells["NombreProducto"].Value.ToString();
            CmbColor.SelectedValue = DgwProductos.CurrentRow.Cells["IdColor"].Value.ToString();
            CmbColeccion.SelectedValue = DgwProductos.CurrentRow.Cells["IdColeccion"].Value.ToString();
            CmbMaterial.SelectedValue = DgwProductos.CurrentRow.Cells["IdMaterial"].Value.ToString();
            CmbTipoCalzado.SelectedValue = DgwProductos.CurrentRow.Cells["IdTipoCalzado"].Value.ToString();
            TxtRuta.Text = DgwProductos.CurrentRow.Cells["ImagenProducto"].Value.ToString();
            TxtCodigo.Text = DgwProductos.CurrentRow.Cells["Id"].Value.ToString();
            //byte[] imagen = ;
            //Image imag;
            //using (MemoryStream ms = new MemoryStream(imagen))
            //{
            //    imag = Image.FromStream(ms);
            //}
            byte[] imagen = (byte[])DgwProductos.CurrentRow.Cells["ImagenProducto"].Value;
            Image imag;
            using (MemoryStream ms = new MemoryStream(imagen))
            {
                imag = Image.FromStream(ms);
            }
            PbImagenProducto.Image = imag;
            TxtCodigo.Enabled = false;

        }
    }
}
