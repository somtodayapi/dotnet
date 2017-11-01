using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMTodayUWP.Models
{
    public partial class RootGrades
    {
        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("additionalObjects")]
        public AdditionalObjects AdditionalObjects { get; set; }

        [JsonProperty("datumInvoer")]
        public string DatumInvoer { get; set; }

        [JsonProperty("examenWeging")]
        public long? ExamenWeging { get; set; }

        [JsonProperty("$type")]
        public string FluffyType { get; set; }

        [JsonProperty("geldendResultaat")]
        public string GeldendResultaat { get; set; }

        [JsonProperty("herkansingstype")]
        public string Herkansingstype { get; set; }

        [JsonProperty("isExamendossierResultaat")]
        public bool IsExamendossierResultaat { get; set; }

        [JsonProperty("isVoortgangsdossierResultaat")]
        public bool IsVoortgangsdossierResultaat { get; set; }

        [JsonProperty("leerjaar")]
        public long Leerjaar { get; set; }

        [JsonProperty("leerling")]
        public Leerling Leerling { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }

        [JsonProperty("omschrijving")]
        public string Omschrijving { get; set; }

        [JsonProperty("periode")]
        public long Periode { get; set; }

        [JsonProperty("permissions")]
        public Permission[] Permissions { get; set; }

        [JsonProperty("type")]
        public string PurpleType { get; set; }

        [JsonProperty("resultaat")]
        public string Resultaat { get; set; }

        [JsonProperty("teltNietmee")]
        public bool TeltNietmee { get; set; }

        [JsonProperty("toetsNietGemaakt")]
        public bool ToetsNietGemaakt { get; set; }

        [JsonProperty("vak")]
        public Vak Vak { get; set; }

        [JsonProperty("volgnummer")]
        public long? Volgnummer { get; set; }

        [JsonProperty("weging")]
        public long? Weging { get; set; }
    }

    public partial class Vak
    {
        [JsonProperty("additionalObjects")]
        public AdditionalObjects AdditionalObjects { get; set; }

        [JsonProperty("afkorting")]
        public string Afkorting { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }

        [JsonProperty("naam")]
        public string Naam { get; set; }

        [JsonProperty("permissions")]
        public Permission[] Permissions { get; set; }
    }

    public partial class Leerling
    {
        [JsonProperty("achternaam")]
        public string Achternaam { get; set; }

        [JsonProperty("additionalObjects")]
        public AdditionalObjects AdditionalObjects { get; set; }

        [JsonProperty("leerlingnummer")]
        public long Leerlingnummer { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }

        [JsonProperty("permissions")]
        public Permission[] Permissions { get; set; }

        [JsonProperty("roepnaam")]
        public string Roepnaam { get; set; }
    }

    public partial class Permission
    {
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("instances")]
        public string[] Instances { get; set; }

        [JsonProperty("operations")]
        public string[] Operations { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Link
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class AdditionalObjects
    {
    }

    public static class Serialize
    {
        public static string ToJson(this RootGrades self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}