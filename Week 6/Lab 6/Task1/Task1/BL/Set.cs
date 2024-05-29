using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Set
    {
        private string Name;
        private string Reps;
        private string Weights;

        public Set()
        {

        }
        public Set(string setName, string reps, string weights)
        {
            this.Name = setName;
            this.Reps = reps;
            this.Weights = weights;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetReps(string reps)
        {
            this.Reps = reps;
        }

        public void SetWeights(string weights)
        {
            this.Weights = weights;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetReps()
        {
            return this.Reps;
        }

        public string GetWeights()
        {
            return this.Weights;
        }

    }
}
