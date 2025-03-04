using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

public class HelloNeo : SmartContract
{
    public static void StoreMessage(string key, string message)
    {
        Storage.Put(Storage.CurrentContext, key, message);
    }

    public static string GetMessage(string key)
    {
        return Storage.Get(Storage.CurrentContext, key).ToString();
    }
}
