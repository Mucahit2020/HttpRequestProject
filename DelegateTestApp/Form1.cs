using DelegateTestApp.RepuestCreators;

namespace DelegateTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var req = new GetPostRequestCreator();
            var post = req.GetPosts();

            MessageBox.Show(post.FirstOrDefault().title);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var req = new CreatePostRequestCreator();
            var createPost = req.CreatePost(new Models.PostModel()              
            {
                title="foo",
                body="bar",
                userId=1,

            });


            MessageBox.Show($"result Id: {createPost.id}");
        }
    }
}
