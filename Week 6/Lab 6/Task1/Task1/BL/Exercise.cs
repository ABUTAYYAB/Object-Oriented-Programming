using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Exercise
    {
        private string ExerciseName;
        private List<Set> Sets = new List<Set>();

        public Exercise()
        {

        }

        public Exercise(string exerciseName)
        {
            this.ExerciseName = exerciseName;
            Sets = new List<Set>();
        }

        public void SetName(string name)
        {
            this.ExerciseName = name;
        }

        public string GetName()
        {
            return this.ExerciseName;
        }

        public void AddSet(Set set)
        {
            Sets.Add(set);
        }

        public void RemoveSet(Set set)
        {
            Sets.Remove(set);
        }

        public void ShowExercise()
        {
            Console.WriteLine($"Exercise Name: {this.ExerciseName}");
            Console.WriteLine();
            Console.WriteLine("Sets: ");
            Console.WriteLine();
            foreach (Set set in Sets)
            {
                string name = set.GetName();
                Console.WriteLine($"Set Name: {name}");
                string reps = set.GetReps();
                Console.WriteLine($"Set Reps: {reps}");
                string weight = set.GetWeights();
                Console.WriteLine($"Set Weight: {weight}");
                Console.WriteLine();
            }
        }

    }
}
