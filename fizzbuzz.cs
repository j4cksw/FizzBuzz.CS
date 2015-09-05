public class FizzBuzz()
{
    public string Say(int arabic)
    {
        []Rule rules = new []Rule{ new BuzzRule(), new FizzRule()};
        
        forEach(Rule rule in rules)
        {
            if ( rule.IsAccept(arabic) )
            {
                return rule.Say();
            }
        }
        return arabic.ToString();
    }
}
