using Prototipo.Controladores;
using Prototipo.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo.Vistas
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            Usuario usuario = new Usuario();
            UsuarioController controller = new UsuarioController();
            if (string.IsNullOrEmpty(txtNombre.Texto) || string.IsNullOrEmpty(txtCorreo.Texto) || string.IsNullOrEmpty(txtConfirmarContraseña.Texto) || string.IsNullOrEmpty(txtContraseña.Texto) || string.IsNullOrEmpty(txtApellido.Texto))
            {
                MessageBox.Show("Por favor llene todos los campos", "Error al crear usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();

            }
            else if (txtContraseña.Texto != txtConfirmarContraseña.Texto)
            {
                MessageBox.Show("Las contraseñas no coinciden, por favor asegurese que las contraseñas coincidan correctamente ", "Contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
            }
            else
            {
                try
                {
                    usuario.Nombre = txtNombre.Texto;
                    usuario.Apellido = txtApellido.Texto;
                    usuario.Correo = txtCorreo.Texto;
                    usuario.Contraseña = txtContraseña.Texto;
                    usuario.CreadoEn = DateTime.Now;
                    usuario.RolId = 2;
                    controller.Agregar(usuario);
                    MessageBox.Show("Cuenta creada con éxito", "Creación de usuario exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form1.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al crear un usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }
    }
}
