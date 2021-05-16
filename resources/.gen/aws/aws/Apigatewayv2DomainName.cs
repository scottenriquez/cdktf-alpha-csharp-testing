using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2DomainName), fullyQualifiedName: "aws.Apigatewayv2DomainName", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.Apigatewayv2DomainNameConfig\"}}]")]
    public class Apigatewayv2DomainName : HashiCorp.Cdktf.TerraformResource
    {
        public Apigatewayv2DomainName(Constructs.Construct scope, string id, aws.IApigatewayv2DomainNameConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2DomainName(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2DomainName(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "apiMappingSelectionExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiMappingSelectionExpression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainNameConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2DomainNameDomainNameConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IApigatewayv2DomainNameDomainNameConfiguration[] DomainNameConfigurationInput
        {
            get => GetInstanceProperty<aws.IApigatewayv2DomainNameDomainNameConfiguration[]>()!;
        }

        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.Apigatewayv2DomainNameTimeouts\"}", isOptional: true)]
        public virtual aws.IApigatewayv2DomainNameTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IApigatewayv2DomainNameTimeouts?>();
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainNameConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2DomainNameDomainNameConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IApigatewayv2DomainNameDomainNameConfiguration[] DomainNameConfiguration
        {
            get => GetInstanceProperty<aws.IApigatewayv2DomainNameDomainNameConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.Apigatewayv2DomainNameTimeouts\"}")]
        public virtual aws.IApigatewayv2DomainNameTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IApigatewayv2DomainNameTimeouts>()!;
            set => SetInstanceProperty(value);
        }
    }
}
