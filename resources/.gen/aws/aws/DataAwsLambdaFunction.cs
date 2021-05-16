using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsLambdaFunction), fullyQualifiedName: "aws.DataAwsLambdaFunction", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsLambdaFunctionConfig\"}}]")]
    public class DataAwsLambdaFunction : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsLambdaFunction(Constructs.Construct scope, string id, aws.IDataAwsLambdaFunctionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLambdaFunction(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLambdaFunction(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "deadLetterConfig", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLambdaFunctionDeadLetterConfig\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLambdaFunctionDeadLetterConfig DeadLetterConfig(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLambdaFunctionDeadLetterConfig>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "environment", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLambdaFunctionEnvironment\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLambdaFunctionEnvironment Environment(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLambdaFunctionEnvironment>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "fileSystemConfig", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLambdaFunctionFileSystemConfig\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLambdaFunctionFileSystemConfig FileSystemConfig(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLambdaFunctionFileSystemConfig>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetQualifier")]
        public virtual void ResetQualifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "tracingConfig", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLambdaFunctionTracingConfig\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLambdaFunctionTracingConfig TracingConfig(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLambdaFunctionTracingConfig>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "vpcConfig", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLambdaFunctionVpcConfig\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLambdaFunctionVpcConfig VpcConfig(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLambdaFunctionVpcConfig>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "functionNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Handler
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

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "layers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Layers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "qualifiedArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QualifiedArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reservedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReservedConcurrentExecutions
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Runtime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCodeHash
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceCodeSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SourceCodeSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "qualifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QualifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Qualifier
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
    }
}
