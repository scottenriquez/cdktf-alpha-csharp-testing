using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEcsCluster), fullyQualifiedName: "aws.DataAwsEcsCluster", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsEcsClusterConfig\"}}]")]
    public class DataAwsEcsCluster : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsEcsCluster(Constructs.Construct scope, string id, aws.IDataAwsEcsClusterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcsCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcsCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "setting", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsEcsClusterSetting\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsEcsClusterSetting Setting(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsEcsClusterSetting>(new System.Type[]{typeof(string)}, new object[]{index})!;
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

        [JsiiProperty(name: "clusterNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pendingTasksCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PendingTasksCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "registeredContainerInstancesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RegisteredContainerInstancesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "runningTasksCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RunningTasksCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
