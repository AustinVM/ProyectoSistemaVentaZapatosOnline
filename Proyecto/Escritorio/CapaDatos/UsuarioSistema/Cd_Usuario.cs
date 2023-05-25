using CapaDatos.Conexion;
using CapaDatos.UsuarioSistema.RecuperacionContraseña;
using CapaEntidades.UsuarioSistema;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.UsuarioSistema
{
    public class Cd_Usuario
    {
        public void AgregarUsuario(Ce_Usuario AgregarUsuario)
        {
            using (SqlConnection conex = new(Cd_Conexion._rutaBaseDatos))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new("SP_AgregarUsuario", conex))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", AgregarUsuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@Contrasenia", AgregarUsuario.ContraseniaUsuario);
                        cmd.Parameters.AddWithValue("@IdRol", AgregarUsuario.IdRol);
                        cmd.Parameters.AddWithValue("@Estado", AgregarUsuario.EstadoUsuario);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException SqlEx)
                {
                    Console.WriteLine("Ocurrio un error con la base de datos." + SqlEx.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error." + ex.Message);
                }
            }
        }

        public List<Ce_Usuario> ConsultarUsuario()
        {
            List<Ce_Usuario> listaUsuarios = new();
            using (SqlConnection conex = new(Cd_Conexion._rutaBaseDatos))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new("SP_ConsultarUsuario", conex))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader leer = cmd.ExecuteReader();
                        while (leer.Read())
                        {
                            Ce_Usuario DatosUsuarios = new()
                            {
                                Id = leer.GetInt32(0),
                                NombreUsuario = leer.GetString(1),
                                ContraseniaUsuario = leer.GetString(2),
                                IdRol = leer.GetInt32(3),
                                EstadoUsuario = leer.GetBoolean(4)
                            };
                            listaUsuarios.Add(DatosUsuarios);
                        }
                    }
                }
                catch (SqlException SqlEx)
                {
                    Console.WriteLine("Ocurrio un error con la base de datos." + SqlEx.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error." + ex.Message);
                }
            }
            return listaUsuarios;
        }

        public void ActualizarUsuario(Ce_Usuario ActualizarUsuario)
        {
            using SqlConnection conex = new(Cd_Conexion._rutaBaseDatos);
            try
            {
                conex.Open();
                using (SqlCommand cmd = new("SP_ActualizarUsuario", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", ActualizarUsuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@estado", ActualizarUsuario.EstadoUsuario);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException SqlEx)
            {
                Console.WriteLine("Ocurrio un error con la base de datos." + SqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error." + ex.Message);
            }
        }

        public void EliminarUsuario(Ce_Usuario EliminarUsuario)
        {
            using SqlConnection conex = new(Cd_Conexion._rutaBaseDatos);
            try
            {
                conex.Open();
                using SqlCommand cmd = new("SP_EliminarUsuario", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", EliminarUsuario.Id);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException SqlEx)
            {
                Console.WriteLine("Ocurrio un error con la base de datos." + SqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error." + ex.Message);
            }
        }

        public async Task<string> EnviarCorreoRecuperacion(string userRequesting, string nuevaContrasenia)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand command = new SqlCommand("SP_RecuperarContrasenia", conex))
                {
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        var mailService = new Cd_RecuperarContrasenia();
                        await mailService.EnviarCorreoRecuperacion(
                              subject: "SYSTEM: Password recovery request",
                              body: "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                                  "your current password is: " + nuevaContrasenia +
                                  "\nHowever, we ask that you change your password immediately once you enter the system.",
                              mail: userMail
                        );
                        return "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                               "Please check your mail: " + userMail +
                               "\nHowever, we ask that you change your password immediately once you enter the system.";
                    }
                    else
                    {
                        return "Sorry, you do not have an account with that mail or username";
                    }
                }
            }
        }
    }
}