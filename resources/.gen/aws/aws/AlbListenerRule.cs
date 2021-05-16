using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.AlbListenerRule), fullyQualifiedName: "aws.AlbListenerRule", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.AlbListenerRuleConfig\"}}]")]
    public class AlbListenerRule : HashiCorp.Cdktf.TerraformResource
    {
        public AlbListenerRule(Constructs.Construct scope, string id, aws.IAlbListenerRuleConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerRule(DeputyProps props): base(props)
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

        [JsiiProperty(name: "actionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleAction\"},\"kind\":\"array\"}}")]
        public virtual aws.IAlbListenerRuleAction[] ActionInput
        {
            get => GetInstanceProperty<aws.IAlbListenerRuleAction[]>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "conditionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleCondition\"},\"kind\":\"array\"}}")]
        public virtual aws.IAlbListenerRuleCondition[] ConditionInput
        {
            get => GetInstanceProperty<aws.IAlbListenerRuleCondition[]>()!;
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

        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleAction\"},\"kind\":\"array\"}}")]
        public virtual aws.IAlbListenerRuleAction[] Action
        {
            get => GetInstanceProperty<aws.IAlbListenerRuleAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "condition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleCondition\"},\"kind\":\"array\"}}")]
        public virtual aws.IAlbListenerRuleCondition[] Condition
        {
            get => GetInstanceProperty<aws.IAlbListenerRuleCondition[]>()!;
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
