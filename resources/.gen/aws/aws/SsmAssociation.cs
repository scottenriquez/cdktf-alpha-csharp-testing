using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SsmAssociation), fullyQualifiedName: "aws.SsmAssociation", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SsmAssociationConfig\"}}]")]
    public class SsmAssociation : HashiCorp.Cdktf.TerraformResource
    {
        public SsmAssociation(Constructs.Construct scope, string id, aws.ISsmAssociationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmAssociation(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAssociationName")]
        public virtual void ResetAssociationName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomationTargetParameterName")]
        public virtual void ResetAutomationTargetParameterName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComplianceSeverity")]
        public virtual void ResetComplianceSeverity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDocumentVersion")]
        public virtual void ResetDocumentVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceId")]
        public virtual void ResetInstanceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxConcurrency")]
        public virtual void ResetMaxConcurrency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxErrors")]
        public virtual void ResetMaxErrors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputLocation")]
        public virtual void ResetOutputLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduleExpression")]
        public virtual void ResetScheduleExpression()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargets")]
        public virtual void ResetTargets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "associationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associationNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssociationNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automationTargetParameterNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutomationTargetParameterNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "complianceSeverityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComplianceSeverityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "documentVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DocumentVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxConcurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxErrorsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxErrorsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputLocationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmAssociationOutputLocation\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISsmAssociationOutputLocation[]? OutputLocationInput
        {
            get => GetInstanceProperty<aws.ISsmAssociationOutputLocation[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleExpressionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduleExpressionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmAssociationTargets\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISsmAssociationTargets[]? TargetsInput
        {
            get => GetInstanceProperty<aws.ISsmAssociationTargets[]?>();
        }

        [JsiiProperty(name: "associationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociationName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "automationTargetParameterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutomationTargetParameterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "complianceSeverity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComplianceSeverity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "outputLocation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmAssociationOutputLocation\"},\"kind\":\"array\"}}")]
        public virtual aws.ISsmAssociationOutputLocation[] OutputLocation
        {
            get => GetInstanceProperty<aws.ISsmAssociationOutputLocation[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduleExpression
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmAssociationTargets\"},\"kind\":\"array\"}}")]
        public virtual aws.ISsmAssociationTargets[] Targets
        {
            get => GetInstanceProperty<aws.ISsmAssociationTargets[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
