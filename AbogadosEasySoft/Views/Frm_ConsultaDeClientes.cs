using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbogadosEasySoft.DAO;
using AbogadosEasySoft.Models;

namespace AbogadosEasySoft.Views
{
    public partial class Frm_ConsultaDeClientes : Form
    {
        Repository<cliente> ClienteDAO = new Repository<cliente>();

        public Frm_ConsultaDeClientes()
        {
            InitializeComponent();
            dataGridView.ReadOnly = true;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ClienteDAO.FindAll(c => c.id.ToString() == textBox1.Text). //Se selecciona el cliente donde coincida el id
                Select(c => new { //Se seleccionan cuales columnas se van a utulizar en la base de datos
                    c.id,
                    c.nombre,
                    c.segundo_nombre,
                    c.apellido,
                    c.cedula,
                    c.pasaporte,
                    c.segundo_apellido })
                    .ToArray();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ClienteDAO.FindAll(c => c.fiscalia == textBox14.Text). //Se selecciona el cliente donde coincida el fiscal
                Select(c => new { 
                    c.id,
                    c.nombre,
                    c.segundo_nombre,
                    c.apellido,
                    c.cedula,
                    c.pasaporte,
                    c.segundo_apellido
                })
                    .ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ClienteDAO.FindAll(c => c.cedula == textBox2.Text). //Se selecciona el cliente donde coincida la cédula (sin guión)
                Select(c => new {
                    c.id,
                    c.nombre,
                    c.segundo_nombre,
                    c.apellido,
                    c.cedula,
                    c.pasaporte,
                    c.segundo_apellido
                })
                    .ToArray();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ClienteDAO.FindAll(c => c.fecha_actual >= dateTimePicker1.Value 
                && c.fecha_actual <= dateTimePicker2.Value). //Se selecciona el cliente donde coincida la fecha
                Select(c => new {
                    c.id,
                    c.nombre,
                    c.segundo_nombre,
                    c.apellido,
                    c.cedula,
                    c.pasaporte,
                    c.segundo_apellido
                })
                    .ToArray();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ClienteDAO.FindAll(c => c.servicio.Contains(textBox13.Text)). //Se selecciona el cliente donde coincida el servicio
                Select(c => new {
                    c.id,
                    c.nombre,
                    c.segundo_nombre,
                    c.apellido,
                    c.cedula,
                    c.pasaporte,
                    c.segundo_apellido
                })
                    .ToArray();
        }
    }
}
