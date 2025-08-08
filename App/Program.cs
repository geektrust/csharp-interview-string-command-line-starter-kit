using System;
using System.Collections.Generic;

class Program
{
    /*
        ***********************************************
        * This is the driver code. Don't change it!!! *
        ***********************************************

        Format of the 'args' array: "Input1 Input2 Input3"
        Example: dotnet run "Input1 Input2 Input3"

        The code evaluator will execute this code using the command:
        dotnet run "Input1 Input2 Input3"
    */

    static void Main(string[] args)
    {
        try
        {
            var inputs = InputHandler.ParseInput(args);
            Handle(inputs);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private static void Handle(List<string> inputs)
    {
        /*
            ***********************************************
            * Your main logic implementation starts here! *
            ***********************************************

            'inputs' is a List<string> that contains:
            - Input1 at index 0
            - Input2 at index 1
            - Input3 at index 2
            - ... and so on

            You can parse these into specific types as needed.
        */

        for (int i = 0; i < inputs.Count; i++)
        {
            Console.WriteLine($"Input{i + 1}: {inputs[i]}");
        }

        // TODO: Add your core logic here
    }
}
