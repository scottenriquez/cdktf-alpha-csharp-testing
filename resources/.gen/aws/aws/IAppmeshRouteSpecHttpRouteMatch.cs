using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteMatch), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRouteMatch")]
    public interface IAppmeshRouteSpecHttpRouteMatch
    {
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        /// <summary>header block.</summary>
        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteMatchHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshRouteSpecHttpRouteMatchHeader[]? Header
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Method
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scheme
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteMatch), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRouteMatch")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshRouteSpecHttpRouteMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>header block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteMatchHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshRouteSpecHttpRouteMatchHeader[]? Header
            {
                get => GetInstanceProperty<aws.IAppmeshRouteSpecHttpRouteMatchHeader[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Method
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scheme
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
