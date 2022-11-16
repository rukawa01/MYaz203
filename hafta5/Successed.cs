namespace hafta5
{
    public class Successed : Result
    {
        public Successed() : base(true, "Success") { }

        public Successed(string message) : base(true, message)
        {

        }
    }

}
