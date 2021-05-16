using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolSchemaNumberAttributeConstraints), fullyQualifiedName: "aws.CognitoUserPoolSchemaNumberAttributeConstraints")]
    public interface ICognitoUserPoolSchemaNumberAttributeConstraints
    {
        [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxValue
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolSchemaNumberAttributeConstraints), fullyQualifiedName: "aws.CognitoUserPoolSchemaNumberAttributeConstraints")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolSchemaNumberAttributeConstraints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxValue
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
