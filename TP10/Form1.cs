using TP10.Modele;

namespace TP10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModeleConnexion.seConnecter();
            List<ModeleDeveloppeur> lesD = ModeleConnexion.RecupDeveloppeurs();

            BindingSource BS = new BindingSource();

            BS.DataSource = lesD;
            dgvDev.DataSource = BS;


            cbDev.Items.Clear();
            if (lesD.ToList().Count != 0)
            {
                foreach (ModeleDeveloppeur mp in lesD.ToList())
                {
                    cbDev.Items.Add(mp.Id + " - " + mp.prenom + " " + mp.nom);
                }
                dgvDev.DataSource = lesD;
            }
            else
            {
                MessageBox.Show("Pas de developpeurs enregistrées");
            }

        }

        private void cbDev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}