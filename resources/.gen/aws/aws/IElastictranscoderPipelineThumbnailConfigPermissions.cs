using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPipelineThumbnailConfigPermissions), fullyQualifiedName: "aws.ElastictranscoderPipelineThumbnailConfigPermissions")]
    public interface IElastictranscoderPipelineThumbnailConfigPermissions
    {
        [JsiiProperty(name: "access", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Access
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "grantee", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Grantee
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "granteeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GranteeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPipelineThumbnailConfigPermissions), fullyQualifiedName: "aws.ElastictranscoderPipelineThumbnailConfigPermissions")]
        internal sealed class _Proxy : DeputyBase, aws.IElastictranscoderPipelineThumbnailConfigPermissions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "access", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Access
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "grantee", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Grantee
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "granteeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GranteeType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
