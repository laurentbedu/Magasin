namespace Magasin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Article> articles = new List<Article>();
        private void buttonAddArticle_Click(object sender, EventArgs e)
        {
            Article newArticle = new Article(
                textBoxReference.Text,
                textBoxDesignation.Text,
                (double)numericUpDownPrixHT.Value,
                Taxe.Tx5);
            articles.Add(newArticle);
            listBoxArticles.Items.Add(newArticle.ToString());

            



            textBoxReference.Text = textBoxDesignation.Text = "";
            numericUpDownPrixHT.Value = 0;
        }
    }
}