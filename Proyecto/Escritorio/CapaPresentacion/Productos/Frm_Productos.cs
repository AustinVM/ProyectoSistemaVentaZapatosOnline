using CapaNegocios.Productos;

namespace CapaPresentacion.Productos
{
    public partial class Frm_Productos : Form
    {
        Cn_Color oCn_Color = new Cn_Color();
        Cn_Coleccion oCn_Coleccion = new Cn_Coleccion();
        Cn_Material oCn_Material = new Cn_Material();
        Cn_TipoCalzado oCn_TipoCalzado = new Cn_TipoCalzado();
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

        }



        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            LlenarCombobox();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {


        }
    }
}
