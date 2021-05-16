using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.XraySamplingRule), fullyQualifiedName: "aws.XraySamplingRule", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.XraySamplingRuleConfig\"}}]")]
    public class XraySamplingRule : HashiCorp.Cdktf.TerraformResource
    {
        public XraySamplingRule(Constructs.Construct scope, string id, aws.IXraySamplingRuleConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected XraySamplingRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected XraySamplingRule(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAttributes")]
        public virtual void ResetAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuleName")]
        public virtual void ResetRuleName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fixedRateInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FixedRateInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "hostInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpMethodInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpMethodInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PriorityInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "reservoirSizeInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReservoirSizeInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "resourceArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "urlPathInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UrlPathInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VersionInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AttributesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fixedRate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FixedRate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reservoirSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReservoirSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ruleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "urlPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UrlPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
