using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IOpsworksApplicationEnvironment), fullyQualifiedName: "aws.OpsworksApplicationEnvironment")]
    public interface IOpsworksApplicationEnvironment
    {
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiProperty(name: "secure", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Secure
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksApplicationEnvironment), fullyQualifiedName: "aws.OpsworksApplicationEnvironment")]
        internal sealed class _Proxy : DeputyBase, aws.IOpsworksApplicationEnvironment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "secure", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Secure
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
