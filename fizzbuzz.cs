public class FizzBuzz()
{
    public string Say(int arabic)
    {
        []Rule rules = new []Rule{ new BuzzRule()};
        if( rules[0].isAccept(arabic) )
        {
            return rules[0].Say();
        }
        FizzRule fizzRule = new FizzRule();
        if( fizzRule.isAccept(arabic) )
        {
            return fizzrule.Say();
        }
        return arabic.ToString();
    }
}
