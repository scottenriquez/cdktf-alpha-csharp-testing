using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CognitoUserPoolSchemaStringAttributeConstraints")]
    public class CognitoUserPoolSchemaStringAttributeConstraints : aws.ICognitoUserPoolSchemaStringAttributeConstraints
    {
        [JsiiOptional]
        [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MaxLength
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MinLength
        {
            get;
            set;
        }
    }
}
