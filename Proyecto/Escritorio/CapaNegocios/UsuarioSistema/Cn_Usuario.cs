using CapaDatos.UsuarioSistema;
using CapaEntidades.UsuarioSistema;
using System.Security.Cryptography;
using System.Text;

namespace CapaNegocios.UsuarioSistema
{
    public class Cn_Usuario
    {
        private Cd_Usuario oCd_Usuario = new Cd_Usuario();

        public bool AgregarUsuario(Ce_Usuario AgregarUsuario)
        {
            if (ConsultarUsuario(AgregarUsuario))
            {
                return false;
            }
            else
            {
                string Contra = AgregarUsuario.ContraseniaUsuario;
                Contra = EncriptarContrasenia(Contra);
                AgregarUsuario.ContraseniaUsuario = Contra;
                oCd_Usuario.AgregarUsuario(AgregarUsuario);
                return true;
            }
        }

        public bool ConsultarUsuario(Ce_Usuario ConsultarUsuario)
        {
            return oCd_Usuario.ConsultarUsuario().Any(d => d.NombreUsuario == ConsultarUsuario.NombreUsuario);
        }

        public bool ValidarUsuario(Ce_Usuario ValidarUsuario)
        {
            string Contra = ValidarUsuario.ContraseniaUsuario;
            Contra = EncriptarContrasenia(Contra);
            ValidarUsuario.ContraseniaUsuario = Contra;

            return oCd_Usuario.ConsultarUsuario().Any(d => d.NombreUsuario == ValidarUsuario.NombreUsuario && d.ContraseniaUsuario == ValidarUsuario.ContraseniaUsuario && d.IdRol == ValidarUsuario.IdRol);
        }

        public void ActualizarUsuario(Ce_Usuario ActualizarUsuario)
        {
            oCd_Usuario.ActualizarUsuario(ActualizarUsuario);
        }

        public void EliminarUsuario(Ce_Usuario EliminarUsuario)
        {
            oCd_Usuario.EliminarUsuario(EliminarUsuario);
        }

        private static string EncriptarContrasenia(string Contrasenia)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Contrasenia));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public async Task<bool> recuperarContrasenia(string Correo)
        {
            var Consulta = from d in oCd_Usuario.ConsultarUsuario()
                           where d.CorreoElectronico == Correo
                           select d;

            if (Consulta.Any())
            {
                string ContraseniaNueva = await GenerarContraseniaAleatoria();
                string ContraseniaNuevaEncriptada = EncriptarContrasenia(ContraseniaNueva);
                await oCd_Usuario.EnviarCorreoRecuperacion(Correo, ContraseniaNueva);
                return true;
            }
            else
            {
                return false;
            } 
        }

        public async Task<string> GeneratePasswordAsync(string ContraseniaNueva) // Metodo que encripta la contraseña alatoria generada del metodo "GenerarContraseniaAleatoria()"
        {
            // Aplicar hash a la contraseña para mayor seguridad (opcional)
            string hashedPassword = await Task.Run(() => EncriptarContrasenia(ContraseniaNueva));

            return hashedPassword;
        } // Fin del metodo que encripta la contraseña alatoria generada del metodo "GenerarContraseniaAleatoria()"

        private async Task<string> GenerarContraseniaAleatoria() // Metodo que genera una cadena aleatoria de caracteres para la contraseña
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
            StringBuilder passwordBuilder = new StringBuilder();
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] randomBytes = new byte[10];

            await Task.Run(() =>
            {
                rng.GetBytes(randomBytes);
                foreach (byte b in randomBytes)
                {
                    int randomIndex = b % validChars.Length;
                    passwordBuilder.Append(validChars[randomIndex]);
                }
            });

            return passwordBuilder.ToString();
        } // Fin del metodo que genera una contraseña alatoria
    }
}
