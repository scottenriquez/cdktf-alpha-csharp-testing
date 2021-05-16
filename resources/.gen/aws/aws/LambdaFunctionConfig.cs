using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LambdaFunctionConfig")]
    public class LambdaFunctionConfig : aws.ILambdaFunctionConfig
    {
        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string FunctionName
        {
            get;
            set;
        }

        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Handler
        {
            get;
            set;
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Role
        {
            get;
            set;
        }

        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Runtime
        {
            get;
            set;
        }

        /// <summary>dead_letter_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionDeadLetterConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILambdaFunctionDeadLetterConfig[]? DeadLetterConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>environment block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEnvironment\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILambdaFunctionEnvironment[]? Environment
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Filename
        {
            get;
            set;
        }

        /// <summary>file_system_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionFileSystemConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILambdaFunctionFileSystemConfig[]? FileSystemConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "layers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Layers
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MemorySize
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "publish", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Publish
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "reservedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ReservedConcurrentExecutions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3Bucket
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3Key
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3ObjectVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SourceCodeHash
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Timeout
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.LambdaFunctionTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.ILambdaFunctionTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>tracing_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tracingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionTracingConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILambdaFunctionTracingConfig[]? TracingConfig
        {
            get;
            set;
        }

        /// <summary>vpc_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionVpcConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILambdaFunctionVpcConfig[]? VpcConfig
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
