using System;
using Task1.BL;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }
        static void Task1()
        {
            Book book = new Book("Physics");
            book.MakeAuthor("Hannan");

            Console.WriteLine("Book Name is: " + book.GetName());
            Console.WriteLine("Author Name is: " + book.GetNameAuthor());
            Console.ReadLine();

        }
        static void Task2()
        {
            Playlist list = new Playlist("My Playlist");
            for (int i = 0; i < 5; i++)
            {
                Song s = new Song("Mera Gana");
                list.AddSong(s);
            }

            Console.WriteLine("Playlist Name is: " + list.GetName());

            for (int i = 0; i < list.GetList().Count; i++)
            {
                Console.WriteLine("Song Name is: " + list.GetList()[i].GetName());

            }

            Console.ReadLine();

        }
        static void Task3()
        {
            Set set1 = new Set();
            Set set2 = new Set();
            set1.SetName("Set 1");
            set1.SetReps("1 reps");
            set1.SetWeights("1 kg");
            set2.SetName("Set 2");
            set2.SetReps("1 reps");
            set2.SetWeights("2 kg");

            Exercise exercise1 = new Exercise();
            Exercise exercise2 = new Exercise();
            exercise1.SetName("abc");
            exercise1.AddSet(set1);
            exercise1.AddSet(set2);
            exercise2.SetName("pata ni");
            exercise2.AddSet(set1);

            Routine routine = new Routine();

            routine.SetName("ajeeb");
            routine.AddExercise(exercise1);
            routine.AddExercise(exercise2);
            routine.ViewRoutine();

            Console.ReadKey();
        }
        static void Task4()
        {
            User u1 = new User("Malik");
            User u2 = new User("Pati");

            Console.WriteLine($"Welcome {u1.GetUsername()}\n");
            u1.AddFollower(u2);
            u1.AddPost();
            u1.AddComment();
            u1.AddLike();
            u1.ViewUser();
            Console.ReadKey();

        }
    }
}
