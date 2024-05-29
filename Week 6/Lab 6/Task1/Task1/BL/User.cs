using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class User
    {
        private string UserName;
        private List<Post> Posts = new List<Post>();
        private List<User> Followers = new List<User>();

        public User() { }

        public User(string userName)
        {
            UserName = userName;
            Posts = new List<Post>();
            Followers = new List<User>();
        }

        public void SetUsername(string username)
        {
            this.UserName = username;
        }

        public string GetUsername()
        {
            return this.UserName;
        }

        public void AddPost()
        {
            Post post = new Post();
            Console.Write("Enter Post Content: ");
            string content = Console.ReadLine();
            Console.WriteLine();
            post.CreatePost(content);
            Posts.Add(post);
        }

        public void AddFollower(User user)
        {
            Followers.Add(user);
        }

        public void ViewUser()
        {
            Console.WriteLine($"UserName: {this.UserName}");
            Console.WriteLine();
            Console.Write("Followers: ");
            foreach (User user in this.Followers)
            {
                Console.Write(user.UserName);
            }
            Console.WriteLine("\n\nPosts: \n");
            foreach (Post post in this.Posts)
            {
                post.ViewPost();
                Console.WriteLine();
            }

        }

        public void AddComment()
        {
            this.Posts[0].AddComment();
        }

        public void AddLike()
        {
            this.Posts[0].AddLike();
        }
    }
}
