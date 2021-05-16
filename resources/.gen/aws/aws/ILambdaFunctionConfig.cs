using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionConfig), fullyQualifiedName: "aws.LambdaFunctionConfig")]
    public interface ILambdaFunctionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionName
        {
            get;
        }

        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
        string Handler
        {
            get;
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
        string Runtime
        {
            get;
        }

        /// <summary>dead_letter_config block.</summary>
        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionDeadLetterConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILambdaFunctionDeadLetterConfig[]? DeadLetterConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>environment block.</summary>
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEnvironment\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILambdaFunctionEnvironment[]? Environment
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Filename
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_system_config block.</summary>
        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionFileSystemConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILambdaFunctionFileSystemConfig[]? FileSystemConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "layers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Layers
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemorySize
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "publish", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Publish
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "reservedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReservedConcurrentExecutions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3Bucket
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3Key
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3ObjectVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceCodeHash
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.LambdaFunctionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILambdaFunctionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>tracing_config block.</summary>
        [JsiiProperty(name: "tracingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionTracingConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILambdaFunctionTracingConfig[]? TracingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_config block.</summary>
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionVpcConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILambdaFunctionVpcConfig[]? VpcConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionConfig), fullyQualifiedName: "aws.LambdaFunctionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ILambdaFunctionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
            public string Handler
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
            public string Runtime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>dead_letter_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionDeadLetterConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILambdaFunctionDeadLetterConfig[]? DeadLetterConfig
            {
                get => GetInstanceProperty<aws.ILambdaFunctionDeadLetterConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>environment block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEnvironment\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILambdaFunctionEnvironment[]? Environment
            {
                get => GetInstanceProperty<aws.ILambdaFunctionEnvironment[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Filename
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>file_system_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionFileSystemConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILambdaFunctionFileSystemConfig[]? FileSystemConfig
            {
                get => GetInstanceProperty<aws.ILambdaFunctionFileSystemConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "layers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Layers
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemorySize
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "publish", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Publish
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "reservedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReservedConcurrentExecutions
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3Key
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3ObjectVersion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceCodeHash
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.LambdaFunctionTimeouts\"}", isOptional: true)]
            public aws.ILambdaFunctionTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.ILambdaFunctionTimeouts?>();
            }

            /// <summary>tracing_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tracingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionTracingConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILambdaFunctionTracingConfig[]? TracingConfig
            {
                get => GetInstanceProperty<aws.ILambdaFunctionTracingConfig[]?>();
            }

            /// <summary>vpc_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionVpcConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILambdaFunctionVpcConfig[]? VpcConfig
            {
                get => GetInstanceProperty<aws.ILambdaFunctionVpcConfig[]?>();
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
