using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.LbCookieStickinessPolicy), fullyQualifiedName: "aws.LbCookieStickinessPolicy", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.LbCookieStickinessPolicyConfig\"}}]")]
    public class LbCookieStickinessPolicy : HashiCorp.Cdktf.TerraformResource
    {
        public LbCookieStickinessPolicy(Constructs.Construct scope, string id, aws.ILbCookieStickinessPolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbCookieStickinessPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbCookieStickinessPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCookieExpirationPeriod")]
        public virtual void ResetCookieExpirationPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lbPortInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LbPortInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "loadBalancerInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookieExpirationPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CookieExpirationPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "cookieExpirationPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CookieExpirationPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lbPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LbPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancer
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
    }
}
