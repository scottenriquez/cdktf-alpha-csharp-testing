using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlueClassifierGrokClassifier")]
    public class GlueClassifierGrokClassifier : aws.IGlueClassifierGrokClassifier
    {
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Classification
        {
            get;
            set;
        }

        [JsiiProperty(name: "grokPattern", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string GrokPattern
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customPatterns", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CustomPatterns
        {
            get;
            set;
        }
    }
}
