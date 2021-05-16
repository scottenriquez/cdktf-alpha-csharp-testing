using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMqBrokerLogs), fullyQualifiedName: "aws.MqBrokerLogs")]
    public interface IMqBrokerLogs
    {
        [JsiiProperty(name: "audit", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Audit
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "general", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? General
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMqBrokerLogs), fullyQualifiedName: "aws.MqBrokerLogs")]
        internal sealed class _Proxy : DeputyBase, aws.IMqBrokerLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "audit", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Audit
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "general", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? General
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
