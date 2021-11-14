using Cocona;
using OpenRelease;
using OpenRelease.Type;

class Program
{
    static void Main(string[] args)
    {
        
        CoconaApp.Run<Program>(args, options =>
        {
            options.EnableConvertArgumentNameToLowerCase = true;
            options.EnableShellCompletionSupport = true;
        });
    }
    public void Push(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    public void Pull(ProjectType configuration) 
    {
        if (configuration is null)
        {
            throw new ArgumentNullException(nameof(configuration));
        }
    }

    // [Ignore]
    // [Command("commandname")]
    //  options.TreatPublicMethodsAsCommands = false;
}
