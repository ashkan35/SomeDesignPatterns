using CommandDesignPattern.Data;
using CommandDesignPattern.InterFace;

namespace CommandDesignPattern.Infra;

public abstract class Command:ICommand
{
    protected DataReceiver Receiver;

    protected Command(DataReceiver receiver)
    {
        Receiver = receiver;
    }

    public abstract void Execute();
}