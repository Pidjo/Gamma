namespace System.Data
{
    internal class ConnetionState
    {
        public static ConnectionState Closed { get; internal set; }
        public static ConnectionState Open { get; internal set; }
    }
}