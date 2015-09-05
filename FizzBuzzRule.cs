public class FizzBuzzrule : Rule
{
    public bool IsAccept(int arabic)
    {
        return arabic == 15;
    }

    public string Say()
    {
        return "fizzbuzz";
    }
}
