using CommandDesignPattern.Data;

namespace CommandDesignPattern.Infra.Commands;

public class DeleteCommand:Command
{
    private readonly string _key;

    public DeleteCommand(string key,DataReceiver receiver) : base(receiver)
    {
        _key = key;
    }

    public override void Execute()
    {
        Receiver.Delete(_key);
    }
}