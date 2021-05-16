using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsIamPolicyDocumentStatementCondition), fullyQualifiedName: "aws.DataAwsIamPolicyDocumentStatementCondition")]
    public interface IDataAwsIamPolicyDocumentStatementCondition
    {
        [JsiiProperty(name: "test", typeJson: "{\"primitive\":\"string\"}")]
        string Test
        {
            get;
        }

        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiProperty(name: "variable", typeJson: "{\"primitive\":\"string\"}")]
        string Variable
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIamPolicyDocumentStatementCondition), fullyQualifiedName: "aws.DataAwsIamPolicyDocumentStatementCondition")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsIamPolicyDocumentStatementCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "test", typeJson: "{\"primitive\":\"string\"}")]
            public string Test
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "variable", typeJson: "{\"primitive\":\"string\"}")]
            public string Variable
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
