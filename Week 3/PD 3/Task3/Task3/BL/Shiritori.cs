using System.Collections.Generic;

namespace Task3.BL
{
    internal class Shiritori
    {

        public List<string> words;
        public bool game_over;

        public Shiritori()
        {
            words = new List<string>();
            game_over = false;
        }
        public string Play(string word)
        {
            if (game_over)
            {
                return "gameover";
            }

            if (words.Count > 0)
            {
                string last_word = words[words.Count - 1];
                if (last_word[last_word.Length - 1] != word[0])
                {
                    game_over = true;
                    return "gameover";
                }
            }

            words.Add(word);
            return word;
        }

        public string Restart()
        {
            words.Clear();
            game_over = false;
            return "game restarted";
        }

    }
}
