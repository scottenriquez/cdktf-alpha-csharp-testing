using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SesDomainMailFrom), fullyQualifiedName: "aws.SesDomainMailFrom", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SesDomainMailFromConfig\"}}]")]
    public class SesDomainMailFrom : HashiCorp.Cdktf.TerraformResource
    {
        public SesDomainMailFrom(Constructs.Construct scope, string id, aws.ISesDomainMailFromConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesDomainMailFrom(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesDomainMailFrom(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBehaviorOnMxFailure")]
        public virtual void ResetBehaviorOnMxFailure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "domainInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mailFromDomainInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MailFromDomainInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "behaviorOnMxFailureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BehaviorOnMxFailureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "behaviorOnMxFailure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BehaviorOnMxFailure
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mailFromDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MailFromDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
