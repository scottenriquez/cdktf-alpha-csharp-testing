using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteMatchHeader), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRouteMatchHeader")]
    public interface IAppmeshRouteSpecHttpRouteMatchHeader
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "invert", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Invert
        {
            get
            {
                return null;
            }
        }

        /// <summary>match block.</summary>
        [JsiiProperty(name: "match", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteMatchHeaderMatch\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshRouteSpecHttpRouteMatchHeaderMatch[]? Match
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteMatchHeader), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRouteMatchHeader")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshRouteSpecHttpRouteMatchHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "invert", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Invert
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>match block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "match", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteMatchHeaderMatch\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshRouteSpecHttpRouteMatchHeaderMatch[]? Match
            {
                get => GetInstanceProperty<aws.IAppmeshRouteSpecHttpRouteMatchHeaderMatch[]?>();
            }
        }
    }
}
