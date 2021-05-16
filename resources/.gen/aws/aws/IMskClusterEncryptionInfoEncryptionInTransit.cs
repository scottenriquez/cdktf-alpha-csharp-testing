using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterEncryptionInfoEncryptionInTransit), fullyQualifiedName: "aws.MskClusterEncryptionInfoEncryptionInTransit")]
    public interface IMskClusterEncryptionInfoEncryptionInTransit
    {
        [JsiiProperty(name: "clientBroker", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientBroker
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "inCluster", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? InCluster
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterEncryptionInfoEncryptionInTransit), fullyQualifiedName: "aws.MskClusterEncryptionInfoEncryptionInTransit")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterEncryptionInfoEncryptionInTransit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "clientBroker", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientBroker
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "inCluster", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? InCluster
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
