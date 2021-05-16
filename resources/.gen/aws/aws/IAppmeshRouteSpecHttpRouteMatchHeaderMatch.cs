using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteMatchHeaderMatch), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRouteMatchHeaderMatch")]
    public interface IAppmeshRouteSpecHttpRouteMatchHeaderMatch
    {
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Exact
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>range block.</summary>
        [JsiiProperty(name: "range", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange[]? Range
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Suffix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteMatchHeaderMatch), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRouteMatchHeaderMatch")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshRouteSpecHttpRouteMatchHeaderMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Exact
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>range block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "range", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange[]? Range
            {
                get => GetInstanceProperty<aws.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Regex
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Suffix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
