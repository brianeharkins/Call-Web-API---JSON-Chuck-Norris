using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_Web_API_1
{

//    {
//  "categories": [],
//  "created_at": "2020-01-05 13:42:26.447675",
//  "icon_url": "https://assets.chucknorris.host/img/avatar/chuck-norris.png",
//  "id": "O9R2JBx9TAC2bbaurxrwzg",
//  "updated_at": "2020-01-05 13:42:26.447675",
//  "url": "https://api.chucknorris.io/jokes/O9R2JBx9TAC2bbaurxrwzg",
//  "value": "Chuck Norris can piss into the wind and not get wet."
//  }

class jsonJoke
    {
        public DateTime created_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public DateTime updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }

    }
}
