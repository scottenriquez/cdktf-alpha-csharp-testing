using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SsmResourceDataSync), fullyQualifiedName: "aws.SsmResourceDataSync", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SsmResourceDataSyncConfig\"}}]")]
    public class SsmResourceDataSync : HashiCorp.Cdktf.TerraformResource
    {
        public SsmResourceDataSync(Constructs.Construct scope, string id, aws.ISsmResourceDataSyncConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmResourceDataSync(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmResourceDataSync(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3DestinationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmResourceDataSyncS3Destination\"},\"kind\":\"array\"}}")]
        public virtual aws.ISsmResourceDataSyncS3Destination[] S3DestinationInput
        {
            get => GetInstanceProperty<aws.ISsmResourceDataSyncS3Destination[]>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmResourceDataSyncS3Destination\"},\"kind\":\"array\"}}")]
        public virtual aws.ISsmResourceDataSyncS3Destination[] S3Destination
        {
            get => GetInstanceProperty<aws.ISsmResourceDataSyncS3Destination[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
