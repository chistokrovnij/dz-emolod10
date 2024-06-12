namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private Blog blog = new Blog();

        public Form1()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            Button addArticleButton = new Button
            {
                Text = "Add Article",
                Location = new Point(10, 10)
            };

            addArticleButton.Click += AddArticleButton_Click;

            Controls.Add(addArticleButton);
        }

        private void AddArticleButton_Click(object sender, EventArgs e)
        {
            User author = new User("author@example.com", "password123");
            Article newArticle = new Article("Sample Title", "Sample Textd", author);
            blog.AddArticle(newArticle);
            MessageBox.Show("Article added!");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
