using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.function
{
    public class MemberDB : Imembers
    {
        HmoDbContext db;
       public MemberDB(HmoDbContext _db)
        { 
            db = _db;
        }
        public int AddMemberDB(MemberHmo member)
        {
           db.MemberHmos.Add(member);
            db.SaveChanges();
            return member.MbrCode;
        }

        public bool DeleteMemberDB(int id_mem)
        {
            MemberHmo memberToDel = db.MemberHmos.FirstOrDefault(x => x.MbrCode == id_mem);
            if (memberToDel == null)
            {
                return false;
            }
            db.MemberHmos.Remove(memberToDel);
            db.SaveChanges();
            return true;
        }

        public List<MemberHmo> GetAllMemberDB()
        {
            return db.MemberHmos.ToList();
        }

        public bool UpdateMemberDB(MemberHmo member)
        {
            MemberHmo memberToEdit = db.MemberHmos.FirstOrDefault(x => x.MbrCode == id_mem);
            if (memberToEdit == null)
            {
                return false;
            }
            memberToEdit.MbrFirstName = member.MbrFirstName;
            memberToEdit.MbrLastName = member.MbrLastName;
            memberToEdit.MbrCity = member.MbrCity;
            memberToEdit.MbrStreet = member.MbrStreet;
            memberToEdit.MbrNumStreet = member.MbrNumStreet;
            memberToEdit.MbrPhon= member.MbrPhon;
            memberToEdit.MbrTel = member.MbrTel;
            memberToEdit.MbrBirthDate = member.MbrBirthDate;
            memberToEdit.MbrPatient = member.MbrPatient;
            memberToEdit.VaccinatedMbrs = member.VaccinatedMbrs;
            db.SaveChanges();
            return true;
        }
    }
}
