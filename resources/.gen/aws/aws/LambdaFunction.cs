using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.LambdaFunction), fullyQualifiedName: "aws.LambdaFunction", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.LambdaFunctionConfig\"}}]")]
    public class LambdaFunction : HashiCorp.Cdktf.TerraformResource
    {
        public LambdaFunction(Constructs.Construct scope, string id, aws.ILambdaFunctionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunction(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunction(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDeadLetterConfig")]
        public virtual void ResetDeadLetterConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironment")]
        public virtual void ResetEnvironment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilename")]
        public virtual void ResetFilename()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileSystemConfig")]
        public virtual void ResetFileSystemConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyArn")]
        public virtual void ResetKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLayers")]
        public virtual void ResetLayers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemorySize")]
        public virtual void ResetMemorySize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublish")]
        public virtual void ResetPublish()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReservedConcurrentExecutions")]
        public virtual void ResetReservedConcurrentExecutions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Bucket")]
        public virtual void ResetS3Bucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Key")]
        public virtual void ResetS3Key()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3ObjectVersion")]
        public virtual void ResetS3ObjectVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceCodeHash")]
        public virtual void ResetSourceCodeHash()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTracingConfig")]
        public virtual void ResetTracingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcConfig")]
        public virtual void ResetVpcConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "functionNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "handlerInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HandlerInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invokeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvokeArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "qualifiedArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QualifiedArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runtimeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceCodeSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SourceCodeSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deadLetterConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionDeadLetterConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILambdaFunctionDeadLetterConfig[]? DeadLetterConfigInput
        {
            get => GetInstanceProperty<aws.ILambdaFunctionDeadLetterConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEnvironment\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILambdaFunctionEnvironment[]? EnvironmentInput
        {
            get => GetInstanceProperty<aws.ILambdaFunctionEnvironment[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filenameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FilenameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionFileSystemConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILambdaFunctionFileSystemConfig[]? FileSystemConfigInput
        {
            get => GetInstanceProperty<aws.ILambdaFunctionFileSystemConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "layersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LayersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memorySizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemorySizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publishInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? PublishInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reservedConcurrentExecutionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReservedConcurrentExecutionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3KeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ObjectVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3ObjectVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceCodeHashInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceCodeHashInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.LambdaFunctionTimeouts\"}", isOptional: true)]
        public virtual aws.ILambdaFunctionTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.ILambdaFunctionTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tracingConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionTracingConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILambdaFunctionTracingConfig[]? TracingConfigInput
        {
            get => GetInstanceProperty<aws.ILambdaFunctionTracingConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionVpcConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILambdaFunctionVpcConfig[]? VpcConfigInput
        {
            get => GetInstanceProperty<aws.ILambdaFunctionVpcConfig[]?>();
        }

        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionDeadLetterConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ILambdaFunctionDeadLetterConfig[] DeadLetterConfig
        {
            get => GetInstanceProperty<aws.ILambdaFunctionDeadLetterConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEnvironment\"},\"kind\":\"array\"}}")]
        public virtual aws.ILambdaFunctionEnvironment[] Environment
        {
            get => GetInstanceProperty<aws.ILambdaFunctionEnvironment[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Filename
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionFileSystemConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ILambdaFunctionFileSystemConfig[] FileSystemConfig
        {
            get => GetInstanceProperty<aws.ILambdaFunctionFileSystemConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Handler
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "layers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Layers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publish", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Publish
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reservedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReservedConcurrentExecutions
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Runtime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3ObjectVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCodeHash
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.LambdaFunctionTimeouts\"}")]
        public virtual aws.ILambdaFunctionTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.ILambdaFunctionTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tracingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionTracingConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ILambdaFunctionTracingConfig[] TracingConfig
        {
            get => GetInstanceProperty<aws.ILambdaFunctionTracingConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionVpcConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ILambdaFunctionVpcConfig[] VpcConfig
        {
            get => GetInstanceProperty<aws.ILambdaFunctionVpcConfig[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
