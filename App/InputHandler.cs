public class InputHandler
{
    public static List<string> ParseInput(string[] args)
    {
        /*
            ***********************************************
            * This method expects exactly one argument     *
            * in the format: dotnet run "A B C D ..."      *
            ***********************************************
        */

        if (args.Length != 1)
        {
            throw new ArgumentException("Please pass exactly quoted input string.");
        }

        var rawInput = args[0];
        var parts = rawInput.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        return [.. parts];
    }
}
