using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewUser;

namespace MiniSuper
{
    public static class MiniSuper
    {
        static NewUser.Usuario[] usuarios;

        /// <summary>
        /// 
        /// </summary>
        static MiniSuper()
        {
            usuarios = new Usuario[0];
        }

        public static NewUser.Usuario[] GetUsuarios()
        {
            return usuarios;
        }

        public static bool AddUsuarios(NewUser.Usuario user)
        {
            foreach (NewUser.Usuario item in usuarios)
            {
                if(user == item)
                {
                    return false;
                }
            }

            Array.Resize<Usuario>(ref usuarios, usuarios.Length + 1);
            usuarios[usuarios.Length - 1] = user;
            // Crear la sobrecarga del +
            //usuarios += user;

            return true;
        }
    }
}
