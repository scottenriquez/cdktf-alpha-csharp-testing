using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.VolumeAttachment), fullyQualifiedName: "aws.VolumeAttachment", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.VolumeAttachmentConfig\"}}]")]
    public class VolumeAttachment : HashiCorp.Cdktf.TerraformResource
    {
        public VolumeAttachment(Constructs.Construct scope, string id, aws.IVolumeAttachmentConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VolumeAttachment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VolumeAttachment(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetForceDetach")]
        public virtual void ResetForceDetach()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkipDestroy")]
        public virtual void ResetSkipDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "deviceNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "volumeIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDetachInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? ForceDetachInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipDestroyInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SkipDestroyInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceDetach", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ForceDetach
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "skipDestroy", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool SkipDestroy
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
