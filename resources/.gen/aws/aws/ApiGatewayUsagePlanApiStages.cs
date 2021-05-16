using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ApiGatewayUsagePlanApiStages")]
    public class ApiGatewayUsagePlanApiStages : aws.IApiGatewayUsagePlanApiStages
    {
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ApiId
        {
            get;
            set;
        }

        [JsiiProperty(name: "stage", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Stage
        {
            get;
            set;
        }
    }
}
