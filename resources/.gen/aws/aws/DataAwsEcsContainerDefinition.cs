using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEcsContainerDefinition), fullyQualifiedName: "aws.DataAwsEcsContainerDefinition", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsEcsContainerDefinitionConfig\"}}]")]
    public class DataAwsEcsContainerDefinition : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsEcsContainerDefinition(Constructs.Construct scope, string id, aws.IDataAwsEcsContainerDefinitionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcsContainerDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcsContainerDefinition(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "dockerLabels", returnsJson: "{\"type\":{\"primitive\":\"string\"}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual string DockerLabels(string key)
        {
            return InvokeInstanceMethod<string>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiMethod(name: "environment", returnsJson: "{\"type\":{\"primitive\":\"string\"}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual string Environment(string key)
        {
            return InvokeInstanceMethod<string>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "containerNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Cpu
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "disableNetworking", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool DisableNetworking
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageDigest
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Memory
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryReservation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryReservation
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "taskDefinitionInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskDefinitionInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskDefinition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
