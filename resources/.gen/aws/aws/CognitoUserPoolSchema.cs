using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CognitoUserPoolSchema")]
    public class CognitoUserPoolSchema : aws.ICognitoUserPoolSchema
    {
        [JsiiProperty(name: "attributeDataType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AttributeDataType
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "developerOnlyAttribute", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DeveloperOnlyAttribute
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mutable", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Mutable
        {
            get;
            set;
        }

        /// <summary>number_attribute_constraints block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberAttributeConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSchemaNumberAttributeConstraints\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolSchemaNumberAttributeConstraints[]? NumberAttributeConstraints
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "required", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Required
        {
            get;
            set;
        }

        /// <summary>string_attribute_constraints block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stringAttributeConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSchemaStringAttributeConstraints\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolSchemaStringAttributeConstraints[]? StringAttributeConstraints
        {
            get;
            set;
        }
    }
}
