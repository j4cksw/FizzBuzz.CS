public class FizzBuzz()
{
    public string Say(int arabic)
    {
        BuzzRule buzzRule = new BuzzRule();
        if( buzzRule.isAccept(arabic) )
        {
            return buzzRule.Say();
        }
        FizzRule fizzRule = new FizzRule();
        if( fizzRule.isAccept(arabic) )
        {
            return fizzrule.Say();
        }
        return arabic.ToString();
    }
}
