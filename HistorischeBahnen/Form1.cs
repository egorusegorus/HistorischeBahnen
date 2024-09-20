using MySqlConnector;
using NPoco;
using System.Configuration;
using System.Diagnostics;

namespace HistorischeBahnen
{
    public partial class Form1 : Form
    {
        string ConnectionString { get; init; } = ConfigurationManager.ConnectionStrings["mariadb"].ConnectionString;
        //static List<HB> hBs = new List<HB>();
        public Form1()
        {
            InitializeComponent();
            GridInitialisieren();

        }
        private void GridInitialisieren()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void HBAnzeigen(List<HB> lst)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lst;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private List<HB> KontakteLaden()
        {
            List<HB> lst = new();
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                connection.Open();
                string sql = "order by ID, ZugName";
                lst = db.Fetch<HB>(sql);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return lst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<HB> lst = KontakteLaden();
            HBAnzeigen(lst);
        }

        private void HBAnzeigen(HB k)
        {
            if (k == null)
                return;
            txtId.Text = Convert.ToString(k.ID);
            txtNamedesZugeges.Text = k.ZugName;
            txtProduktionsdatum.Text = Convert.ToString(k.ProduktionsDatum);
            txtGewichtinKg.Text = Convert.ToString(k.GewichtInKG);
            txtBeschreibung.Text = k.ZugBeschreibung;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HB? k = dataGridView1.CurrentRow.DataBoundItem as HB;
            if (k == null)
                return;
            HBAnzeigen(k);
        }
        private void HBHinzufügen(HB k)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                db.Connection.Open();
                db.Insert(k);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private void HBÄndern(HB k)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                db.Connection.Open();
                db.Update(k);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }


        private void HBLöschen(HB k)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                db.Connection.Open();
                db.Delete(k);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            HB k = new HB();


            k.ZugName = txtNamedesZugeges.Text;
            k.ProduktionsDatum = Convert.ToDateTime(txtProduktionsdatum.Text);
            k.GewichtInKG = Convert.ToInt32(txtGewichtinKg.Text);
            k.ZugBeschreibung = txtBeschreibung.Text;

            k.Erstellt = DateTime.Now;
            if (String.IsNullOrEmpty(txtNamedesZugeges.Text) || String.IsNullOrEmpty(txtProduktionsdatum.Text) || String.IsNullOrEmpty(txtGewichtinKg.Text) || String.IsNullOrEmpty(txtBeschreibung.Text))
            {
                MessageBox.Show("Die Felder dürfen nicht leer sein.");
                return;
            }

            //HB k = new HB(0, txtNamedesZugeges.Text,Convert.ToDateTime (txtProduktionsdatum.Text),Convert.ToInt32(txtGewichtinKg.Text), txtBeschreibung.Text);
            HBHinzufügen(k);
            List<HB> lst = KontakteLaden();
            HBAnzeigen(lst);
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            HB k = new HB();

            k.ID = Convert.ToInt32(txtId.Text);

            HBLöschen(k);
            List<HB> lst = KontakteLaden();
            HBAnzeigen(lst);
        }

        private void btnÄÄndern_Click(object sender, EventArgs e)
        {
            HB k = new HB();
            k.ID = Convert.ToInt32(txtId.Text);
            k.ZugName = txtNamedesZugeges.Text;
            k.ProduktionsDatum = Convert.ToDateTime(txtProduktionsdatum.Text);
            k.GewichtInKG = Convert.ToInt32(txtGewichtinKg.Text);
            k.ZugBeschreibung = txtBeschreibung.Text;
            k.Geandert = DateTime.Now;

            
            HBÄndern(k);
            List<HB> lst = KontakteLaden();
            HBAnzeigen(lst);

        }
    }
}