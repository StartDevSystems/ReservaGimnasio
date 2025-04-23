using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ReservaGimnasio.Capa_de_Datos.Conexion;
using System.Text.RegularExpressions;
using ReservaGimnasio.Entidades;

namespace ReservaGimnasio.Capa_de_Negocio
{
    public class UsuariosBL
    {
            private UsuarioDAL usuarioDAL = new UsuarioDAL();

            public DataTable ValidarLogin(string correo, string contraseña)
        {
            // Validar que no estén vacíos
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
                throw new ArgumentException("Debe completar todos los campos.");

            // Validar formato del correo
            if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Correo electrónico no válido.");
           
            // Llamar a la capa de datos si pasa las validaciones
            return usuarioDAL.ValidarLogin(correo, contraseña);
        }




        //*///////////////////*///////////////////**********//////////****************////////*********

        public bool RegistrarUsuario(string nombre, string correo, string contraseña, string rol)
        {
            // Validaciones de negocio
            if (string.IsNullOrEmpty(nombre) || nombre.Length < 3)
                throw new ArgumentException("El nombre debe tener al menos 3 caracteres");

            if (string.IsNullOrEmpty(correo) || !correo.Contains("@"))
                throw new ArgumentException("El correo electrónico no es válido");

            if (string.IsNullOrEmpty(contraseña) || contraseña.Length < 6)
                throw new ArgumentException("La contraseña debe tener al menos 6 caracteres");

            if (string.IsNullOrEmpty(rol))
                throw new ArgumentException("Debe seleccionar un rol");

            // Si todas las validaciones pasan, registrar el usuario
            return usuarioDAL.RegistrarUsuario(nombre, correo, contraseña, rol);
        }
        //*///////////////////*///////////////////**********//////////****************////////*********

        public DataTable BuscarUsuarioPorNombre(string nombre)
        {
            return usuarioDAL.BuscarPorNombre(nombre);
        }

        public DataTable MostrarTodosLosUsuarios()
        {
            return usuarioDAL.MostrarTodos();
        }


        //*///////////////////*///////////////////**********//////////****************////////*********

        public bool ModificarUsuario(int id, string nombre, string correo, string contraseña, string rol)
        {
            if (string.IsNullOrEmpty(nombre) || nombre.Length < 3)
                throw new ArgumentException("El nombre debe tener al menos 3 caracteres");

            if (string.IsNullOrEmpty(correo) || !correo.Contains("@"))
                throw new ArgumentException("El correo electrónico no es válido");

            if (string.IsNullOrEmpty(contraseña) || contraseña.Length < 6)
                throw new ArgumentException("La contraseña debe tener al menos 6 caracteres");

            if (string.IsNullOrEmpty(rol))
                throw new ArgumentException("Debe seleccionar un rol");

            return usuarioDAL.ModificarUsuario(id, nombre, correo, contraseña, rol);
        }

        //*///////////////////*///////////////////**********//////////****************////////*********

        public bool EliminarUsuario(int id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.EliminarUsuario(id);
        }



       


    }
}
