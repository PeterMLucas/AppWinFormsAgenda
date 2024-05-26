using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinFormsAgenda
{
    public partial class FormAgenda : Form
    {
        int posicion;
        int Codigo = 1;

        public FormAgenda()
        {
            InitializeComponent();
        }


        private void FormAgenda_Load(object sender, EventArgs e){
            txtCodigo.Visible = false;
            labelCodigo.Visible = false;
        }

        private void DataGridViewDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Grid();
        }

        //BOTONES
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
        
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
           Salir();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //CAJAS DE TEXTO
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        //MÉTODOS
        void Agregar()
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int newRow = DataGridViewDatos.Rows.Add();
                DataGridViewDatos.Rows[newRow].Cells[0].Value = Codigo;
                DataGridViewDatos.Rows[newRow].Cells[1].Value = txtNombre.Text;
                DataGridViewDatos.Rows[newRow].Cells[2].Value = txtApellido.Text;
                DataGridViewDatos.Rows[newRow].Cells[3].Value = txtDireccion.Text;
                DataGridViewDatos.Rows[newRow].Cells[4].Value = NumberTelefono.Text;
                MessageBox.Show("El contacto ha sido agregado correctamente", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Codigo++;
        }

        void Grid()
        {
            try
            {
                posicion = DataGridViewDatos.CurrentRow.Index;
                txtNombre.Text = DataGridViewDatos[1, posicion].Value.ToString();
                txtApellido.Text = DataGridViewDatos[2, posicion].Value.ToString();
                txtDireccion.Text = DataGridViewDatos[3, posicion].Value.ToString();
                NumberTelefono.Text = DataGridViewDatos[4, posicion].Value.ToString();
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("No se puede modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void Modificar()
        {
            DataGridViewDatos[1, posicion].Value = txtNombre.Text;
            DataGridViewDatos[2, posicion].Value = txtApellido.Text;
            DataGridViewDatos[3, posicion].Value = txtDireccion.Text;
            DataGridViewDatos[4, posicion].Value = NumberTelefono.Text;
        }
        
        void Eliminar()
        {
            try{
                DataGridViewDatos.Rows.RemoveAt(posicion);
                MessageBox.Show("El contacto ha sido eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("No hay más contactos para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            NumberTelefono.Value = 0;
        }

        void Salir()
        {
            MsgBox msgBox = new MsgBox("Salir", "¿Estás seguro de salir?");
            msgBox.ShowDialog();
        }


    }
}
