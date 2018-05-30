using System.Collections.Generic;

namespace UmbracoWithReactJs.Models
{
    public class MasterModel 
    {  
        public IEnumerable<ContentModel> TopNavigation { get; set; }
        public InitialState InitialState { get; set; }
        
    }
}