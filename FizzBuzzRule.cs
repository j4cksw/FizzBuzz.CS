public class FizzBuzzRule : Rule
{
    Rule fizzRule = new FizzRule();
    Rule buzzRule = new BuzzRule();

    public bool IsAccept(int arabic)
    {
        return fizzRule.IsAccept(arabic) && buzzRule.IsAccept(arabic);
    }

    public string Say()
    {
        return fizzRule.Say() + buzzRule.Say();
    }
}
