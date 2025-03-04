# neo-n3-smart-contract-tutorial
A step-by-step guide to deploying and interacting with a smart contract on Neo N3.
# How to Deploy and Interact with a Smart Contract on Neo N3

This tutorial will guide you through the process of writing, deploying, and interacting with a simple smart contract on the Neo N3 blockchain. By the end of this tutorial, you will have a working smart contract and a basic understanding of Neo's development tools.

---

## Prerequisites 

Before starting, ensure you have the following:
1. **Neo N3 Testnet Account**: Create one using [NeoLine Wallet](https://neoline.io/).
2. **Neo N3 Testnet GAS**: Get testnet GAS from the [Neo N3 Testnet Faucet](https://neowish.ngd.network/).
3. **Neo Blockchain Toolkit**: Use the [Neo N3 Documentation](https://docs.neo.org/docs/en-us/index.html) to set up your development environment.

---

## Step 1: Write a Smart Contract

We'll create a simple smart contract that stores and retrieves a string value.

1. Use the following C# code to create your smart contract:
   ```csharp
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
