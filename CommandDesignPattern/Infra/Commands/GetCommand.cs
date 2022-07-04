using CommandDesignPattern.Data;

namespace CommandDesignPattern.Infra.Commands;

public class GetCommand:Command
{
    public GetCommand(DataReceiver receiver) : base(receiver)
    {
    }

    public override void Execute()
    {
        Receiver.GetData();
    }
}