using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Comment
    {
        private string CommentContent;
        private string CommentBy;

        public Comment(string CommentContent, string CommentBy)
        {
            this.CommentContent = CommentContent;
            this.CommentBy = CommentBy;
        }

        public Comment() { }

        public void SetComment(string CommentContent)
        {
            this.CommentContent = CommentContent;
        }

        public string GetCommentContent()
        {
            return this.CommentContent;
        }

        public void SetCommentBy(string CommentBy)
        {
            this.CommentBy = CommentBy;
        }

        public string GetCommentBy()
        {
            return this.CommentBy;
        }
    }
}
