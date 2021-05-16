using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CognitoResourceServerScope")]
    public class CognitoResourceServerScope : aws.ICognitoResourceServerScope
    {
        [JsiiProperty(name: "scopeDescription", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ScopeDescription
        {
            get;
            set;
        }

        [JsiiProperty(name: "scopeName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ScopeName
        {
            get;
            set;
        }
    }
}
