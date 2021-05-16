using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.ApiGatewayDocumentationPart), fullyQualifiedName: "aws.ApiGatewayDocumentationPart", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ApiGatewayDocumentationPartConfig\"}}]")]
    public class ApiGatewayDocumentationPart : HashiCorp.Cdktf.TerraformResource
    {
        public ApiGatewayDocumentationPart(Constructs.Construct scope, string id, aws.IApiGatewayDocumentationPartConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayDocumentationPart(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayDocumentationPart(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "locationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayDocumentationPartLocation\"},\"kind\":\"array\"}}")]
        public virtual aws.IApiGatewayDocumentationPartLocation[] LocationInput
        {
            get => GetInstanceProperty<aws.IApiGatewayDocumentationPartLocation[]>()!;
        }

        [JsiiProperty(name: "propertiesInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PropertiesInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "restApiIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestApiIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayDocumentationPartLocation\"},\"kind\":\"array\"}}")]
        public virtual aws.IApiGatewayDocumentationPartLocation[] Location
        {
            get => GetInstanceProperty<aws.IApiGatewayDocumentationPartLocation[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "properties", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Properties
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
