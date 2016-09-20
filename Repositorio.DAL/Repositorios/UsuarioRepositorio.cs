using ConnectX.Infrastructure.Data.Security;
using Repositorio.Entidades;
using Repositorio.DAL.Repositorios.Base;
using System.Linq;

namespace Repositorio.DAL.Repositorios
{
    public class UsuarioRepositorio : Repositorio<Usuario>
    {

        public Usuario CadastraUsuario(Usuario user)
        {
            user.Senha = Crypto.EncryptStringAES(user.Senha, user.SenhaKey);
            return ctx.Usuarios.Add(user);
        }

        public Usuario Logusuario(string email, string senha)
        {
            var usuario = ctx.Usuarios.FirstOrDefault(u => u.Email == email);

            if (usuario == null)
               return null;

            string passDecrypt = Crypto.DecryptStringAES(usuario.Senha, usuario.SenhaKey);

            if (passDecrypt == senha)
                return usuario;
            else return null;            
 
        }

        public Usuario RecuperarUsuarioPorEmail(string email)
        {
            var usuario = ctx.Usuarios.FirstOrDefault(u => u.Email == email);
            return usuario;


        }


    }
}
