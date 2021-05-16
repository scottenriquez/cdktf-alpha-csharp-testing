using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsElasticsearchDomainClusterConfig), fullyQualifiedName: "aws.DataAwsElasticsearchDomainClusterConfig", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsElasticsearchDomainClusterConfig : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsElasticsearchDomainClusterConfig(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticsearchDomainClusterConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticsearchDomainClusterConfig(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dedicatedMasterCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DedicatedMasterCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dedicatedMasterEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool DedicatedMasterEnabled
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "dedicatedMasterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedicatedMasterType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "warmCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WarmCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "warmEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool WarmEnabled
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "warmType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarmType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zoneAwarenessConfig", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ZoneAwarenessConfig
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "zoneAwarenessEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ZoneAwarenessEnabled
        {
            get => GetInstanceProperty<bool>()!;
        }
    }
}
