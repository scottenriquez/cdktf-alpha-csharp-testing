using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsIamPolicyDocumentStatement), fullyQualifiedName: "aws.DataAwsIamPolicyDocumentStatement")]
    public interface IDataAwsIamPolicyDocumentStatement
    {
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Actions
        {
            get
            {
                return null;
            }
        }

        /// <summary>condition block.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentStatementCondition\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDataAwsIamPolicyDocumentStatementCondition[]? Condition
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Effect
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "notActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotActions
        {
            get
            {
                return null;
            }
        }

        /// <summary>not_principals block.</summary>
        [JsiiProperty(name: "notPrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentStatementNotPrincipals\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDataAwsIamPolicyDocumentStatementNotPrincipals[]? NotPrincipals
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "notResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotResources
        {
            get
            {
                return null;
            }
        }

        /// <summary>principals block.</summary>
        [JsiiProperty(name: "principals", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentStatementPrincipals\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDataAwsIamPolicyDocumentStatementPrincipals[]? Principals
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Resources
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIamPolicyDocumentStatement), fullyQualifiedName: "aws.DataAwsIamPolicyDocumentStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsIamPolicyDocumentStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Actions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>condition block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentStatementCondition\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDataAwsIamPolicyDocumentStatementCondition[]? Condition
            {
                get => GetInstanceProperty<aws.IDataAwsIamPolicyDocumentStatementCondition[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Effect
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "notActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotActions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>not_principals block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notPrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentStatementNotPrincipals\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDataAwsIamPolicyDocumentStatementNotPrincipals[]? NotPrincipals
            {
                get => GetInstanceProperty<aws.IDataAwsIamPolicyDocumentStatementNotPrincipals[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "notResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotResources
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>principals block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "principals", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentStatementPrincipals\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDataAwsIamPolicyDocumentStatementPrincipals[]? Principals
            {
                get => GetInstanceProperty<aws.IDataAwsIamPolicyDocumentStatementPrincipals[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Resources
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
