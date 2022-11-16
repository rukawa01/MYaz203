namespace hafta5
{
    public class Failed : Result
    {
        public Failed() : base(false, "fail") { }

        public Failed(string message) : base(false, message)
        {

        }
    }

}
