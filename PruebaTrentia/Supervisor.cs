using Newtonsoft.Json;
using PruebaTrentia.Model;
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
using static System.Windows.Forms.ListView;

namespace PruebaTrentia
{
    public partial class Supervisor : Form
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
        private static string _path = @".\" + _directorio + @"\" + _usuarios;
        ListViewItem itemSeleccionado = new ListViewItem();
        bool esUsuarioLogueado = false;

        public Supervisor()
        {
            InitializeComponent();
        }

        private void Supervisor_Load(object sender, EventArgs e)
        {
            //Carga todos los usuarios
            //si no existe el json dice que no hay usuarios para mostrar

            CompruebaSiExisteJSON();//Si no existe lo crea vacío.

            List<Usuarios> misUsuarios = DeserializeJsonFile();

            if (esUsuarioLogueado)
            {

                if (misUsuarios == null || misUsuarios.Count == 0)
                {
                    //Mostrar que no hay usuarios
                    MessageBox.Show("No hay usuarios para mostrar");
                }
                else
                {
                    //Mostrar los usuarios
                    CargaUsuarios();
                }
            }
            else
            {
                usuarioLogueado(esUsuarioLogueado);
            }
        }

        private void usuarioLogueado(bool usuarioEsLogueado)
        {
            if (!usuarioEsLogueado)
            {
                tboxNombre.Enabled = false;
                tboxApellido.Enabled = false;
                tboxDNI.Enabled = false;
                btnAlta.Enabled = false;
                btnBaja.Enabled = false;
                btnModifica.Enabled = false;
                btnBusca.Enabled = false;
                btnReset.Enabled = false;
                listUsuarios.Enabled = false;
                tbDireccion.Enabled = false;
                tbUsuarioUsu.Enabled = false;
                tbContrasUsu.Enabled = false;
                chbEsSupervisor.Enabled = false;
            }
            else
            {
                ReestablecePantalla();
            }
        }

        private void CargaUsuarios()
        {
            listUsuarios.Items.Clear();

            List<Usuarios> misUsuarios = DeserializeJsonFile();

            if (misUsuarios != null)
            {
                foreach (Usuarios usuario in misUsuarios)
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = usuario.DNI;
                    item.SubItems.Add(usuario.Nombre);
                    item.SubItems.Add(usuario.Apellido);
                    item.SubItems.Add(usuario.Direccion);
                    item.SubItems.Add(usuario.Usuario);
                    item.SubItems.Add(usuario.Contras);
                    item.SubItems.Add(usuario.esSupervisor);

                    listUsuarios.Items.Add(item);
                }

                listUsuarios.Refresh();
            }
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
        }

        private List<Usuarios> DeserializeJsonFile()
        {
            string textoJson = File.ReadAllText(_path);

            List<Usuarios> misUsuarios = JsonConvert.DeserializeObject<List<Usuarios>>(textoJson);

            return misUsuarios;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
           



            if (CompruebaCampos())
            {
                //Pedir confirmación Alta
                DialogResult seleccionado = MessageBox.Show("Vas a Añadir al Usuario " + tboxNombre.Text.Trim() + " " + tboxApellido.Text.Trim() + " " + tboxDNI.Text.Trim() + ". Es correcto?", "Añadir?", MessageBoxButtons.YesNo);

                //Escribir JSON
                if (seleccionado == DialogResult.Yes)
                {

                    Usuarios miUser = new Usuarios();
                    miUser.DNI = tboxDNI.Text.Trim();
                    miUser.Nombre = tboxNombre.Text.Trim();
                    miUser.Apellido = tboxApellido.Text.Trim();
                    miUser.Direccion = tbDireccion.Text.Trim();
                    miUser.Usuario = tbUsuarioUsu.Text.Trim();
                    miUser.Contras = tbContrasUsu.Text.Trim();
                    miUser.esSupervisor = chbEsSupervisor.Checked.ToString();

                    ListViewItem item = new ListViewItem();
                    item = listUsuarios.Items.Add(miUser.DNI);
                    item.SubItems.Add(miUser.Nombre);
                    item.SubItems.Add(miUser.Apellido);
                    item.SubItems.Add(miUser.Direccion);
                    item.SubItems.Add(miUser.Usuario);
                    item.SubItems.Add(miUser.Contras);
                    item.SubItems.Add(miUser.esSupervisor);


                    SalvaJson();
                }

                ReestablecePantalla();
            }
        }

        private void CapitalLetters()
        {
            tboxNombre.Text = tboxNombre.Text.Substring(0, 1).ToUpper() + tboxNombre.Text.Substring(1);//Pone la primera letra Mayuscula
            tboxApellido.Text = tboxApellido.Text.Substring(0, 1).ToUpper() + tboxApellido.Text.Substring(1);
            tboxDNI.Text = tboxDNI.Text.Substring(0, 8) + tboxDNI.Text.Substring(tboxDNI.Text.Length - 1).ToUpper();//Pone la letra de control Mayuscula
        }

        private void SalvaJson()
        {
            List<Usuarios> usuariosDeMiLista = new List<Usuarios>();

            foreach (ListViewItem user in listUsuarios.Items)
            {
                Usuarios unUsuario = new Usuarios();

                unUsuario.DNI = user.Text;
                unUsuario.Nombre = user.SubItems[1].Text;
                unUsuario.Apellido = user.SubItems[2].Text;
                unUsuario.Direccion = user.SubItems[3].Text;
                unUsuario.Usuario= user.SubItems[4].Text;
                unUsuario.Contras = user.SubItems[5].Text;
                unUsuario.esSupervisor=  user.SubItems[6].Text;

                usuariosDeMiLista.Add(unUsuario);
            }

            SerializeJsonFile(usuariosDeMiLista);
        }

        public void SerializeJsonFile(List<Usuarios> misUsuarios)
        {
            DNIComparer dnic = new DNIComparer();

            misUsuarios.Sort((x, y) => dnic.Compare(x.DNI, y.DNI));
            string usuariosJson = JsonConvert.SerializeObject(misUsuarios.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, usuariosJson);

            listUsuarios.Items.Clear();

            CargaUsuarios();
        }

        private bool CompruebaCampos()
        {
            bool resultado = false;
            string errores = string.Empty;

            if (tboxNombre.Text.Length == 0)
                errores += "Hay que indicar un nombre\n ";

            if (tboxApellido.Text.Length == 0)
                errores += "Hay que indicar un Apellido\n ";

            if (!CheckDNI(tboxDNI.Text))
                errores += "En DNI indicado no es valido\n";

            if (DNIyaEnLista(tboxDNI.Text.Trim()))
                errores += "En DNI indicado ya existe en la lista\n";

            if (tbDireccion.Text.Length == 0)
                errores += "Es necesario indicar una dirección\n";

            if (tbUsuarioUsu.Text.Length == 0)
                errores += "Hay que indicar un nombre usuario\n";

            if (tbContrasUsu.Text.Length == 0)
                errores += "Es necesario asignar una contraseña";

            if (errores != string.Empty)
                MessageBox.Show(errores, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                resultado = true;
                CapitalLetters();
            }

            return resultado;
        }

        private bool DNIyaEnLista(string dni)
        {
            bool resultado = false;

            //Busca el DNI en la lista

            foreach (ListViewItem user in listUsuarios.Items)//No es un metodo muy eficiente, pero para este ejercicio con tiempo limitado está bien.
            {
                if (user.Text == dni)
                    return true;

            }

            return resultado;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

            if (!tboxDNI.Enabled)
            {

                DialogResult respuesta = MessageBox.Show("Estás seguro que quieres remover el elemento seleccionado?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    CargaUsuarios();

                    foreach (ListViewItem lvi in listUsuarios.Items)
                    {
                        if (lvi.Text == itemSeleccionado.Text)
                        {
                            listUsuarios.Items.Remove(lvi);
                            break;
                        }
                    }

                  

                    SalvaJson();

                }

                ReestablecePantalla();
            }
            else
            {
                MessageBox.Show("Para borrar un Usuario tiene primero que seleccionarlo en la lista de abajo", "Seleccionar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReestablecePantalla()
        {
            tboxNombre.Enabled = true;
            tboxApellido.Enabled = true;
            btnBaja.Enabled = true;
            listUsuarios.Enabled = true;
            btnModifica.Enabled = false;
            btnReset.Enabled = true;
            tboxNombre.Text = "";
            tboxApellido.Text = "";
            tboxDNI.Text = "";
            tbDireccion.Text = "";
            tbUsuarioUsu.Text="";
            tbContrasUsu.Text = "";
            chbEsSupervisor.Checked = false;
            tboxDNI.Enabled = true;
            btnAlta.Enabled = true;
            tbDireccion.Enabled = true;
            tbUsuarioUsu.Enabled = true;
            tbContrasUsu.Enabled = true;
            chbEsSupervisor.Enabled = true;
            HabilitaDeshabilitaBuscar();
            CargaUsuarios();
        }

        //Devuelve true si es valido el DNI
        private static bool CheckDNI(string dni)
        {
            //Comprobamos si el DNI tiene 9 digitos
            if (dni.Length != 9)
            {
                //No es un DNI Valido
                return false;
            }

            //Extraemos los números y la letra
            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1).ToUpper();
            //Intentamos convertir los números del DNI a integer
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                return false;
            }
            if (CalculateDNILeter(dniInteger) != dniLeter)
            {
                //La letra del DNI es incorrecta
                return false;
            }
            //DNI Valido :)
            return true;


        }

        static string CalculateDNILeter(int dniNumbers)
        {
            //Cargamos los digitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            Console.WriteLine(control[mod]);
            return control[mod];
        }

        private void listUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUsuarios.SelectedItems.Count > 0)
            {

                itemSeleccionado = listUsuarios.SelectedItems[0];

                tboxDNI.Enabled = false;
                btnModifica.Enabled = true;
                btnAlta.Enabled = false;

                tboxDNI.Text = itemSeleccionado.Text;
                tboxNombre.Text = itemSeleccionado.SubItems[1].Text;
                tboxApellido.Text = itemSeleccionado.SubItems[2].Text;
                tbDireccion.Text= itemSeleccionado.SubItems[3].Text;
                tbUsuarioUsu.Text = itemSeleccionado.SubItems[4].Text;
                tbContrasUsu.Text = itemSeleccionado.SubItems[5].Text;
                chbEsSupervisor.Checked = bool.Parse(itemSeleccionado.SubItems[6].Text);

                CargaUsuarios();
            }
            else
            {
                ReestablecePantalla();
            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            CapitalLetters();

            foreach (ListViewItem user in listUsuarios.Items)//No es un metodo muy eficiente, pero para este ejercicio con tiempo limitado está bien.
            {
                if (user.Text == tboxDNI.Text)
                {
                    user.SubItems[1].Text = tboxNombre.Text;
                    user.SubItems[2].Text = tboxApellido.Text;
                    user.SubItems[3].Text = tbDireccion.Text;
                    user.SubItems[4].Text = tbUsuarioUsu.Text;
                    user.SubItems[5].Text = tbContrasUsu.Text;
                    user.SubItems[6].Text = chbEsSupervisor.Checked.ToString();

                    SalvaJson();
                    break;
                }
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            listUsuarios.Items.Clear();

            string textoJson = File.ReadAllText(_path);
            List<Usuarios> misUsuarios = JsonConvert.DeserializeObject<List<Usuarios>>(textoJson);

            foreach (Usuarios user in misUsuarios)//No es un metodo muy eficiente, pero para este ejercicio con tiempo limitado está bien.
            {
                if (user.DNI.Contains(tboxDNI.Text) && user.Nombre.Contains(tboxNombre.Text) && user.Apellido.Contains(tboxApellido.Text))
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = user.DNI;
                    lvi.SubItems.Add(user.Nombre);
                    lvi.SubItems.Add(user.Apellido);

                    listUsuarios.Items.Add(lvi);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ReestablecePantalla();
        }

        private void tboxNombre_TextChanged(object sender, EventArgs e)
        {
            HabilitaDeshabilitaBuscar();
        }

        private void HabilitaDeshabilitaBuscar()
        {
            if ((tboxNombre.Text.Length > 0 || tboxApellido.Text.Length > 0 ||  tboxDNI.Text.Length > 0) && tboxDNI.Enabled)
                btnBusca.Enabled = true;
            else
                btnBusca.Enabled = false;
        }

        private void tboxApellido_TextChanged(object sender, EventArgs e)
        {
            HabilitaDeshabilitaBuscar();
        }

        private void tboxDNI_TextChanged(object sender, EventArgs e)
        {
            HabilitaDeshabilitaBuscar();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txUsu.Text == "admin" && txContras.Text == "admin")
            {
                esUsuarioLogueado = true;
                this.Width = 490;
                ReestablecePantalla();
                MessageBox.Show("Login correcto!");
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        }
    }
}
