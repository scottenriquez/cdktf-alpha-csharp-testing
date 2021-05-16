using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationEfsEc2Config), fullyQualifiedName: "aws.DatasyncLocationEfsEc2Config")]
    public interface IDatasyncLocationEfsEc2Config
    {
        [JsiiProperty(name: "securityGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroupArns
        {
            get;
        }

        [JsiiProperty(name: "subnetArn", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationEfsEc2Config), fullyQualifiedName: "aws.DatasyncLocationEfsEc2Config")]
        internal sealed class _Proxy : DeputyBase, aws.IDatasyncLocationEfsEc2Config
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "securityGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroupArns
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "subnetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
