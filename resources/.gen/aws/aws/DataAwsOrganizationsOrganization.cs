using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsOrganizationsOrganization), fullyQualifiedName: "aws.DataAwsOrganizationsOrganization", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.DataAwsOrganizationsOrganizationConfig\"}}]")]
    public class DataAwsOrganizationsOrganization : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsOrganizationsOrganization(Constructs.Construct scope, string id, aws.IDataAwsOrganizationsOrganizationConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOrganizationsOrganization(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOrganizationsOrganization(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "accounts", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsOrganizationsOrganizationAccounts\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsOrganizationsOrganizationAccounts Accounts(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsOrganizationsOrganizationAccounts>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "nonMasterAccounts", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsOrganizationsOrganizationNonMasterAccounts\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsOrganizationsOrganizationNonMasterAccounts NonMasterAccounts(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsOrganizationsOrganizationNonMasterAccounts>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "roots", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsOrganizationsOrganizationRoots\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsOrganizationsOrganizationRoots Roots(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsOrganizationsOrganizationRoots>(new System.Type[]{typeof(string)}, new object[]{index})!;
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

        [JsiiProperty(name: "awsServiceAccessPrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AwsServiceAccessPrincipals
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "enabledPolicyTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledPolicyTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "featureSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeatureSet
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
    }
}
