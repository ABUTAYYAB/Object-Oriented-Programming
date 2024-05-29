using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Book
    {
        public Book(string name)
        {
            this.Name = name;
        }
        private string Name;
        private Author Auther_;
        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void MakeAuthor(string name)
        {
            Auther_ = new Author(name);
        }
        public string GetNameAuthor()
        {
            return Auther_.GetName();
        }
        public void SetAuthor(string name)
        {
            Auther_.SetName(name);
        }

    }
}
