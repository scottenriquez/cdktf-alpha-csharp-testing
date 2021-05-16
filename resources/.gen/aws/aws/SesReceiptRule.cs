using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SesReceiptRule), fullyQualifiedName: "aws.SesReceiptRule", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SesReceiptRuleConfig\"}}]")]
    public class SesReceiptRule : HashiCorp.Cdktf.TerraformResource
    {
        public SesReceiptRule(Constructs.Construct scope, string id, aws.ISesReceiptRuleConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesReceiptRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesReceiptRule(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAddHeaderAction")]
        public virtual void ResetAddHeaderAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAfter")]
        public virtual void ResetAfter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBounceAction")]
        public virtual void ResetBounceAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaAction")]
        public virtual void ResetLambdaAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecipients")]
        public virtual void ResetRecipients()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Action")]
        public virtual void ResetS3Action()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScanEnabled")]
        public virtual void ResetScanEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnsAction")]
        public virtual void ResetSnsAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStopAction")]
        public virtual void ResetStopAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlsPolicy")]
        public virtual void ResetTlsPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkmailAction")]
        public virtual void ResetWorkmailAction()
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

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ruleSetNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleSetNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addHeaderActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleAddHeaderAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISesReceiptRuleAddHeaderAction[]? AddHeaderActionInput
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleAddHeaderAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "afterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AfterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bounceActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleBounceAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISesReceiptRuleBounceAction[]? BounceActionInput
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleBounceAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EnabledInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleLambdaAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISesReceiptRuleLambdaAction[]? LambdaActionInput
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleLambdaAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recipientsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RecipientsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleS3Action\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISesReceiptRuleS3Action[]? S3ActionInput
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleS3Action[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scanEnabledInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? ScanEnabledInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snsActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleSnsAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISesReceiptRuleSnsAction[]? SnsActionInput
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleSnsAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stopActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleStopAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISesReceiptRuleStopAction[]? StopActionInput
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleStopAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TlsPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workmailActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleWorkmailAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISesReceiptRuleWorkmailAction[]? WorkmailActionInput
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleWorkmailAction[]?>();
        }

        [JsiiProperty(name: "addHeaderAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleAddHeaderAction\"},\"kind\":\"array\"}}")]
        public virtual aws.ISesReceiptRuleAddHeaderAction[] AddHeaderAction
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleAddHeaderAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string After
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bounceAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleBounceAction\"},\"kind\":\"array\"}}")]
        public virtual aws.ISesReceiptRuleBounceAction[] BounceAction
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleBounceAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Enabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lambdaAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleLambdaAction\"},\"kind\":\"array\"}}")]
        public virtual aws.ISesReceiptRuleLambdaAction[] LambdaAction
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleLambdaAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Recipients
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ruleSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleSetName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleS3Action\"},\"kind\":\"array\"}}")]
        public virtual aws.ISesReceiptRuleS3Action[] S3Action
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleS3Action[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scanEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ScanEnabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snsAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleSnsAction\"},\"kind\":\"array\"}}")]
        public virtual aws.ISesReceiptRuleSnsAction[] SnsAction
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleSnsAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stopAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleStopAction\"},\"kind\":\"array\"}}")]
        public virtual aws.ISesReceiptRuleStopAction[] StopAction
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleStopAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TlsPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workmailAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleWorkmailAction\"},\"kind\":\"array\"}}")]
        public virtual aws.ISesReceiptRuleWorkmailAction[] WorkmailAction
        {
            get => GetInstanceProperty<aws.ISesReceiptRuleWorkmailAction[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
