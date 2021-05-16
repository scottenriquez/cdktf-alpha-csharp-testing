using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.BudgetsBudgetConfig")]
    public class BudgetsBudgetConfig : aws.IBudgetsBudgetConfig
    {
        [JsiiProperty(name: "budgetType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BudgetType
        {
            get;
            set;
        }

        [JsiiProperty(name: "limitAmount", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LimitAmount
        {
            get;
            set;
        }

        [JsiiProperty(name: "limitUnit", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LimitUnit
        {
            get;
            set;
        }

        [JsiiProperty(name: "timePeriodStart", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TimePeriodStart
        {
            get;
            set;
        }

        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TimeUnit
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AccountId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? CostFilters
        {
            get;
            set;
        }

        /// <summary>cost_types block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "costTypes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BudgetsBudgetCostTypes\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IBudgetsBudgetCostTypes[]? CostTypes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NamePrefix
        {
            get;
            set;
        }

        /// <summary>notification block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BudgetsBudgetNotification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IBudgetsBudgetNotification[]? Notification
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timePeriodEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TimePeriodEnd
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
