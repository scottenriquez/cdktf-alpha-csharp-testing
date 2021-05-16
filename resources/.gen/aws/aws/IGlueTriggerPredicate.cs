using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueTriggerPredicate), fullyQualifiedName: "aws.GlueTriggerPredicate")]
    public interface IGlueTriggerPredicate
    {
        /// <summary>conditions block.</summary>
        [JsiiProperty(name: "conditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueTriggerPredicateConditions\"},\"kind\":\"array\"}}")]
        aws.IGlueTriggerPredicateConditions[] Conditions
        {
            get;
        }

        [JsiiProperty(name: "logical", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Logical
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueTriggerPredicate), fullyQualifiedName: "aws.GlueTriggerPredicate")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueTriggerPredicate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>conditions block.</summary>
            [JsiiProperty(name: "conditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueTriggerPredicateConditions\"},\"kind\":\"array\"}}")]
            public aws.IGlueTriggerPredicateConditions[] Conditions
            {
                get => GetInstanceProperty<aws.IGlueTriggerPredicateConditions[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "logical", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Logical
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
