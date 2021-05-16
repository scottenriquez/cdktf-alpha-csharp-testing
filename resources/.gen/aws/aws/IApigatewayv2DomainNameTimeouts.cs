using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2DomainNameTimeouts), fullyQualifiedName: "aws.Apigatewayv2DomainNameTimeouts")]
    public interface IApigatewayv2DomainNameTimeouts
    {
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2DomainNameTimeouts), fullyQualifiedName: "aws.Apigatewayv2DomainNameTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.IApigatewayv2DomainNameTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
