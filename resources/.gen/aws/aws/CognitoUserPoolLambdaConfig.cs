using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CognitoUserPoolLambdaConfig")]
    public class CognitoUserPoolLambdaConfig : aws.ICognitoUserPoolLambdaConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "createAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CreateAuthChallenge
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CustomMessage
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defineAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefineAuthChallenge
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "postAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PostAuthentication
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "postConfirmation", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PostConfirmation
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PreAuthentication
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preSignUp", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PreSignUp
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preTokenGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PreTokenGeneration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "userMigration", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? UserMigration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "verifyAuthChallengeResponse", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VerifyAuthChallengeResponse
        {
            get;
            set;
        }
    }
}
