using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CognitoUserPoolSchemaNumberAttributeConstraints")]
    public class CognitoUserPoolSchemaNumberAttributeConstraints : aws.ICognitoUserPoolSchemaNumberAttributeConstraints
    {
        [JsiiOptional]
        [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MaxValue
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MinValue
        {
            get;
            set;
        }
    }
}
