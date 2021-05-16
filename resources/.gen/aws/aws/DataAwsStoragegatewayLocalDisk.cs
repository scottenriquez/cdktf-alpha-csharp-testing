using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsStoragegatewayLocalDisk), fullyQualifiedName: "aws.DataAwsStoragegatewayLocalDisk", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsStoragegatewayLocalDiskConfig\"}}]")]
    public class DataAwsStoragegatewayLocalDisk : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsStoragegatewayLocalDisk(Constructs.Construct scope, string id, aws.IDataAwsStoragegatewayLocalDiskConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsStoragegatewayLocalDisk(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsStoragegatewayLocalDisk(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDiskNode")]
        public virtual void ResetDiskNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiskPath")]
        public virtual void ResetDiskPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "diskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiskId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskNodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DiskNodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DiskPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "diskNode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiskNode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "diskPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiskPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
