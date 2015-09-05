public class FizzRule : Rule
{
    public bool IsAccept(int arabic)
    {
        return  (arabic % 3) == 0;
    }

    public string Say(){
        return "fizz";
    }
}
