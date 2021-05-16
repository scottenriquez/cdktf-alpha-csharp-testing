using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsIamPolicyDocument), fullyQualifiedName: "aws.DataAwsIamPolicyDocument", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentConfig\"}}]")]
    public class DataAwsIamPolicyDocument : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsIamPolicyDocument(Constructs.Construct scope, string id, aws.IDataAwsIamPolicyDocumentConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsIamPolicyDocument(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsIamPolicyDocument(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetOverrideJson")]
        public virtual void ResetOverrideJson()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicyId")]
        public virtual void ResetPolicyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceJson")]
        public virtual void ResetSourceJson()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatement")]
        public virtual void ResetStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "json", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Json
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideJsonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OverrideJsonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceJsonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceJsonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statementInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDataAwsIamPolicyDocumentStatement[]? StatementInput
        {
            get => GetInstanceProperty<aws.IDataAwsIamPolicyDocumentStatement[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "overrideJson", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OverrideJson
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceJson", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceJson
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentStatement\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsIamPolicyDocumentStatement[] Statement
        {
            get => GetInstanceProperty<aws.IDataAwsIamPolicyDocumentStatement[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
