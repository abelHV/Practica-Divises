using Newtonsoft.Json;
using Practica_Divises.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Divises
{
    public partial class FrmMain : Form
    {
        private Dictionary<string, ClDivisas> TotesLesDivises;
        private const string BaseUrlHexaRate = "https://hexarate.paikama.co/api/rates/latest";
        private const string BaseUrlRatesDB = "https://free.ratesdb.com/v1";
        public FrmMain()
        {
            InitializeComponent();

            CarregarDivises();
            ConfigurarDesplegables();
        }

        private void CarregarDivises()
        {
            string camiFitxer = "currencies.json";

            try
            {
                string textJson = File.ReadAllText(camiFitxer);

                var TotesLesDivisesTemporal = JsonConvert.DeserializeObject<Dictionary<string, ClDivisas>>(textJson);

                TotesLesDivises = new Dictionary<string, ClDivisas>();

                foreach (var item in TotesLesDivisesTemporal)
                {
                    string codi = item.Key;
                    ClDivisas divisa = item.Value;

                    divisa.Codi = codi;

                    TotesLesDivises.Add(codi, divisa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al carregar les dades de divises: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TotesLesDivises = new Dictionary<string, ClDivisas>();
            }
        }
        private void ConfigurarDesplegables()
        {
            if (TotesLesDivises != null && TotesLesDivises.Count > 0)
            {
                List<ClDivisas> llistaDivises = TotesLesDivises.Values.ToList();

                cbDivises1.DataSource = new List<ClDivisas>(llistaDivises);
                cbDivises2.DataSource = new List<ClDivisas>(llistaDivises);
                cbHistorialOrigen.DataSource = new List<ClDivisas>(llistaDivises);
                cbHistorialDesti.DataSource = new List<ClDivisas>(llistaDivises);

                cbDivises1.DisplayMember = "NomComplet";
                cbDivises2.DisplayMember = "NomComplet";
                cbHistorialOrigen.DisplayMember = "NomComplet";
                cbHistorialDesti.DisplayMember = "NomComplet";

                cbDivises1.ValueMember = "Codi";
                cbDivises2.ValueMember = "Codi";
                cbHistorialOrigen.ValueMember = "Codi";
                cbHistorialDesti.ValueMember = "Codi";

                if (cbDivises1.Items.Count > 0)
                {
                    cbDivises1.SelectedIndex = 0;
                }
                if (cbDivises2.Items.Count > 1)
                {
                    cbDivises2.SelectedIndex = 1;
                }
            }
        }


        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir?", "QÜESTIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

           
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            lbValor1.Text = "Processant la informació...";
            lbValor2.Text = "";
            _ = consultaActualAsincrona();
        }

        private async Task consultaActualAsincrona()
        {
            Cursor = Cursors.WaitCursor;
            Task TascaConsulta = ConsultarDivisaActual();
            await TascaConsulta;
            Cursor = Cursors.Default;
        }
        private async Task ConsultarDivisaActual()
        {
            if (!(cbDivises1.SelectedItem is ClDivisas divisaOrigen) ||
                !(cbDivises2.SelectedItem is ClDivisas divisaDesti))
            {
                lbValor1.Text = "Selecciona ambdues divises.";
                return;
            }

            string codiOrigen = divisaOrigen.Codi;
            string codiDesti = divisaDesti.Codi;
            decimal import = nupValor.Value;

            if (import <= 0)
            {
                lbValor1.Text = "Error: Import no vàlid.";
                return;
            }

            string uriPeticio = $"{BaseUrlHexaRate}/{codiOrigen}?target={codiDesti}";

            HttpClient client = new HttpClient();
            HttpRequestMessage peticio = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(uriPeticio),
            };

            try
            {
                using (var resposta = await client.SendAsync(peticio))
                {
                    resposta.EnsureSuccessStatusCode();
                    var cos = await resposta.Content.ReadAsStringAsync();

                    ResultatHexaRate resultatApi = JsonConvert.DeserializeObject<ResultatHexaRate>(cos);

                    if (resultatApi?.Dades != null)
                    {
                        double taxa = resultatApi.Dades.Taxa;
                        double resultatConversio = (double)import * taxa;

                        lbValor1.Text = $"{import:N2} {codiOrigen}";
                        lbValor2.Text = $"{resultatConversio:N2} {codiDesti} (Taxa: {taxa:N4})";
                    }
                    else
                    {
                        lbValor1.Text = "Error: Les dades de conversió no s'han trobat a la resposta de l'API.";
                        lbValor2.Text = "L'objecte 'data' estava buit o la deserialització va fallar.";
                    }
                }
            }
            catch (Exception ex)
            {
                lbValor1.Text = $"Error de connexió/API: {ex.Message}";
                lbValor2.Text = "No s'ha pogut obtenir el canvi.";
            }
        }
        private async Task consultaHistorialAsincrona()
        {
            Cursor = Cursors.WaitCursor;
            Task TascaConsulta = ConsultarHistorialDivisa();
            await TascaConsulta;
            Cursor = Cursors.Default;
        }

        private async Task ConsultarHistorialDivisa()
        {
            if (!(cbHistorialOrigen.SelectedItem is ClDivisas divisaOrigen) ||
                !(cbHistorialDesti.SelectedItem is ClDivisas divisaDesti))
            {
                MessageBox.Show("Si us plau, selecciona ambdues divises.", "Error de Selecció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dataInici = dtpDataInici.Value.Date;
            DateTime dataFinal = dtpDataFinal.Value.Date;
            decimal import = nupHistorialImport.Value;

            if (dataInici > dataFinal)
            {
                MessageBox.Show("La data d'inici no pot ser posterior a la data final.", "Error de Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (import <= 0)
            {
                MessageBox.Show("Introdueix un import vàlid.", "Error d'Import", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var historialFinal = new List<object>();
            HttpClient client = new HttpClient();

            for (DateTime data = dataInici; data <= dataFinal; data = data.AddDays(1))
            {
                string dataString = data.ToString("yyyy-MM-dd");

                string uriPeticio = $"{BaseUrlRatesDB}/rates?from={divisaOrigen.Codi}&to={divisaDesti.Codi}&date={dataString}";

                try
                {
                    using (var resposta = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, new Uri(uriPeticio))))
                    {
                        resposta.EnsureSuccessStatusCode();
                        var cos = await resposta.Content.ReadAsStringAsync();

                        ResultatRatesDB resultat = JsonConvert.DeserializeObject<ResultatRatesDB>(cos);

                        if (resultat?.Dades?.Taxes != null && resultat.Dades.Taxes.ContainsKey(divisaDesti.Codi))
                        {
                            double taxa = resultat.Dades.Taxes[divisaDesti.Codi];
                            double resultatConversio = (double)import * taxa;

                            historialFinal.Add(new
                            {
                                Data = data.ToShortDateString(),
                                Taxa = $"{divisaOrigen.Codi}/{divisaDesti.Codi}: {taxa:N4}",
                                Canvi = $"{resultatConversio:N2} {divisaDesti.Codi}"
                            });
                        }
                    }
                }
                catch (HttpRequestException)
                {
                }
            }

            if (historialFinal.Any())
            {
                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvHistorial.DataSource = historialFinal;
                dgvHistorial.Columns[0].HeaderText = "Data";
                dgvHistorial.Columns[1].HeaderText = "Taxa de Canvi";
                dgvHistorial.Columns[2].HeaderText = $"Import ({import:N2} {divisaOrigen.Codi})";
            }
            else
            {
                MessageBox.Show("No s'han trobat dades d'historial per al període seleccionat.", "Sense Resultats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Canvi_Click(object sender, EventArgs e)
        {
            this.Text = "Canvi de divises";
            lbTitol.Text = "Canvi";
                this.Show();
                this.WindowState = FormWindowState.Normal;
                GestioControlsCanviActual(true);
                GestioControlsHistorial(false);

            
        }

        private void Historial_Click(object sender, EventArgs e)
        {
            this.Text = "Historial";
            lbTitol.Text = "Historial";




            GestioControlsCanviActual(false);
                GestioControlsHistorial(true);
                
            
            this.Activate();

        }

        private void GestioControlsCanviActual(bool actiu)
        {

            cbDivises1.Visible = actiu;
            cbDivises2.Visible = actiu;
            nupValor.Visible = actiu;
            btMostrar.Visible = actiu;

        
                this.Show();
                this.WindowState = FormWindowState.Normal;
                lbValor1.Text = "";
                lbValor2.Text = "";
            
        }

        private void GestioControlsHistorial(bool actiu)
        {

            cbHistorialOrigen.Visible = actiu;
            cbHistorialDesti.Visible = actiu;
            nupHistorialImport.Visible = actiu;
            dtpDataInici.Visible = actiu;
            dtpDataFinal.Visible = actiu;
            btMostrarHistorial.Visible = actiu;
            dgvHistorial.Visible = actiu;


            if (!actiu)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                dgvHistorial.DataSource = null;
            }
        }

        private void btMostrarHistorial_Click_1(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = null;
            _ = consultaHistorialAsincrona();
        }

       
    }
}
