using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISesReceiptRuleConfig), fullyQualifiedName: "aws.SesReceiptRuleConfig")]
    public interface ISesReceiptRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "ruleSetName", typeJson: "{\"primitive\":\"string\"}")]
        string RuleSetName
        {
            get;
        }

        /// <summary>add_header_action block.</summary>
        [JsiiProperty(name: "addHeaderAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleAddHeaderAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISesReceiptRuleAddHeaderAction[]? AddHeaderAction
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? After
        {
            get
            {
                return null;
            }
        }

        /// <summary>bounce_action block.</summary>
        [JsiiProperty(name: "bounceAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleBounceAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISesReceiptRuleBounceAction[]? BounceAction
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_action block.</summary>
        [JsiiProperty(name: "lambdaAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleLambdaAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISesReceiptRuleLambdaAction[]? LambdaAction
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "recipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Recipients
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_action block.</summary>
        [JsiiProperty(name: "s3Action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleS3Action\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISesReceiptRuleS3Action[]? S3Action
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "scanEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ScanEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>sns_action block.</summary>
        [JsiiProperty(name: "snsAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleSnsAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISesReceiptRuleSnsAction[]? SnsAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>stop_action block.</summary>
        [JsiiProperty(name: "stopAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleStopAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISesReceiptRuleStopAction[]? StopAction
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TlsPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>workmail_action block.</summary>
        [JsiiProperty(name: "workmailAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleWorkmailAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISesReceiptRuleWorkmailAction[]? WorkmailAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesReceiptRuleConfig), fullyQualifiedName: "aws.SesReceiptRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ISesReceiptRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "ruleSetName", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleSetName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>add_header_action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "addHeaderAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleAddHeaderAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISesReceiptRuleAddHeaderAction[]? AddHeaderAction
            {
                get => GetInstanceProperty<aws.ISesReceiptRuleAddHeaderAction[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? After
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>bounce_action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bounceAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleBounceAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISesReceiptRuleBounceAction[]? BounceAction
            {
                get => GetInstanceProperty<aws.ISesReceiptRuleBounceAction[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>lambda_action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleLambdaAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISesReceiptRuleLambdaAction[]? LambdaAction
            {
                get => GetInstanceProperty<aws.ISesReceiptRuleLambdaAction[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "recipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Recipients
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>s3_action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3Action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleS3Action\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISesReceiptRuleS3Action[]? S3Action
            {
                get => GetInstanceProperty<aws.ISesReceiptRuleS3Action[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "scanEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ScanEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>sns_action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "snsAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleSnsAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISesReceiptRuleSnsAction[]? SnsAction
            {
                get => GetInstanceProperty<aws.ISesReceiptRuleSnsAction[]?>();
            }

            /// <summary>stop_action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stopAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleStopAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISesReceiptRuleStopAction[]? StopAction
            {
                get => GetInstanceProperty<aws.ISesReceiptRuleStopAction[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TlsPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>workmail_action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workmailAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleWorkmailAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISesReceiptRuleWorkmailAction[]? WorkmailAction
            {
                get => GetInstanceProperty<aws.ISesReceiptRuleWorkmailAction[]?>();
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
