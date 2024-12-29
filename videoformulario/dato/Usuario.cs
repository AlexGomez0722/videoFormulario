using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using videoformulario.modelo;

namespace videoformulario.dato
{
    public class Usuario
    {
        List<UsuarioModel> lista = new List<UsuarioModel>();
        /// <summary>
        /// Guarda los ususarios
        /// </summary>
        /// <param name="modelo">datos del usuario</param>
        public void Guardar(UsuarioModel modelo)
        {
            lista.Add(modelo);
        } 
        /// <summary>
        /// consulta todos los usuarios
        /// </summary>
        /// <returns>datos del usuario</returns>
        public List<UsuarioModel> cosultar()
        {
            return lista;
        }
        public List<UsuarioModel> Consultar() 
        {
            return lista;
        }
    }
}
