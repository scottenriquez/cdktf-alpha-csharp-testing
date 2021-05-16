using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsGlueScriptDagEdge), fullyQualifiedName: "aws.DataAwsGlueScriptDagEdge")]
    public interface IDataAwsGlueScriptDagEdge
    {
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        string Target
        {
            get;
        }

        [JsiiProperty(name: "targetParameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetParameter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsGlueScriptDagEdge), fullyQualifiedName: "aws.DataAwsGlueScriptDagEdge")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsGlueScriptDagEdge
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
            public string Target
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "targetParameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetParameter
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
