public class FizzBuzz()
{
    public string Say(int arabic)
    {
        BuzzRule buzzRule = new BuzzRule();
        if( buzzRule.isAccept(arabic) )
        {
            return buzzRule.Say();
        }
        if( arabic == 3 )
        {
            return "fizz";
        }
        return arabic.ToString();
    }
}
