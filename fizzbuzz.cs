public class FizzBuzz
{
    public string Say(int arabic)
    {
        Rule[] rules = new Rule[]{ new FizzBuzzRule(), new BuzzRule(), new FizzRule()};

        foreach(Rule rule in rules)
        {
            if ( rule.IsAccept(arabic) )
            {
                return rule.Say();
            }
        }
        return arabic.ToString();
    }
}
