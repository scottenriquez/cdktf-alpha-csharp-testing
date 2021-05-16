using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchLogMetricFilter), fullyQualifiedName: "aws.CloudwatchLogMetricFilter", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.CloudwatchLogMetricFilterConfig\"}}]")]
    public class CloudwatchLogMetricFilter : HashiCorp.Cdktf.TerraformResource
    {
        public CloudwatchLogMetricFilter(Constructs.Construct scope, string id, aws.ICloudwatchLogMetricFilterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchLogMetricFilter(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchLogMetricFilter(DeputyProps props): base(props)
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

        [JsiiProperty(name: "logGroupNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogGroupNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metricTransformationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchLogMetricFilterMetricTransformation\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudwatchLogMetricFilterMetricTransformation[] MetricTransformationInput
        {
            get => GetInstanceProperty<aws.ICloudwatchLogMetricFilterMetricTransformation[]>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patternInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatternInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchLogMetricFilterMetricTransformation\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudwatchLogMetricFilterMetricTransformation[] MetricTransformation
        {
            get => GetInstanceProperty<aws.ICloudwatchLogMetricFilterMetricTransformation[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Pattern
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
