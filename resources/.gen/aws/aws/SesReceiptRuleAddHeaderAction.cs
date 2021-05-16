using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SesReceiptRuleAddHeaderAction")]
    public class SesReceiptRuleAddHeaderAction : aws.ISesReceiptRuleAddHeaderAction
    {
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HeaderName
        {
            get;
            set;
        }

        [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HeaderValue
        {
            get;
            set;
        }

        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Position
        {
            get;
            set;
        }
    }
}
