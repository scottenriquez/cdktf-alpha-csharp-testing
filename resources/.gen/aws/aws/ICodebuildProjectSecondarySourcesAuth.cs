using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectSecondarySourcesAuth), fullyQualifiedName: "aws.CodebuildProjectSecondarySourcesAuth")]
    public interface ICodebuildProjectSecondarySourcesAuth
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Resource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectSecondarySourcesAuth), fullyQualifiedName: "aws.CodebuildProjectSecondarySourcesAuth")]
        internal sealed class _Proxy : DeputyBase, aws.ICodebuildProjectSecondarySourcesAuth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Resource
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
