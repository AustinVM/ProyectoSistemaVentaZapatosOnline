using CapaEntidades.Productos;
using CapaNegocios.Productos;
using System.Data;
using System.Drawing.Imaging;

namespace CapaPresentacion.Productos
{
    public partial class FrmProductos : Form
    {
        Cn_Color oCn_Color = new Cn_Color();
        Cn_Coleccion oCn_Coleccion = new Cn_Coleccion();
        Cn_Material oCn_Material = new Cn_Material();
        Cn_TipoCalzado oCn_TipoCalzado = new Cn_TipoCalzado();
        Cn_Productos oCn_Productos = new Cn_Productos();
        DataTable tabla = new DataTable();

        public FrmProductos()
        {
            InitializeComponent();
        }

        #region MisMetodos

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

        #endregion


        private void FrmProductos_Load(object sender, EventArgs e)
        {
            LlenarCombobox();
            DgwProductos.DataSource = oCn_Productos.ConsultarProducto();
            DgwConsultarProducto.DataSource = oCn_Productos.ConsultarProducto();
        }


        public void ReiniciarDatagridview()
        {
            DgwProductos.DataSource = oCn_Productos.ConsultarProducto();
        }

        public void Limpiar()
        {
            TxtNombreProducto.Clear();

        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            MemoryStream archivomemoria = new MemoryStream();
            PbImagenProducto.Image.Save(archivomemoria, ImageFormat.Bmp);
            Ce_Producto oCe_Producto = new()
            {
                NombreProducto = TxtNombreProducto.Text,
                IdColor = Convert.ToInt32(CmbColeccion.SelectedValue),
                IdColeccion = Convert.ToInt32(CmbColeccion.SelectedValue),
                IdMaterial = Convert.ToInt32(CmbMaterial.SelectedValue),
                IdTipoCalzado = Convert.ToInt32(CmbTipoCalzado.SelectedValue),
                ImagenProducto = archivomemoria.GetBuffer()
            };
            oCn_Productos.AgregarProducto(oCe_Producto);
            ReiniciarDatagridview();
            Limpiar();
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            byte[] imagen = (byte[])DgwProductos.CurrentRow.Cells["ImagenProducto"].Value;
            Image imag;
            using (MemoryStream ms = new MemoryStream(imagen))
            {
                imag = Image.FromStream(ms);
            }
            PbImagenProducto.Image = imag;

            //MemoryStream archivomemoria = new MemoryStream();
            //PbImagenProducto.Image.Save(archivomemoria, ImageFormat.Bmp);

            Ce_Producto oCe_Producto = new()
            {
                Id = Convert.ToInt32(DgwProductos.CurrentRow.Cells["Id"].Value),
                NombreProducto = TxtNombreProducto.Text,
                IdColor = Convert.ToInt32(CmbColor.SelectedValue),
                IdColeccion = Convert.ToInt32(CmbColeccion.SelectedValue),
                IdMaterial = Convert.ToInt32(CmbMaterial.SelectedValue),
                IdTipoCalzado = Convert.ToInt32(CmbTipoCalzado.SelectedValue),
                ImagenProducto = imagen
            };
            oCn_Productos.EditarProducto(oCe_Producto);
            ReiniciarDatagridview();
            Limpiar();
        }

        private void BtnElegirImagen_Click_1(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    byte[] data = File.ReadAllBytes(openFileDialog1.FileName);
            //    Image imag;
            //    using (MemoryStream ms = new MemoryStream(data))
            //    {
            //        imag = Image.FromStream(ms);
            //    }
            //    PbImagenProducto.Image = imag;
            //}

            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();
            if (resultado == DialogResult.OK)
            {
<<<<<<< HEAD
                PbImagenProducto.Image = Image.FromFile(dialogo.FileName);
                PbImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage;
=======
                byte[] data = File.ReadAllBytes(openFileDialog1.FileName);
                Image imag;
                using (MemoryStream ms = new MemoryStream(data))
                {
                    imag = Image.FromStream(ms);
                }
                PbImagenProducto.Image = imag;
>>>>>>> eefe53db1e526782590a6af49cf45b8c996d982d
            }

        }

        private void BtnConsulta_Click_1(object sender, EventArgs e)
        {
            TxtNombreProducto.Text = DgwProductos.CurrentRow.Cells["NombreProducto"].Value.ToString();
            CmbColor.SelectedValue = DgwProductos.CurrentRow.Cells["IdColor"].Value.ToString();
            CmbColeccion.SelectedValue = DgwProductos.CurrentRow.Cells["IdColeccion"].Value.ToString();
            CmbMaterial.SelectedValue = DgwProductos.CurrentRow.Cells["IdMaterial"].Value.ToString();
            CmbTipoCalzado.SelectedValue = DgwProductos.CurrentRow.Cells["IdTipoCalzado"].Value.ToString();
            byte[] imagen = (byte[])DgwProductos.CurrentRow.Cells["ImagenProducto"].Value;
            Image imag;
            using (MemoryStream ms = new MemoryStream(imagen))
            {
                imag = Image.FromStream(ms);
            }
            PbImagenProducto.Image = imag;
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            Ce_Producto Producto = new Ce_Producto();
            try
            {
                if (MessageBox.Show(" Quieres eliminar", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Producto.Id = Convert.ToInt32(DgwProductos.CurrentRow.Cells["Id"].Value.ToString());
                    oCn_Productos.EliminarProducto(Producto);
                    MessageBox.Show("Se elimino el producto");

                }

                else
                {
                    MessageBox.Show("No se elimino");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            ReiniciarDatagridview();

        }

        private void crearYEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Gpb_insertar_Producto.Visible = true;
            Gpb_Consultar_Producto.Visible = false;

            
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            Gpb_Consultar_Producto.Visible = true;
            Gpb_insertar_Producto.Visible = false;
           
        }

        private void BtnConsultarProducto_Click(object sender, EventArgs e)
        {
            byte[] imagen = (byte[])DgwConsultarProducto.CurrentRow.Cells["ImagenProducto"].Value;
            Image imag;
            using (MemoryStream ms = new MemoryStream(imagen))
            {
                imag = Image.FromStream(ms);
            }
            PbConsultarProducto.Image = imag;
        }
    }
}
