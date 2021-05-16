using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.OpsworksRdsDbInstance), fullyQualifiedName: "aws.OpsworksRdsDbInstance", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.OpsworksRdsDbInstanceConfig\"}}]")]
    public class OpsworksRdsDbInstance : HashiCorp.Cdktf.TerraformResource
    {
        public OpsworksRdsDbInstance(Constructs.Construct scope, string id, aws.IOpsworksRdsDbInstanceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksRdsDbInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksRdsDbInstance(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "dbPasswordInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbPasswordInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbUserInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbUserInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rdsDbInstanceArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RdsDbInstanceArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stackIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbUser
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rdsDbInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RdsDbInstanceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
