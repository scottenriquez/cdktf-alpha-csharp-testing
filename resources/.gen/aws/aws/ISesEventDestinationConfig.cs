using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISesEventDestinationConfig), fullyQualifiedName: "aws.SesEventDestinationConfig")]
    public interface ISesEventDestinationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "configurationSetName", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigurationSetName
        {
            get;
        }

        [JsiiProperty(name: "matchingTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] MatchingTypes
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>cloudwatch_destination block.</summary>
        [JsiiProperty(name: "cloudwatchDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationCloudwatchDestination\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISesEventDestinationCloudwatchDestination[]? CloudwatchDestination
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_destination block.</summary>
        [JsiiProperty(name: "kinesisDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationKinesisDestination\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISesEventDestinationKinesisDestination[]? KinesisDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>sns_destination block.</summary>
        [JsiiProperty(name: "snsDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationSnsDestination\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISesEventDestinationSnsDestination[]? SnsDestination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesEventDestinationConfig), fullyQualifiedName: "aws.SesEventDestinationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ISesEventDestinationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "configurationSetName", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigurationSetName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "matchingTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] MatchingTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cloudwatch_destination block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationCloudwatchDestination\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISesEventDestinationCloudwatchDestination[]? CloudwatchDestination
            {
                get => GetInstanceProperty<aws.ISesEventDestinationCloudwatchDestination[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>kinesis_destination block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationKinesisDestination\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISesEventDestinationKinesisDestination[]? KinesisDestination
            {
                get => GetInstanceProperty<aws.ISesEventDestinationKinesisDestination[]?>();
            }

            /// <summary>sns_destination block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "snsDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationSnsDestination\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISesEventDestinationSnsDestination[]? SnsDestination
            {
                get => GetInstanceProperty<aws.ISesEventDestinationSnsDestination[]?>();
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
