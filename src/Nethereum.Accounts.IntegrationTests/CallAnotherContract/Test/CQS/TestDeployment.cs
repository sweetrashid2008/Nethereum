using System;
using System.Threading.Tasks;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.Contracts.CQS;
using Nethereum.ABI.FunctionEncoding.Attributes;
namespace SolidityCallAnotherContract.Contracts.Test.CQS
{
    public class TestDeployment:ContractDeploymentMessage
    {
        
        public static string BYTECODE = "608060405234801561001057600080fd5b5061098f806100206000396000f30060806040526004361061006c5763ffffffff7c010000000000000000000000000000000000000000000000000000000060003504166303825ffc81146100715780635d5d6297146100a75780635efb4c2c146100c75780639bd5d1fe146100e7578063bb7c7cd014610114575b600080fd5b34801561007d57600080fd5b5061009161008c366004610665565b610141565b60405161009e919061082c565b60405180910390f35b3480156100b357600080fd5b506100916100c236600461063f565b6101ea565b3480156100d357600080fd5b506100916100e23660046106ce565b610284565b3480156100f357600080fd5b5061010761010236600461063f565b61030f565b60405161009e919061081b565b34801561012057600080fd5b5061013461012f36600461063f565b610343565b60405161009e919061083d565b60606000835160405190808252806020026020018201604052801561017a57816020015b60608152602001906001900390816101655790505b509150600090505b83518110156101e3576101c3848281518110151561019c57fe5b9060200190602002015184838151811015156101b457fe5b906020019060200201516104ac565b82828151811015156101d157fe5b60209081029091010152600101610182565b5092915050565b60408051600380825260808201909252606091816020015b606081526020019060019003908161020257905050905061022282610343565b81600081518110151561023157fe5b6020908102909101015261024482610343565b81600181518110151561025357fe5b6020908102909101015261026682610343565b81600281518110151561027557fe5b60209081029091010152919050565b6060600083516040519080825280602002602001820160405280156102bd57816020015b60608152602001906001900390816102a85790505b509150600090505b83518110156101e3576102ef84828151811015156102df57fe5b90602001906020020151846104ac565b82828151811015156102fd57fe5b602090810290910101526001016102c5565b6103176104d8565b61032082610343565b815261032b82610343565b602082015261033982610343565b6040820152919050565b6060806060806040805190810160405280600881526020017f536f6c6964697479000000000000000000000000000000000000000000000000815250925060a060405190810160405280607781526020017f57656c636f6d6520736f6d657468696e67206d756368206d756368206269676781526020017f676572206a6c6b6a66736c6b666a736c6b64666a736c64666a617364666c6b6a81526020017f736166646c6b6a617364666c6a736164666c6a617364666b6c6a6173646b666c81526020017f6a736164666c6a617364666c647366616a20626f6f68210000000000000000008152509150828260405160240161043f92919061084e565b60408051601f198184030181529190526020810180517bffffffffffffffffffffffffffffffffffffffffffffffffffffffff167f43ea0aa50000000000000000000000000000000000000000000000000000000017905290506104a385826104ac565b95945050505050565b8051606090600080826020860182885af13d6040519350806000853e8084528301604052505092915050565b61014060405190810160405280600a905b60608152602001906001900390816104e95790505090565b600061050d82356108f6565b9392505050565b6000601f8201831361052557600080fd5b81356105386105338261089a565b610873565b9150818183526020840193506020810190508385602084028201111561055d57600080fd5b60005b8381101561058957816105738882610501565b8452506020928301929190910190600101610560565b5050505092915050565b6000601f820183136105a457600080fd5b81356105b26105338261089a565b81815260209384019390925082018360005b8381101561058957813586016105da88826105f0565b84525060209283019291909101906001016105c4565b6000601f8201831361060157600080fd5b813561060f610533826108bb565b9150808252602083016020830185838301111561062b57600080fd5b61063683828461090f565b50505092915050565b60006020828403121561065157600080fd5b600061065d8484610501565b949350505050565b6000806040838503121561067857600080fd5b823567ffffffffffffffff81111561068f57600080fd5b61069b85828601610514565b925050602083013567ffffffffffffffff8111156106b857600080fd5b6106c485828601610593565b9150509250929050565b600080604083850312156106e157600080fd5b823567ffffffffffffffff8111156106f857600080fd5b61070485828601610514565b925050602083013567ffffffffffffffff81111561072157600080fd5b6106c4858286016105f0565b6000610738826108ec565b83602082028501610748856108e3565b60005b8481101561077f5783830388526107638383516107e6565b925061076e826108e6565b60209890980197915060010161074b565b50909695505050505050565b6000610796826108f2565b808452602084019350836020820285016107af856108e6565b60005b8481101561077f5783830388526107ca8383516107e6565b92506107d5826108e6565b6020989098019791506001016107b2565b60006107f1826108f2565b80845261080581602086016020860161091b565b61080e8161094b565b9093016020019392505050565b6020808252810161050d818461072d565b6020808252810161050d818461078b565b6020808252810161050d81846107e6565b6040808252810161085f81856107e6565b9050818103602083015261065d81846107e6565b60405181810167ffffffffffffffff8111828210171561089257600080fd5b604052919050565b600067ffffffffffffffff8211156108b157600080fd5b5060209081020190565b600067ffffffffffffffff8211156108d257600080fd5b506020601f91909101601f19160190565b90565b60200190565b50600a90565b5190565b73ffffffffffffffffffffffffffffffffffffffff1690565b82818337506000910152565b60005b8381101561093657818101518382015260200161091e565b83811115610945576000848401525b50505050565b601f01601f1916905600a265627a7a72305820165d08a026427fce7656259f826f6793e5744d1a0d0f5ba953bc12fe051f371d6c6578706572696d656e74616cf50037";
        
        public TestDeployment():base(BYTECODE) { }
        
        public TestDeployment(string byteCode):base(byteCode) { }
        

    }
}
