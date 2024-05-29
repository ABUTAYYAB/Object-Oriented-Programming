using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Post
    {
        private string PostContent;
        private List<Comment> CommentList = new List<Comment>();
        private List<Like> LikesList = new List<Like>();

        public Post() { }

        public Post(string postContent)
        {
            this.PostContent = postContent;
            this.CommentList = new List<Comment>();
            this.LikesList = new List<Like>();
        }

        public void CreatePost(string postContent)
        {
            this.PostContent = postContent;
        }

        public void UpdatePost(string postContent)
        {
            this.PostContent = postContent;
        }

        public string GetPost()
        {
            return this.PostContent;
        }

        public void AddComment()
        {
            Comment comment = new Comment();
            Console.Write("Enter Your Name To Comment: ");
            string name = Console.ReadLine();
            comment.SetCommentBy(name);
            Console.Write("Enter Comment: ");
            string c = Console.ReadLine();
            Console.WriteLine();
            comment.SetComment(c);
            this.CommentList.Add(comment);
        }

        public void AddLike()
        {
            Like like = new Like();
            Console.Write("Enter Your Name To Like: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            like.GiveLike(name);
            this.LikesList.Add(like);
        }

        public void ViewPost()
        {
            Console.WriteLine($"Post: {this.PostContent}");
            Console.WriteLine();
            Console.WriteLine("Comments: \n");
            foreach (Comment comment in this.CommentList)
            {
                string Content = comment.GetCommentContent();
                string ContentBy = comment.GetCommentBy();
                Console.WriteLine($"{ContentBy} Commented -{Content}-");
                Console.WriteLine();
            }
            Console.WriteLine("Likes:\n");
            foreach (Like like in this.LikesList)
            {
                string LikeBy = like.GetLikeName();
                Console.WriteLine(LikeBy);
            }
        }
    }
}
