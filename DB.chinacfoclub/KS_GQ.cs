using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_GQ
    /// </summary>
    public class KS_GQ 
    {
        public int? ID { get; set; }
        public string Tid { get; set; }
        public string Title { get; set; }
        public string KeyWords { get; set; }
        public string Price { get; set; }
        public int? TypeID { get; set; }
        public int? ValidDate { get; set; }
        public string GQContent { get; set; }
        public string PhotoUrl { get; set; }
        public int? Hits { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string TemplateID { get; set; }
        public string Fname { get; set; }
        public Byte? Recommend { get; set; }
        public Byte? Verific { get; set; }
        public int? IsTop { get; set; }
        public Byte? RefreshTF { get; set; }
        public string ContactMan { get; set; }
        public string Tel { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Zip { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Homepage { get; set; }
        public Byte? DelTF { get; set; }
        public int? HitsByDay { get; set; }
        public int? HitsByWeek { get; set; }
        public int? HitsByMonth { get; set; }
        public DateTime? LastHitsTime { get; set; }
        public Byte? strip { get; set; }
        public Byte? Popular { get; set; }
        public Byte? Slide { get; set; }
        public Byte? Rolls { get; set; }
        public Byte? Comment { get; set; }
        public string Inputer { get; set; }
        public string SEOTitle { get; set; }
        public string SEOKeyWord { get; set; }
        public string SEODescript { get; set; }
    }
}
