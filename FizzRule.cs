public class FizzRule : Rule
{
    public bool IsAccept(int arabic)
    {
        return  arabic == 3 || arabic == 6 || arabic == 9;
    }

    public string Say(){
        return "fizz";
    }
}
