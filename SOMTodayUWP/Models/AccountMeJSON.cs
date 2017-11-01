using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMTodayUWP.Models
{




    public class Link2
    {
        public int id { get; set; }
        public string rel { get; set; }
        public string type { get; set; }
        public string href { get; set; }
    }

    public class Permission2
    {
        public string full { get; set; }
        public string type { get; set; }
        public List<string> operations { get; set; }
        public List<string> instances { get; set; }
    }

    public class AdditionalObjects2
    {
    }

    public class Persoon
    {

        public List<Link2> links { get; set; }
        public List<Permission2> permissions { get; set; }

        public int leerlingnummer { get; set; }
        public string roepnaam { get; set; }
        public string achternaam { get; set; }
    }

    public class RootObject
    {
        public List<Link> links { get; set; }
        public List<Permission> permissions { get; set; }

        public string gebruikersnaam { get; set; }
        public List<object> accountPermissions { get; set; }
        public Persoon persoon { get; set; }
    }
}