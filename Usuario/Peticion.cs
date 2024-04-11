using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios.Model;

namespace Usuario
{
    public partial class Peticion : Form
    {

        /***
         *  Marco Guida
         *  CV: http://bit.ly/mgcurriculum
         *  Linkedin: http://bit.ly/mgmiperfil
         *  Youtube: http://bit.ly/mgmisvideos
         *  Telefono: 0034-644450913
         *  Email: marcoguida@sevilla.es
         * */


        private static string _directorio = @"..\..\..\JSON";
        private static string _usuarios = "Usuarios.json";
        private static string _peticiones = "Peticiones.json";
        private static string _path = @".\" + _directorio + @"\" + _usuarios;
        private static string _pathPet = @".\" + _directorio + @"\" + _peticiones;
        List<UsuariosPet> misUsuarios = new List<UsuariosPet>();
        UsuariosPet usuarioSeleccionado = new UsuariosPet();

        public Peticion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Carga todos los usuarios
            //si no existe el json dice que no hay usuarios para mostrar

            CompruebaSiExisteJSON();//Si no existe lo crea vacío.

            List<UsuariosPet> misUsuarios = DeserializeJsonFile();

            //listUsuarios.Items.Clear();

            if (misUsuarios == null || misUsuarios.Count == 0)
            {
                //Mostrar que no hay usuarios
                MessageBox.Show("No hay usuarios para mostrar, añadir usuarios con la herramienta para Supervisores.");
            }
            else
            {
                //Mostrar los usuarios

                CargaUsuarios();

               
            }

            
        }

        private void CargaUsuarios()
        {
            misUsuarios = DeserializeJsonFile();

            foreach (UsuariosPet usuario in misUsuarios)
            {
                cbUsuarios.Items.Add(usuario.DNI);
            }
        }

        private List<UsuariosPet> DeserializeJsonFile()
        {
            string textoJson = File.ReadAllText(_path);

            List<UsuariosPet> misUsuarios = JsonConvert.DeserializeObject<List<UsuariosPet>>(textoJson);

            return misUsuarios;
        }

        private List<Peticiones> DeserializeJsonPeticiones()
        {
            string textoJson = File.ReadAllText(_pathPet);

            List<Peticiones> misPeticiones = JsonConvert.DeserializeObject<List<Peticiones>>(textoJson);

            return misPeticiones;
        }

        private void CompruebaSiExisteJSON()//Si no existe lo crea vacío.
        {
            if (!Directory.Exists(_directorio))
            {
                Directory.CreateDirectory(_directorio);
            }

            if (!File.Exists(_path))
            {
                File.WriteAllText(_path, "");
            }

            if (!File.Exists(_pathPet))
            {
                File.WriteAllText(_pathPet, "");
            }
        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUsuarios.Text.Length > 0)
            {
                usuarioSeleccionado = misUsuarios[cbUsuarios.SelectedIndex];
                cbPeticion.Enabled = true;
                lbUsuario.Text = "Usuario: " + usuarioSeleccionado.Nombre + " " + usuarioSeleccionado.Apellido;
                lvPeticionesAnt.Items.Clear();

                CargaPeticionesUsuario();
            }
            else
            {
                cbPeticion.Enabled = false;
               
            }
        }

        private void CargaPeticionesUsuario()
        {
            List<Peticiones> lPet= DeserializeJsonPeticiones();

            if (lPet != null)
            {

                lvPeticionesAnt.ResetText();

                foreach (Peticiones pet in lPet)
                {
                    if (pet.DNI == usuarioSeleccionado.DNI)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = pet.fechaHora;
                        lvi.SubItems.Add(pet.Peticion);
                        lvPeticionesAnt.Items.Add(lvi);
                    }
                }
            }
        }

        private List<Peticiones> CargaTodasLasPeticiones()
        {
            return DeserializeJsonPeticiones();
        }

        private void cbPeticion_TextChanged(object sender, EventArgs e)
        {
            if (cbPeticion.Text.Length > 0)
                btnEnviar.Enabled = true;
            else
                btnEnviar.Enabled = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SalvaJsonPet();
            Reset();
            MessageBox.Show("Enviado!");
        }

        private void Reset()
        {
            cbUsuarios.SelectedItem = null;
            cbPeticion.Text = "";
            cbPeticion.Enabled = false;
            btnEnviar.Enabled = false;
            lvPeticionesAnt.Items.Clear();
            lbUsuario.Text = "Usuario: ";
            btnBorrar.Enabled = false;
            //btnModificar.Enabled = false;
        }

        private void SalvaJsonPet()
        {
            Peticiones pet = new Peticiones();

            
            pet.Nombre = usuarioSeleccionado.Nombre;
            pet.Apellido = usuarioSeleccionado.Apellido;
            pet.DNI = usuarioSeleccionado.DNI;
            pet.Peticion = cbPeticion.Text;
            pet.fechaHora = DateTime.Now.ToString();

            List<Peticiones> arrayPet = new List<Peticiones>();

            if (CargaTodasLasPeticiones() != null)
            {
                arrayPet = CargaTodasLasPeticiones();
            }
            arrayPet.Add(pet);

            string petJson = JsonConvert.SerializeObject(arrayPet.ToArray(), Formatting.Indented);
            File.WriteAllText(_pathPet, petJson);
        }

        private void lvPeticionesAnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPeticionesAnt.SelectedItems.Count == 1 && lvPeticionesAnt.Items.Count>0)
            {
                btnBorrar.Enabled = true;
                //btnModificar.Enabled = true;
                cbPeticion.Text = lvPeticionesAnt.SelectedItems[0].SubItems[1].Text;
                
            }
            else
            {
               // Reset();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
           ListViewItem lvi  = lvPeticionesAnt.SelectedItems[0];

           List<Peticiones> allPeticiones = CargaTodasLasPeticiones();

            List<Peticiones> resultado = new List<Peticiones>();

            foreach(Peticiones pet in allPeticiones)
            {
                if (lvi.Text != pet.fechaHora)
                {
                    resultado.Add(pet);
                }
            }

            SalvaJsonPet(resultado);
            Reset();
            MessageBox.Show("Petición borrada");
        }

        private void SalvaJsonPet(List<Peticiones> listPet)
        {
            string petJson = JsonConvert.SerializeObject(listPet.ToArray(), Formatting.Indented);
            File.WriteAllText(_pathPet, petJson);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lvPeticionesAnt.SelectedItems[0];

            List<Peticiones> allPeticiones = CargaTodasLasPeticiones();

            List<Peticiones> resultado = new List<Peticiones>();

            foreach (Peticiones pet in allPeticiones)
            {
                if (lvi.Text == pet.fechaHora)
                {
                    pet.Peticion = cbPeticion.Text;

                    resultado.Add(pet);
                }
            }

            SalvaJsonPet(resultado);
            Reset();
            MessageBox.Show("Petición modificada");
        }
    }
}
