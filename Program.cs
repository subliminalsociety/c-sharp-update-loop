namespace APP
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Here we create a new instance of the UpdateHandler...
            UpdateHandler UpdateHandler_Instance = new UpdateHandler();

            //UpdateHandler.Start() is the method that needs to be called to start the update loop.
            UpdateHandler_Instance.Start();
        }
    }
}
