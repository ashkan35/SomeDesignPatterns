using CommandDesignPattern.InterFace;

namespace CommandDesignPattern.Infra.Invoker;

public class DataCommandInvoker
{
    private  ICommand? _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
        Console.WriteLine($"command:{command.GetType()}");
        
    }

    public void ExecuteCommand()
    {
      
        _command?.Execute();
    }
}