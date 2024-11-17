namespace Spike.SwitchStatementHandlesSomeKnownEnumValuesWithDefault;

class Program
{
    static void Main(string[] args)
    {
        DoSomething(RandomEnum.OptionFour);
    }

    private static void DoSomething(RandomEnum randomEnum)
    {
        switch (randomEnum)
        {
            case RandomEnum.OptionOne:
                break;
            case RandomEnum.OptionTwo:
                break;
        }
    }
}