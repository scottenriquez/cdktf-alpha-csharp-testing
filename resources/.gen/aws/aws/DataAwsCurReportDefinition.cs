using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsCurReportDefinition), fullyQualifiedName: "aws.DataAwsCurReportDefinition", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsCurReportDefinitionConfig\"}}]")]
    public class DataAwsCurReportDefinition : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsCurReportDefinition(Constructs.Construct scope, string id, aws.IDataAwsCurReportDefinitionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCurReportDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCurReportDefinition(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "additionalArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdditionalArtifacts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "additionalSchemaElements", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdditionalSchemaElements
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Compression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Format
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reportNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Bucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Prefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUnit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reportName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
