using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppsyncResolverPipelineConfig), fullyQualifiedName: "aws.AppsyncResolverPipelineConfig")]
    public interface IAppsyncResolverPipelineConfig
    {
        [JsiiProperty(name: "functions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Functions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncResolverPipelineConfig), fullyQualifiedName: "aws.AppsyncResolverPipelineConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAppsyncResolverPipelineConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "functions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Functions
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
