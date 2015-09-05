public class FizzBuzz()
{
    public string Say(int arabic)
    {
        []Rule rules = new []Rule{ new BuzzRule(), new FizzRule()};
        if( rules[0].isAccept(arabic) )
        {
            return rules[0].Say();
        }
        if( rules[1].isAccept(arabic) )
        {
            return rules[1].Say();
        }
        return arabic.ToString();
    }
}
