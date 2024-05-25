namespace WebApplication1
{
    public class TestClass
    {
        public int kidNumber { get; set; }
        public string kidResponse { get; set; }
    }

    public class ResultfClass
    {
        public bool isValid { get; set; }
        public string expectedResponse { get; set; }

        public string error { get; set; }
    }
}
