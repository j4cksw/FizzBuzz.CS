public class FizzRule : Rule
{
    public bool IsAccept(int arabic)
    {
        return  arabic == 3 || arabic == 6;
    }

    public string Say(){
        return "fizz";
    }
}
