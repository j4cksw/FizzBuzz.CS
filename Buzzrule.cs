public class BuzzRule : Rule
{
    public bool IsAccept(int arabic)
    {
        return (arabic % 5) == 0;
    }

    public string Say(){
        return "buzz";
    }
}
