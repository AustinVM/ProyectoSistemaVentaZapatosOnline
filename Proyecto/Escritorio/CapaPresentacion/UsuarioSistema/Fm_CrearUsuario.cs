﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.UsuarioSistema
{
    public partial class Frm_Crear_Usuario : Form
    {
        public Frm_Crear_Usuario()
        {
            InitializeComponent();
            Gpb_consultar_usuarios.Visible = false;
            Gpb_eliminar_usuarios.Visible = false;
            Gpb_insertar_usuario.Visible = true;
            Gpb_roles.Visible = false;
        }





        private void crearYEditarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Crear y Editar Usuarios";
            Gpb_insertar_usuario.Visible = true;
            Gpb_consultar_usuarios.Visible = false;
            Gpb_eliminar_usuarios.Visible = false;
            Gpb_roles.Visible = false;
        }

        private void consultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Consultar Usuarios";
            Gpb_consultar_usuarios.Visible = true;
            Gpb_eliminar_usuarios.Visible = false;
            Gpb_insertar_usuario.Visible = false;
            Gpb_roles.Visible = false;

        }

        private void eliminarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Eliminar Usuarios";
            Gpb_consultar_usuarios.Visible = false;
            Gpb_eliminar_usuarios.Visible = true;
            Gpb_insertar_usuario.Visible = false;
            Gpb_roles.Visible = false;


        }

        private void crearRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gpb_consultar_usuarios.Visible = false;
            Gpb_eliminar_usuarios.Visible = false;
            Gpb_insertar_usuario.Visible = false;
            Gpb_roles.Visible = true;
        }
    }
}