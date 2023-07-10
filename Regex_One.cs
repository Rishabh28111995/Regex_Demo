using System;
using System.Text.RegularExpressions;

namespace Regex_Demo
{
	//A Regex (regular expression) is a pattern that is used to check whether
	//a given string matches a pattern.
	public class Regex_One
	{
		static string pattern = "^cen$";
		//^ indicates start of string.
		//$ indicates end of string.

        public void MyRegex()
		{
			//We have created object of the class
			//We have pass a parameter pattern in given class constructor
			Regex regex = new Regex(pattern);
			if (regex.IsMatch("rishabh"))
			{
				Console.WriteLine("String match the Pattern");
			}
			else
			{
				Console.WriteLine("Does not match the Pattern");
			}
		}
		
	}
}

