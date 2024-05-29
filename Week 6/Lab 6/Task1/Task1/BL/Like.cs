using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Like
    {
        private string LikeName;
        public Like() { }
        public Like(string name)
        {
            this.LikeName = name;
        }

        public void GiveLike(string name)
        {
            this.LikeName = name;
        }

        public string GetLikeName()
        {
            return this.LikeName;
        }
    }
}
