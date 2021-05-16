using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsPricingProduct), fullyQualifiedName: "aws.DataAwsPricingProduct", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsPricingProductConfig\"}}]")]
    public class DataAwsPricingProduct : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsPricingProduct(Constructs.Construct scope, string id, aws.IDataAwsPricingProductConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsPricingProduct(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsPricingProduct(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "filtersInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsPricingProductFilters\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsPricingProductFilters[] FiltersInput
        {
            get => GetInstanceProperty<aws.IDataAwsPricingProductFilters[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "result", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Result
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceCodeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceCodeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsPricingProductFilters\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsPricingProductFilters[] Filters
        {
            get => GetInstanceProperty<aws.IDataAwsPricingProductFilters[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
