using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace TestVisitor
{
    public class SearchBogi : IBogi
    {
        readonly IDictionary<int, Coach> dictBogies = new Dictionary<int, Coach>() {
                { 1, new Coach() { BogiNumber=1,SitNumber=1,SitSide="L" , Status="Open", Cstruture = new CoachStructure() { NumberofSeats=64 }  } },
                 { 2, new Coach() { BogiNumber=1,SitNumber=2,SitSide="M" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=64 }} },
                  { 3, new Coach() { BogiNumber=1,SitNumber=3,SitSide="U" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=64 }} },
                    { 4, new Coach() { BogiNumber=1,SitNumber=4,SitSide="SL" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=64 }} },
                 { 5, new Coach() { BogiNumber=1,SitNumber=5,SitSide="SU" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=64 }} },
                  { 6, new Coach() { BogiNumber=1,SitNumber=6,SitSide="L" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=64 }} },
                    { 7, new Coach() { BogiNumber=1,SitNumber=7,SitSide="M" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=64 }} },
                 { 8, new Coach() { BogiNumber=1,SitNumber=8,SitSide="U" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=64 }} },
                  { 9, new Coach() { BogiNumber=1,SitNumber=9,SitSide="SL" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=64 }} },
                    { 10, new Coach() { BogiNumber=1,SitNumber=10,SitSide="SU" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=64 }} },
                 { 11, new Coach() { BogiNumber=1,SitNumber=11,SitSide="L" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=72 }} },
                  { 12, new Coach() { BogiNumber=1,SitNumber=12,SitSide="U" , Status="Open", Cstruture = new CoachStructure() { NumberofSeats=72 }} },
                    { 13, new Coach() { BogiNumber=2,SitNumber=1,SitSide="L" , Status="Open", Cstruture = new CoachStructure() { NumberofSeats=72 }  } },
                 { 14, new Coach() { BogiNumber=2,SitNumber=2,SitSide="M" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=72 }} },
                  { 15, new Coach() { BogiNumber=2,SitNumber=3,SitSide="U" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=72 }} },
                    { 16, new Coach() { BogiNumber=2,SitNumber=4,SitSide="SL" , Status="Open" , Cstruture = new CoachStructure() { NumberofSeats=72 }} }
            };

        public Dictionary<int, Coach> BogiList(string side)
        {
            var searchDict = new Dictionary<int, Coach>();
            foreach (var bogi in dictBogies)
            {
                if (bogi.Value.SitSide == side && bogi.Value.Status == "Open")
                {
                    searchDict.Add(bogi.Key, bogi.Value);
                }

            }
            return searchDict;
        }

        public string BogiSitSide(int sitNumber, int bogyType)
        {
            var filter = dictBogies.Where(x => x.Value.Cstruture.NumberofSeats.Equals(bogyType));
            foreach (var bogi in filter)
            {
                if (bogi.Value.SitNumber == sitNumber )
                {
                    return bogi.Value.SitSide;
                }

            }
            return null;
        }
    }
}
