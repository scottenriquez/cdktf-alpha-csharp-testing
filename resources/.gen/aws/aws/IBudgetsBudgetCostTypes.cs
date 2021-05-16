using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetCostTypes), fullyQualifiedName: "aws.BudgetsBudgetCostTypes")]
    public interface IBudgetsBudgetCostTypes
    {
        [JsiiProperty(name: "includeCredit", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeCredit
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "includeDiscount", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeDiscount
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "includeOtherSubscription", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeOtherSubscription
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "includeRecurring", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeRecurring
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "includeRefund", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeRefund
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "includeSubscription", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeSubscription
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "includeSupport", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeSupport
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "includeTax", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeTax
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "includeUpfront", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeUpfront
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "useAmortized", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? UseAmortized
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "useBlended", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? UseBlended
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetCostTypes), fullyQualifiedName: "aws.BudgetsBudgetCostTypes")]
        internal sealed class _Proxy : DeputyBase, aws.IBudgetsBudgetCostTypes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeCredit", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeCredit
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeDiscount", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeDiscount
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeOtherSubscription", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeOtherSubscription
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeRecurring", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeRecurring
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeRefund", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeRefund
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeSubscription", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeSubscription
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeSupport", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeSupport
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeTax", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeTax
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeUpfront", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeUpfront
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "useAmortized", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? UseAmortized
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "useBlended", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? UseBlended
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
