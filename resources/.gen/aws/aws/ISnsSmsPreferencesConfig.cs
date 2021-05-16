using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISnsSmsPreferencesConfig), fullyQualifiedName: "aws.SnsSmsPreferencesConfig")]
    public interface ISnsSmsPreferencesConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "defaultSenderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultSenderId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "defaultSmsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultSmsType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "deliveryStatusIamRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeliveryStatusIamRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "deliveryStatusSuccessSamplingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeliveryStatusSuccessSamplingRate
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "monthlySpendLimit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MonthlySpendLimit
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "usageReportS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsageReportS3Bucket
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISnsSmsPreferencesConfig), fullyQualifiedName: "aws.SnsSmsPreferencesConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ISnsSmsPreferencesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultSenderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultSenderId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultSmsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultSmsType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "deliveryStatusIamRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeliveryStatusIamRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "deliveryStatusSuccessSamplingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeliveryStatusSuccessSamplingRate
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "monthlySpendLimit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MonthlySpendLimit
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "usageReportS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsageReportS3Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
