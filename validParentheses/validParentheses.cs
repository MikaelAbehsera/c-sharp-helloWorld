public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        // this should end up as a 0 for a perfect stack
        int balance = 0;

        // loop on all chars, selecting relevant ones
        foreach (char c in input)
        {
            if( c == "(" )
            {
                balance++;
            }
            else if ( c == ")" )
            {
                balance--;
            }
        }

        // check if there is balance
        if (balance == 0)
        {
            return true;
        }
        // if no balance return false
        return false;
    }
}