using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleConfig), fullyQualifiedName: "aws.LbListenerRuleConfig")]
    public interface ILbListenerRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleAction\"},\"kind\":\"array\"}}")]
        aws.ILbListenerRuleAction[] Action
        {
            get;
        }

        /// <summary>condition block.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleCondition\"},\"kind\":\"array\"}}")]
        aws.ILbListenerRuleCondition[] Condition
        {
            get;
        }

        [JsiiProperty(name: "listenerArn", typeJson: "{\"primitive\":\"string\"}")]
        string ListenerArn
        {
            get;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleConfig), fullyQualifiedName: "aws.LbListenerRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ILbListenerRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleAction\"},\"kind\":\"array\"}}")]
            public aws.ILbListenerRuleAction[] Action
            {
                get => GetInstanceProperty<aws.ILbListenerRuleAction[]>()!;
            }

            /// <summary>condition block.</summary>
            [JsiiProperty(name: "condition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleCondition\"},\"kind\":\"array\"}}")]
            public aws.ILbListenerRuleCondition[] Condition
            {
                get => GetInstanceProperty<aws.ILbListenerRuleCondition[]>()!;
            }

            [JsiiProperty(name: "listenerArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ListenerArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
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
