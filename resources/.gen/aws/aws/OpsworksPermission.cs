using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.OpsworksPermission), fullyQualifiedName: "aws.OpsworksPermission", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.OpsworksPermissionConfig\"}}]")]
    public class OpsworksPermission : HashiCorp.Cdktf.TerraformResource
    {
        public OpsworksPermission(Constructs.Construct scope, string id, aws.IOpsworksPermissionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksPermission(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksPermission(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAllowSsh")]
        public virtual void ResetAllowSsh()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowSudo")]
        public virtual void ResetAllowSudo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLevel")]
        public virtual void ResetLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStackId")]
        public virtual void ResetStackId()
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

        [JsiiProperty(name: "userArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowSshInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? AllowSshInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowSudoInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? AllowSudoInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "levelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stackIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StackIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allowSsh", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AllowSsh
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowSudo", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AllowSudo
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Level
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

        [JsiiProperty(name: "userArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
