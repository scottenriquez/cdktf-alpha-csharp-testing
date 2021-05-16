using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DataAwsPricingProductFilters")]
    public class DataAwsPricingProductFilters : aws.IDataAwsPricingProductFilters
    {
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Field
        {
            get;
            set;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Value
        {
            get;
            set;
        }
    }
}
