using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsServicequotasServiceQuota), fullyQualifiedName: "aws.DataAwsServicequotasServiceQuota", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsServicequotasServiceQuotaConfig\"}}]")]
    public class DataAwsServicequotasServiceQuota : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsServicequotasServiceQuota(Constructs.Construct scope, string id, aws.IDataAwsServicequotasServiceQuotaConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsServicequotasServiceQuota(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsServicequotasServiceQuota(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetQuotaCode")]
        public virtual void ResetQuotaCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuotaName")]
        public virtual void ResetQuotaName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "adjustable", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Adjustable
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "globalQuota", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool GlobalQuota
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceCodeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceCodeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Value
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "quotaCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QuotaCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quotaNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QuotaNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "quotaCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QuotaCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "quotaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QuotaName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
