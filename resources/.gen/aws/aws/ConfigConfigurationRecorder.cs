using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.ConfigConfigurationRecorder), fullyQualifiedName: "aws.ConfigConfigurationRecorder", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ConfigConfigurationRecorderConfig\"}}]")]
    public class ConfigConfigurationRecorder : HashiCorp.Cdktf.TerraformResource
    {
        public ConfigConfigurationRecorder(Constructs.Construct scope, string id, aws.IConfigConfigurationRecorderConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationRecorder(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationRecorder(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecordingGroup")]
        public virtual void ResetRecordingGroup()
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

        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordingGroupInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ConfigConfigurationRecorderRecordingGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IConfigConfigurationRecorderRecordingGroup[]? RecordingGroupInput
        {
            get => GetInstanceProperty<aws.IConfigConfigurationRecorderRecordingGroup[]?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recordingGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ConfigConfigurationRecorderRecordingGroup\"},\"kind\":\"array\"}}")]
        public virtual aws.IConfigConfigurationRecorderRecordingGroup[] RecordingGroup
        {
            get => GetInstanceProperty<aws.IConfigConfigurationRecorderRecordingGroup[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
