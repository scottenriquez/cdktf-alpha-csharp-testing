using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsIamPolicyDocumentStatementPrincipals), fullyQualifiedName: "aws.DataAwsIamPolicyDocumentStatementPrincipals")]
    public interface IDataAwsIamPolicyDocumentStatementPrincipals
    {
        [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Identifiers
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIamPolicyDocumentStatementPrincipals), fullyQualifiedName: "aws.DataAwsIamPolicyDocumentStatementPrincipals")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsIamPolicyDocumentStatementPrincipals
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Identifiers
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
