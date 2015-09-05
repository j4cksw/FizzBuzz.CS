public class FizzBuzz()
{
    public string Say(int arabic)
    {
        if( arabic == 5 )
        {
            return "buzz"; 
        }
        if( arabic == 3 )
        {
            return "fizz";
        }
        return arabic.ToString();
    }
}
