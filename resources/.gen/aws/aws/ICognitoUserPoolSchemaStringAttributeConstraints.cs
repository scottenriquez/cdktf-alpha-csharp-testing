using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolSchemaStringAttributeConstraints), fullyQualifiedName: "aws.CognitoUserPoolSchemaStringAttributeConstraints")]
    public interface ICognitoUserPoolSchemaStringAttributeConstraints
    {
        [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxLength
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinLength
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolSchemaStringAttributeConstraints), fullyQualifiedName: "aws.CognitoUserPoolSchemaStringAttributeConstraints")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolSchemaStringAttributeConstraints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxLength
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinLength
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
