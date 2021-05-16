using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordGeolocationRoutingPolicy), fullyQualifiedName: "aws.Route53RecordGeolocationRoutingPolicy")]
    public interface IRoute53RecordGeolocationRoutingPolicy
    {
        [JsiiProperty(name: "continent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Continent
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Country
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "subdivision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Subdivision
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordGeolocationRoutingPolicy), fullyQualifiedName: "aws.Route53RecordGeolocationRoutingPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.IRoute53RecordGeolocationRoutingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "continent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Continent
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Country
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "subdivision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Subdivision
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
