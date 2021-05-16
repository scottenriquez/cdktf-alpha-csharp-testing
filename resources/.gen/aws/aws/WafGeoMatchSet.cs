using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WafGeoMatchSet), fullyQualifiedName: "aws.WafGeoMatchSet", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WafGeoMatchSetConfig\"}}]")]
    public class WafGeoMatchSet : HashiCorp.Cdktf.TerraformResource
    {
        public WafGeoMatchSet(Constructs.Construct scope, string id, aws.IWafGeoMatchSetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafGeoMatchSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafGeoMatchSet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetGeoMatchConstraint")]
        public virtual void ResetGeoMatchConstraint()
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoMatchConstraintInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafGeoMatchSetGeoMatchConstraint\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafGeoMatchSetGeoMatchConstraint[]? GeoMatchConstraintInput
        {
            get => GetInstanceProperty<aws.IWafGeoMatchSetGeoMatchConstraint[]?>();
        }

        [JsiiProperty(name: "geoMatchConstraint", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafGeoMatchSetGeoMatchConstraint\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafGeoMatchSetGeoMatchConstraint[] GeoMatchConstraint
        {
            get => GetInstanceProperty<aws.IWafGeoMatchSetGeoMatchConstraint[]>()!;
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
