using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.LbListenerRule), fullyQualifiedName: "aws.LbListenerRule", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.LbListenerRuleConfig\"}}]")]
    public class LbListenerRule : HashiCorp.Cdktf.TerraformResource
    {
        public LbListenerRule(Constructs.Construct scope, string id, aws.ILbListenerRuleConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerRule(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "actionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleAction\"},\"kind\":\"array\"}}")]
        public virtual aws.ILbListenerRuleAction[] ActionInput
        {
            get => GetInstanceProperty<aws.ILbListenerRuleAction[]>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "conditionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleCondition\"},\"kind\":\"array\"}}")]
        public virtual aws.ILbListenerRuleCondition[] ConditionInput
        {
            get => GetInstanceProperty<aws.ILbListenerRuleCondition[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listenerArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListenerArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleAction\"},\"kind\":\"array\"}}")]
        public virtual aws.ILbListenerRuleAction[] Action
        {
            get => GetInstanceProperty<aws.ILbListenerRuleAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "condition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleCondition\"},\"kind\":\"array\"}}")]
        public virtual aws.ILbListenerRuleCondition[] Condition
        {
            get => GetInstanceProperty<aws.ILbListenerRuleCondition[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "listenerArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListenerArn
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
    }
}
