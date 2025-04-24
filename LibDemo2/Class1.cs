namespace LibDemo2
{
    public class LibClass2
    {
        private string _message;
        public LibClass2(string message) 
        {
            _message = message;
        }
        public string GetMessage()
        {
            return $"{_message} from Library2";
        }
    }
}
