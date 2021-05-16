using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodebuildWebhookFilterGroup), fullyQualifiedName: "aws.CodebuildWebhookFilterGroup")]
    public interface ICodebuildWebhookFilterGroup
    {
        /// <summary>filter block.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildWebhookFilterGroupFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodebuildWebhookFilterGroupFilter[]? Filter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildWebhookFilterGroup), fullyQualifiedName: "aws.CodebuildWebhookFilterGroup")]
        internal sealed class _Proxy : DeputyBase, aws.ICodebuildWebhookFilterGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>filter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildWebhookFilterGroupFilter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodebuildWebhookFilterGroupFilter[]? Filter
            {
                get => GetInstanceProperty<aws.ICodebuildWebhookFilterGroupFilter[]?>();
            }
        }
    }
}
