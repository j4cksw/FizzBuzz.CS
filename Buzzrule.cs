public class BuzzRule : Rule
{
    public bool IsAccept(int arabic)
    {
        return arabic == 5;
    }

    public string Say(){
        return "buzz";
    }
}
