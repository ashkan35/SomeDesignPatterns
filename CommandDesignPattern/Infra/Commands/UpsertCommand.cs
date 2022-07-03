using CommandDesignPattern.Data;

namespace CommandDesignPattern.Infra.Commands;

public class UpsertCommand:Command
{
    private readonly string _key;
    private readonly string _value;

    public UpsertCommand(string key,string value,DataReceiver receiver) : base(receiver)
    {
        this._key = key;
        this._value = value;
    }

    public override void Execute()
    {
        Receiver.Upsert(_key,_value);
    }
}