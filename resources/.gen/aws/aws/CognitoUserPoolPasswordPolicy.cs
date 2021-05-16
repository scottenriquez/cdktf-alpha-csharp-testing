using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CognitoUserPoolPasswordPolicy")]
    public class CognitoUserPoolPasswordPolicy : aws.ICognitoUserPoolPasswordPolicy
    {
        [JsiiOptional]
        [JsiiProperty(name: "minimumLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MinimumLength
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireLowercase", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RequireLowercase
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireNumbers", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RequireNumbers
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireSymbols", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RequireSymbols
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireUppercase", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RequireUppercase
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "temporaryPasswordValidityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TemporaryPasswordValidityDays
        {
            get;
            set;
        }
    }
}
