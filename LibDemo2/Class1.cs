﻿using LibDemo4;
namespace LibDemo2
{
    public class LibClass2
    {
        private string _message;
        public LibClass2(string message) 
        {
            _message = Lib(message);
        }
		
		static string Lib(string txt)
		{
			LibClass4 Lib = new LibClass4(txt);
			return Lib.GetMessage4();			
		}
		
        public string GetMessage2()
        {
            return $"{_message} and from Library2";
        }
    }
}