using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDxGatewayTimeouts), fullyQualifiedName: "aws.DxGatewayTimeouts")]
    public interface IDxGatewayTimeouts
    {
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDxGatewayTimeouts), fullyQualifiedName: "aws.DxGatewayTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.IDxGatewayTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
