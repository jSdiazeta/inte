using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifradoAfin2
{
    public partial class CifradoAfin2 : Form
    {
        string MSLC = "";
        int ADecimacion = 0;
        int KDesplazamiento = 0;
        string alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        string criptograma = "";
        string ConcatenacionCriptograma = "";
        string MensajeDescrifrado = "";
        string ConcatenacionMensajeDes = "";


        public CifradoAfin2()
        {
            InitializeComponent();
            ControlesDesactivados();
        }

        //inicio controles
        public void ControlesDesactivados()
        {
            txtMensajeClaro.Enabled = false;
            txtADecimacion.Enabled = false;
            txtKDesplazamiento.Enabled = false;
            txtCriptograma.Enabled = false;
            btnEjecutar.Enabled = false;
            btnCifrar.Checked = false;
            btnDescifrar.Checked = false;
        }
        public void ActivarControles()
        {
            txtMensajeClaro.Enabled = true;
            txtADecimacion.Enabled = true;
            txtKDesplazamiento.Enabled = true;
            btnEjecutar.Enabled = true;
        }
        //Boton ejecutar
        private void btnEjectuar_Click(object sender, EventArgs e)
        {
            // variables para almacenar datos del procedimiento
            criptograma = "";
            ConcatenacionCriptograma = "";
            MensajeDescrifrado = "";
            ConcatenacionMensajeDes = "";

            // se asigan las variables del text box
            MSLC = txtMensajeClaro.Text;
            ADecimacion = int.Parse(txtADecimacion.Text);
            KDesplazamiento = int.Parse(txtKDesplazamiento.Text);

            //verificar el factor de dcimacion 
            if (GCD(ADecimacion, alfabeto.Length) != 1)
            {
                MessageBox.Show("El factor de decimacion: "+ADecimacion+"\n"+"Y la longitud de alfabeto NO son Primos relativos","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //si los datos son ingresados correctamente inicia el proceso de cifrado
            else
            {
                //cifrado
                if (btnCifrar.Checked==true)
                {
                    //recorre cada caracter del mensaje en claro
                    for (int i = 0; i < MSLC.Length; i++)
                    {
                        //asignar caracter por caracter a la primera columa del datagriewview
                        dtgProceso.ColumnCount++;
                        dtgProceso.Rows.Add(MSLC.Substring(i, 1).ToUpper());
                        dtgProceso.Columns[0].DefaultCellStyle.BackColor = Color.Coral;

                        //asignar a la segunda columna del datagriewview el valor numerico del mensaje en claro
                        dtgProceso.Rows[i].Cells[1].Value = alfabeto.IndexOf(dtgProceso.Rows[i].Cells[0].Value.ToString().ToUpper());
                        int EquivalenteNumerico = int.Parse(dtgProceso.Rows[i].Cells[1].Value.ToString());
                        dtgProceso.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;

                        //asignar a la tercera columa
                        int Decimacion = EquivalenteNumerico * ADecimacion;
                        dtgProceso.Rows[i].Cells[2].Value = Decimacion.ToString();
                        dtgProceso.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue;

                        int Desplazamiento = Decimacion + KDesplazamiento;
                        dtgProceso.Rows[i].Cells[3].Value = Desplazamiento.ToString();
                        dtgProceso.Columns[3].DefaultCellStyle.BackColor = Color.LightBlue;

                        int MOD = Desplazamiento % 27;
                        dtgProceso.Rows[i].Cells[4].Value = MOD.ToString();
                        dtgProceso.Columns[4].DefaultCellStyle.BackColor = Color.LightBlue;

                        string criptoAuxiliar = alfabeto.Substring(MOD);
                        criptograma = criptoAuxiliar.Substring(0, 1);
                        dtgProceso.Rows[i].Cells[5].Value = criptograma;
                        dtgProceso.Columns[5].DefaultCellStyle.BackColor = Color.LightGreen;

                        ConcatenacionCriptograma += criptograma;
                        dtgProceso.DefaultCellStyle.Font = new Font("Century Ghotic",12);
                        txtCriptograma.Text = ConcatenacionCriptograma;
                        txtCriptograma.Enabled = true;
                    }
                    MessageBox.Show("El criptograma resultante: " +ConcatenacionCriptograma+"\n"+"Corresponde al mensaje en claro: "+ MSLC.ToUpper(), "Resultado: ",MessageBoxButtons.OK,MessageBoxIcon.Information);   
                }

                if(btnDescifrar.Checked == true)
                {
                    //recorre cada caracter del mensaje en claro
                    for (int i = 0; i < MSLC.Length; i++)
                    {
                        //asignar caracter por caracter a la primera columa del datagriewview
                        dtgProceso.ColumnCount++;
                        dtgProceso.Rows.Add(MSLC.Substring(i, 1).ToUpper());
                        dtgProceso.Columns[0].DefaultCellStyle.BackColor = Color.Coral;

                        //asignar a la segunda columna del datagriewview el valor numerico del mensaje en claro
                        dtgProceso.Rows[i].Cells[1].Value = alfabeto.IndexOf(dtgProceso.Rows[i].Cells[0].Value.ToString().ToUpper());
                        int EquivalenteNumerico = int.Parse(dtgProceso.Rows[i].Cells[1].Value.ToString());
                        dtgProceso.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;

                        //asignar a la tercera columa
                        int Decimacion = EquivalenteNumerico * ADecimacion;
                        dtgProceso.Rows[i].Cells[2].Value = Decimacion.ToString();
                        dtgProceso.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue;

                        int Desplazamiento = Decimacion - KDesplazamiento;
                        dtgProceso.Rows[i].Cells[3].Value = Desplazamiento.ToString();
                        dtgProceso.Columns[3].DefaultCellStyle.BackColor = Color.LightBlue;

                        int MOD = Desplazamiento % 27;
                        dtgProceso.Rows[i].Cells[4].Value = MOD.ToString();
                        dtgProceso.Columns[4].DefaultCellStyle.BackColor = Color.LightBlue;

                        //


                    }
                    for (int i = 0; i < alfabeto.Length; i++)
                    {
                        int aux = ADecimacion * i;
                        int auxMod = aux % alfabeto.Length;

                        if (auxMod==1)
                        {
                            for (int recorrido = 0; recorrido < MSLC.Length; recorrido++)
                            {
                                string letraCripto = MSLC.Substring(recorrido, 1).ToUpper();
                                int ValorNumericoCripto = alfabeto.IndexOf(letraCripto);
                                int NumericoMSLCaux = (i * (ValorNumericoCripto - KDesplazamiento));

                                do
                                {
                                    NumericoMSLCaux = NumericoMSLCaux + alfabeto.Length;
                                } while (NumericoMSLCaux<0);

                                int EquivalenteNumMSLC = NumericoMSLCaux % alfabeto.Length;

                                string MensajeClaroAux = alfabeto.Substring(EquivalenteNumMSLC);
                                MensajeDescrifrado = MensajeClaroAux.Substring(0, 1);
                                ConcatenacionMensajeDes += MensajeDescrifrado;

                                txtCriptograma.Text = ConcatenacionMensajeDes;
                                txtCriptograma.Enabled = false;

                            }
                        }
                    }
                    MessageBox.Show("El criptograma: "+MSLC.ToUpper()+"\n"+"Da como resultado el mensaje en claro: "+ ConcatenacionMensajeDes, "Resultado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
        //metodo para validar el valor de aproximaxion sea correcto
        static int GCD (int a , int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMensajeClaro.Text = "";
            txtADecimacion.Text = "";
            txtKDesplazamiento.Text = "";
            txtCriptograma.Text = "";
            dtgProceso.Rows.Clear();
            btnCifrar.Checked = false;
            btnDescifrar.Checked = false;

            dtgProceso.Columns[0].DefaultCellStyle.BackColor = Color.White;
            dtgProceso.Columns[1].DefaultCellStyle.BackColor = Color.White;
            dtgProceso.Columns[2].DefaultCellStyle.BackColor = Color.White;
            dtgProceso.Columns[3].DefaultCellStyle.BackColor = Color.White;
            dtgProceso.Columns[4].DefaultCellStyle.BackColor = Color.White;
            dtgProceso.Columns[5].DefaultCellStyle.BackColor = Color.White;

            ControlesDesactivados();
        }

        // validaciones
        private void txtMensajeClaro_Key(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtK_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            ActivarControles();
        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            ActivarControles();
        }

        private void txtClaro_changued(object sender, EventArgs e)
        {
            txtMensajeClaro.SelectionStart = txtMensajeClaro.Text.Length;
            txtMensajeClaro.Text = txtMensajeClaro.Text.ToUpper();
        }


    }
}
