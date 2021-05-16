using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsElasticBeanstalkApplicationAppversionLifecycle), fullyQualifiedName: "aws.DataAwsElasticBeanstalkApplicationAppversionLifecycle", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsElasticBeanstalkApplicationAppversionLifecycle : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsElasticBeanstalkApplicationAppversionLifecycle(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticBeanstalkApplicationAppversionLifecycle(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticBeanstalkApplicationAppversionLifecycle(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "deleteSourceFromS3", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool DeleteSourceFromS3
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "maxAgeInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAgeInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRole
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
