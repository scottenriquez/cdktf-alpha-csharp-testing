using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.OrganizationsOrganization), fullyQualifiedName: "aws.OrganizationsOrganization", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.OrganizationsOrganizationConfig\"}}]")]
    public class OrganizationsOrganization : HashiCorp.Cdktf.TerraformResource
    {
        public OrganizationsOrganization(Constructs.Construct scope, string id, aws.IOrganizationsOrganizationConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OrganizationsOrganization(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OrganizationsOrganization(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "accounts", returnsJson: "{\"type\":{\"fqn\":\"aws.OrganizationsOrganizationAccounts\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.OrganizationsOrganizationAccounts Accounts(string index)
        {
            return InvokeInstanceMethod<aws.OrganizationsOrganizationAccounts>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "nonMasterAccounts", returnsJson: "{\"type\":{\"fqn\":\"aws.OrganizationsOrganizationNonMasterAccounts\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.OrganizationsOrganizationNonMasterAccounts NonMasterAccounts(string index)
        {
            return InvokeInstanceMethod<aws.OrganizationsOrganizationNonMasterAccounts>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetAwsServiceAccessPrincipals")]
        public virtual void ResetAwsServiceAccessPrincipals()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabledPolicyTypes")]
        public virtual void ResetEnabledPolicyTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeatureSet")]
        public virtual void ResetFeatureSet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "roots", returnsJson: "{\"type\":{\"fqn\":\"aws.OrganizationsOrganizationRoots\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.OrganizationsOrganizationRoots Roots(string index)
        {
            return InvokeInstanceMethod<aws.OrganizationsOrganizationRoots>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterAccountArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterAccountArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterAccountEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterAccountEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsServiceAccessPrincipalsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AwsServiceAccessPrincipalsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledPolicyTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EnabledPolicyTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featureSetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FeatureSetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "awsServiceAccessPrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AwsServiceAccessPrincipals
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabledPolicyTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledPolicyTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "featureSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeatureSet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
