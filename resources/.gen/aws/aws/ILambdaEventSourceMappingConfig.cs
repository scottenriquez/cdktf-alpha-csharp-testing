using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingConfig), fullyQualifiedName: "aws.LambdaEventSourceMappingConfig")]
    public interface ILambdaEventSourceMappingConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "eventSourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string EventSourceArn
        {
            get;
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionName
        {
            get;
        }

        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchSize
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bisectBatchOnFunctionError", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? BisectBatchOnFunctionError
        {
            get
            {
                return null;
            }
        }

        /// <summary>destination_config block.</summary>
        [JsiiProperty(name: "destinationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaEventSourceMappingDestinationConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILambdaEventSourceMappingDestinationConfig[]? DestinationConfig
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

        [JsiiProperty(name: "maximumBatchingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumBatchingWindowInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maximumRecordAgeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumRecordAgeInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumRetryAttempts
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "parallelizationFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ParallelizationFactor
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartingPosition
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "startingPositionTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartingPositionTimestamp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingConfig), fullyQualifiedName: "aws.LambdaEventSourceMappingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ILambdaEventSourceMappingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "eventSourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string EventSourceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchSize
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bisectBatchOnFunctionError", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? BisectBatchOnFunctionError
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>destination_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaEventSourceMappingDestinationConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILambdaEventSourceMappingDestinationConfig[]? DestinationConfig
            {
                get => GetInstanceProperty<aws.ILambdaEventSourceMappingDestinationConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maximumBatchingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumBatchingWindowInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maximumRecordAgeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumRecordAgeInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumRetryAttempts
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "parallelizationFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ParallelizationFactor
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartingPosition
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "startingPositionTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartingPositionTimestamp
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
