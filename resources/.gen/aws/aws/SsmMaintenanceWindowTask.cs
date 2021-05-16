using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SsmMaintenanceWindowTask), fullyQualifiedName: "aws.SsmMaintenanceWindowTask", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskConfig\"}}]")]
    public class SsmMaintenanceWindowTask : HashiCorp.Cdktf.TerraformResource
    {
        public SsmMaintenanceWindowTask(Constructs.Construct scope, string id, aws.ISsmMaintenanceWindowTaskConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmMaintenanceWindowTask(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmMaintenanceWindowTask(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingInfo")]
        public virtual void ResetLoggingInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskInvocationParameters")]
        public virtual void ResetTaskInvocationParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskParameters")]
        public virtual void ResetTaskParameters()
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

        [JsiiProperty(name: "maxConcurrencyInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxConcurrencyInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxErrorsInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxErrorsInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceRoleArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTargets\"},\"kind\":\"array\"}}")]
        public virtual aws.ISsmMaintenanceWindowTaskTargets[] TargetsInput
        {
            get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTargets[]>()!;
        }

        [JsiiProperty(name: "taskArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taskTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "windowIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WindowIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInfoInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskLoggingInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISsmMaintenanceWindowTaskLoggingInfo[]? LoggingInfoInput
        {
            get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskLoggingInfo[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskInvocationParametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISsmMaintenanceWindowTaskTaskInvocationParameters[]? TaskInvocationParametersInput
        {
            get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskInvocationParameters[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskParametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISsmMaintenanceWindowTaskTaskParameters[]? TaskParametersInput
        {
            get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskParameters[]?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loggingInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskLoggingInfo\"},\"kind\":\"array\"}}")]
        public virtual aws.ISsmMaintenanceWindowTaskLoggingInfo[] LoggingInfo
        {
            get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskLoggingInfo[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxConcurrency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxErrors
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTargets\"},\"kind\":\"array\"}}")]
        public virtual aws.ISsmMaintenanceWindowTaskTargets[] Targets
        {
            get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTargets[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskInvocationParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParameters\"},\"kind\":\"array\"}}")]
        public virtual aws.ISsmMaintenanceWindowTaskTaskInvocationParameters[] TaskInvocationParameters
        {
            get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskInvocationParameters[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskParameters\"},\"kind\":\"array\"}}")]
        public virtual aws.ISsmMaintenanceWindowTaskTaskParameters[] TaskParameters
        {
            get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskParameters[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "windowId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WindowId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
