public class FizzBuzzRule : Rule
{
    public bool IsAccept(int arabic)
    {
        return arabic == 15 || arabic == 30 || arabic == 45;
    }

    public string Say()
    {
        return "fizzbuzz";
    }
}
