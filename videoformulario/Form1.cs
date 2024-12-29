using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using videoformulario.dato;
using videoformulario.modelo;

namespace videoformulario
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato = new Usuario();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar();
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("nombre");
            tabla.Columns.Add("edad");
            Grilla.DataSource = tabla;
        }
        private void Guardar()
        {
            UsuarioModel modelo = new UsuarioModel()
            {
                Nombre = Txtnombre.Text,
                Edad = int.Parse(Txtedad.Text)
            };
            dato.Guardar(modelo);
        }
        private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.Edad;
                tabla.Rows.Add(fila);
            }

        }
        private void Limpiar()
        {
            Txtnombre.Text = "";
            Txtedad.Text = "";
        }

    }
}
