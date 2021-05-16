using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.BudgetsBudget), fullyQualifiedName: "aws.BudgetsBudget", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.BudgetsBudgetConfig\"}}]")]
    public class BudgetsBudget : HashiCorp.Cdktf.TerraformResource
    {
        public BudgetsBudget(Constructs.Construct scope, string id, aws.IBudgetsBudgetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudget(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudget(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCostFilters")]
        public virtual void ResetCostFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCostTypes")]
        public virtual void ResetCostTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamePrefix")]
        public virtual void ResetNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotification")]
        public virtual void ResetNotification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimePeriodEnd")]
        public virtual void ResetTimePeriodEnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "budgetTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BudgetTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "limitAmountInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LimitAmountInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "limitUnitInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LimitUnitInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePeriodStartInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePeriodStartInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUnitInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUnitInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "costFiltersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? CostFiltersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "costTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BudgetsBudgetCostTypes\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IBudgetsBudgetCostTypes[]? CostTypesInput
        {
            get => GetInstanceProperty<aws.IBudgetsBudgetCostTypes[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BudgetsBudgetNotification\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IBudgetsBudgetNotification[]? NotificationInput
        {
            get => GetInstanceProperty<aws.IBudgetsBudgetNotification[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timePeriodEndInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimePeriodEndInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "budgetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BudgetType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "costFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> CostFilters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "costTypes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BudgetsBudgetCostTypes\"},\"kind\":\"array\"}}")]
        public virtual aws.IBudgetsBudgetCostTypes[] CostTypes
        {
            get => GetInstanceProperty<aws.IBudgetsBudgetCostTypes[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "limitAmount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LimitAmount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "limitUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LimitUnit
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

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "notification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BudgetsBudgetNotification\"},\"kind\":\"array\"}}")]
        public virtual aws.IBudgetsBudgetNotification[] Notification
        {
            get => GetInstanceProperty<aws.IBudgetsBudgetNotification[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timePeriodEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePeriodEnd
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timePeriodStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePeriodStart
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
