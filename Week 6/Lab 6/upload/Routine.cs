using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Routine
    {

        private string RoutineName;
        private List<Exercise> ExerciseList = new List<Exercise>();

        public Routine()
        {

        }

        public Routine(string routineName, List<Exercise> exerciseList)
        {
            RoutineName = routineName;
            ExerciseList = new List<Exercise>();
        }

        public void SetName(string name)
        {
            this.RoutineName = name;
        }

        public string GetName()
        {
            return this.RoutineName;
        }

        public void AddExercise(Exercise exercise)
        {
            ExerciseList.Add(exercise);
        }

        public void RemoveExercise(Exercise exercise)
        {
            ExerciseList.Remove(exercise);
        }

        public void ViewRoutine()
        {
            Console.WriteLine($"Routine Name: {this.RoutineName}");
            Console.WriteLine();
            Console.WriteLine("Exercises: ");
            Console.WriteLine();
            foreach (Exercise exercise in ExerciseList)
            {
                exercise.ShowExercise();
                Console.WriteLine();
            }
        }
    }
}
