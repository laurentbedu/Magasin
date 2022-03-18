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
                TxTaxe.Tx5);
            articles.Add(newArticle);
            listBoxArticles.Items.Add(newArticle.ToString());

            CustomControl1 cc1 = new CustomControl1(newArticle.Designation);
            cc1.Top = (articles.Count - 1) * 100;
            panel2.Controls.Add(cc1);
            



            textBoxReference.Text = textBoxDesignation.Text = "";
            numericUpDownPrixHT.Value = 0;
        }
    }
}