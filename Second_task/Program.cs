namespace Second_task
{
    internal class Program
    {
        public static bool SearchWordInString(string word,string str) 
        {
            bool serach = false;
            foreach (var item in str)
            {
                if (item == word[0])
                {
                    for (int i = str.IndexOf(item),j=0; i < str.IndexOf(item)+word.Length && j<word.Length; i++,j++)
                    {
                        if (str[i] == word[j])
                        {
                            serach = true;
                        }
                        else
                        {
                            serach = false;
                            break;
                        }    
                    }
                }
            }
            return serach;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть рядок в якому відбуватиметься пошук:");
            string str = Console.ReadLine();
            Console.WriteLine("Введіть шукане слово:");
            string word = Console.ReadLine();
            Console.WriteLine("Результат роботи функції SearchWordInString: " + SearchWordInString(word,str));
        }
    }
}