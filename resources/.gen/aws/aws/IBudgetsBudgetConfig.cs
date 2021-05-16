using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetConfig), fullyQualifiedName: "aws.BudgetsBudgetConfig")]
    public interface IBudgetsBudgetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "budgetType", typeJson: "{\"primitive\":\"string\"}")]
        string BudgetType
        {
            get;
        }

        [JsiiProperty(name: "limitAmount", typeJson: "{\"primitive\":\"string\"}")]
        string LimitAmount
        {
            get;
        }

        [JsiiProperty(name: "limitUnit", typeJson: "{\"primitive\":\"string\"}")]
        string LimitUnit
        {
            get;
        }

        [JsiiProperty(name: "timePeriodStart", typeJson: "{\"primitive\":\"string\"}")]
        string TimePeriodStart
        {
            get;
        }

        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        string TimeUnit
        {
            get;
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "costFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CostFilters
        {
            get
            {
                return null;
            }
        }

        /// <summary>cost_types block.</summary>
        [JsiiProperty(name: "costTypes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BudgetsBudgetCostTypes\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IBudgetsBudgetCostTypes[]? CostTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>notification block.</summary>
        [JsiiProperty(name: "notification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BudgetsBudgetNotification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IBudgetsBudgetNotification[]? Notification
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "timePeriodEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimePeriodEnd
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetConfig), fullyQualifiedName: "aws.BudgetsBudgetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IBudgetsBudgetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "budgetType", typeJson: "{\"primitive\":\"string\"}")]
            public string BudgetType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "limitAmount", typeJson: "{\"primitive\":\"string\"}")]
            public string LimitAmount
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "limitUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string LimitUnit
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "timePeriodStart", typeJson: "{\"primitive\":\"string\"}")]
            public string TimePeriodStart
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeUnit
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "costFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CostFilters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>cost_types block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "costTypes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BudgetsBudgetCostTypes\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IBudgetsBudgetCostTypes[]? CostTypes
            {
                get => GetInstanceProperty<aws.IBudgetsBudgetCostTypes[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>notification block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BudgetsBudgetNotification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IBudgetsBudgetNotification[]? Notification
            {
                get => GetInstanceProperty<aws.IBudgetsBudgetNotification[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "timePeriodEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimePeriodEnd
            {
                get => GetInstanceProperty<string?>();
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
