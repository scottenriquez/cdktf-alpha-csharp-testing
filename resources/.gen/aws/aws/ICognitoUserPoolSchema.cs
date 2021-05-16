using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolSchema), fullyQualifiedName: "aws.CognitoUserPoolSchema")]
    public interface ICognitoUserPoolSchema
    {
        [JsiiProperty(name: "attributeDataType", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeDataType
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "developerOnlyAttribute", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DeveloperOnlyAttribute
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "mutable", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Mutable
        {
            get
            {
                return null;
            }
        }

        /// <summary>number_attribute_constraints block.</summary>
        [JsiiProperty(name: "numberAttributeConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSchemaNumberAttributeConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolSchemaNumberAttributeConstraints[]? NumberAttributeConstraints
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "required", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Required
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_attribute_constraints block.</summary>
        [JsiiProperty(name: "stringAttributeConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSchemaStringAttributeConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolSchemaStringAttributeConstraints[]? StringAttributeConstraints
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolSchema), fullyQualifiedName: "aws.CognitoUserPoolSchema")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "attributeDataType", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeDataType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "developerOnlyAttribute", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DeveloperOnlyAttribute
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "mutable", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Mutable
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>number_attribute_constraints block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numberAttributeConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSchemaNumberAttributeConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolSchemaNumberAttributeConstraints[]? NumberAttributeConstraints
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolSchemaNumberAttributeConstraints[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "required", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Required
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>string_attribute_constraints block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stringAttributeConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSchemaStringAttributeConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolSchemaStringAttributeConstraints[]? StringAttributeConstraints
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolSchemaStringAttributeConstraints[]?>();
            }
        }
    }
}
