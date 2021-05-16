using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.BudgetsBudgetCostTypes")]
    public class BudgetsBudgetCostTypes : aws.IBudgetsBudgetCostTypes
    {
        [JsiiOptional]
        [JsiiProperty(name: "includeCredit", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeCredit
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeDiscount", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeDiscount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeOtherSubscription", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeOtherSubscription
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeRecurring", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeRecurring
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeRefund", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeRefund
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeSubscription", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeSubscription
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeSupport", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeSupport
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeTax", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeTax
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeUpfront", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeUpfront
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "useAmortized", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? UseAmortized
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "useBlended", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? UseBlended
        {
            get;
            set;
        }
    }
}
