namespace Smarty.Net.Core.InternationalStreetApi
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Changes : RootLevel
    {
        [DataMember(Name = "components")]
        public Components Components { get; set; }
    }
}