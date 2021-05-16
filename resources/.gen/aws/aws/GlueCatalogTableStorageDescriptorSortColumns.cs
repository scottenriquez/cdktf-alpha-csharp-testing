using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlueCatalogTableStorageDescriptorSortColumns")]
    public class GlueCatalogTableStorageDescriptorSortColumns : aws.IGlueCatalogTableStorageDescriptorSortColumns
    {
        [JsiiProperty(name: "column", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Column
        {
            get;
            set;
        }

        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double SortOrder
        {
            get;
            set;
        }
    }
}
