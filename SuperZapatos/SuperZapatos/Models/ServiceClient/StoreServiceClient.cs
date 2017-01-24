using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace SuperZapatos.Models.ServiceClient
{
    public class StoreServiceClient
    {
        private String BASE_URL = "http://localhost:64470/services/Stores/";

        
        public Object[] GetStores()
        {
            WebClient storeClient = new WebClient();
            var content = storeClient.DownloadString(this.BASE_URL);
            Object[] data = JsonConvert.DeserializeObject<Object[]>(content);

            return data;
        }
    }
}