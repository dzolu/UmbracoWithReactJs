using System.Collections.Generic;
using Umbraco.Core.Packaging.Models;

namespace UmbracoWithReactJs.Models
{
    public class MasterModel
    {
        public IEnumerable<MetaData> TopNavigation { get; set; }
        public InitialState InitialState { get; set; }
    }
}