namespace AggesTest.Model
{
    public class Answer
    {
        public int Id { get; set; }
        public string TheAnswer { get; set; }

        public Answer(int id, string theAnswer)
        {
            Id = id;
            TheAnswer = theAnswer;
        }
    }
}
