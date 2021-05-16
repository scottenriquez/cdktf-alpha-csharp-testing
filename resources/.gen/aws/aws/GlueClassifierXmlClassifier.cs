using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlueClassifierXmlClassifier")]
    public class GlueClassifierXmlClassifier : aws.IGlueClassifierXmlClassifier
    {
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Classification
        {
            get;
            set;
        }

        [JsiiProperty(name: "rowTag", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RowTag
        {
            get;
            set;
        }
    }
}
