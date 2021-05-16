using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SnsSmsPreferences), fullyQualifiedName: "aws.SnsSmsPreferences", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.SnsSmsPreferencesConfig\"}}]")]
    public class SnsSmsPreferences : HashiCorp.Cdktf.TerraformResource
    {
        public SnsSmsPreferences(Constructs.Construct scope, string id, aws.ISnsSmsPreferencesConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SnsSmsPreferences(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SnsSmsPreferences(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDefaultSenderId")]
        public virtual void ResetDefaultSenderId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultSmsType")]
        public virtual void ResetDefaultSmsType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeliveryStatusIamRoleArn")]
        public virtual void ResetDeliveryStatusIamRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeliveryStatusSuccessSamplingRate")]
        public virtual void ResetDeliveryStatusSuccessSamplingRate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonthlySpendLimit")]
        public virtual void ResetMonthlySpendLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsageReportS3Bucket")]
        public virtual void ResetUsageReportS3Bucket()
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

        [JsiiOptional]
        [JsiiProperty(name: "defaultSenderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultSenderIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultSmsTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultSmsTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryStatusIamRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeliveryStatusIamRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryStatusSuccessSamplingRateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeliveryStatusSuccessSamplingRateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monthlySpendLimitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonthlySpendLimitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageReportS3BucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageReportS3BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "defaultSenderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultSenderId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultSmsType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultSmsType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deliveryStatusIamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeliveryStatusIamRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deliveryStatusSuccessSamplingRate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeliveryStatusSuccessSamplingRate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monthlySpendLimit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonthlySpendLimit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usageReportS3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageReportS3Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
