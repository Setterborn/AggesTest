namespace AggesTest.Model
{
    public class Question
    {
        public int Id { get; set; }
        public string TheQuestion { get; set; }

        public Question(int id, string theQuestion)
        {
            Id = id;
            TheQuestion = theQuestion;
        }
    }
}
