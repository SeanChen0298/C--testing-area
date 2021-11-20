using System.Collections.Generic;

namespace TestArea
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<string> stack = new Stack<string>();
            foreach (char character in s)
            {
                if (character == '(')
                {
                    stack.Push(")");
                }
                else if (character == '[')
                {
                    stack.Push("]");
                }
                else if (character == '{')
                {
                    stack.Push("}");
                }
                else if (stack.Pop() != character.ToString())
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}