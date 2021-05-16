using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationNfsOnPremConfig), fullyQualifiedName: "aws.DatasyncLocationNfsOnPremConfig")]
    public interface IDatasyncLocationNfsOnPremConfig
    {
        [JsiiProperty(name: "agentArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AgentArns
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationNfsOnPremConfig), fullyQualifiedName: "aws.DatasyncLocationNfsOnPremConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IDatasyncLocationNfsOnPremConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "agentArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AgentArns
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
