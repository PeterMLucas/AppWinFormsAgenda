using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppWinFormsAgenda
{
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
        }

        //Sobrecarga del contrusctor con parametros
        public MsgBox(string pTipo, string pMensaje)
        {
            InitializeComponent();
            MsgTxt1.Text = pMensaje;

            if (pTipo == "salir")
            {
                MsgTxt1.Text = "Pregunta";
                MsgTxt1.ForeColor = Color.FromArgb(45, 106, 79);
                MsgQuestion.Visible = true;
            }
        }

        //Eventos click botón Aceptar
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
            Application.Exit();
        }


        //Evento Mouse cuando el mouse entre en el botón 
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Transparent;
            b.ForeColor = Color.FromArgb(45, 106, 79);
        }


        //Evento cuando el mouse sale del botón
        private void Btn_MouseLeave(object sender, EventArgs e) {
            Button b = sender as Button;
            b.BackColor = Color.FromArgb(45, 106, 79);
            b.ForeColor = Color.White;
        }
       
        
        //Evento click botón Cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        
        //Métodos
        void Aceptar()
        {
            DialogResult = DialogResult.OK;
        }

        void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
        }

    }

}
