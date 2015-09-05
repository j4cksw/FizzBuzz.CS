public class FizzBuzzRule : Rule
{
    public bool IsAccept(int arabic)
    {
        return arabic == 15 || arabic == 30;
    }

    public string Say()
    {
        return "fizzbuzz";
    }
}
