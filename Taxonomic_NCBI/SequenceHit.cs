using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomic_NCBI
{
    struct NameHit
    {
        public string Name;
        public double Hit;
        public string HitString;
    }
    internal class SequenceHit
    {
        private string id = "";
        private List<NameHit> hits = new List<NameHit>(); 
        
        private bool higher = true;
        bool filterByHitQuality;
        bool filterByList;
        public SequenceHit(string Name, string SpeciesName, double Value, string valueString, bool Higher, bool FilterByHitQuality, bool FilterByList)
        {
            id = Name;
            NameHit nh= new NameHit();
            nh.Name = SpeciesName;
            nh.Hit = Value;
            nh.HitString = valueString;
            hits.Add(nh);
            
            higher = Higher;
            filterByHitQuality = FilterByHitQuality; 
            filterByList = FilterByList;
        }

        public void AddnewHit(string SpeciesName, double Value, string valueString)
        {
            NameHit nh = new NameHit();
            nh.Name = SpeciesName;
            nh.Hit = Value;
            nh.HitString = valueString;
            hits.Add(nh);
        }

        public void SortData()
        {
            if (higher == false)
            { hits.Sort((a, b) => a.Hit.CompareTo(b.Hit)); }
            else
            { hits.Sort((a, b) => b.Hit.CompareTo(a.Hit)); }
        }

        public string FirstName()
      { return hits[0].Name; }

        public List<NameHit> Data { get { return hits; } }

        public string ID { get { return id; } }
    }
}
