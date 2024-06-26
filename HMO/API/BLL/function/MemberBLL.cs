﻿using AutoMapper;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DAL.Models.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.function
{
    public class MemberBLL : ImemberBLL
    {
        Imembers membersDb;
  
        IMapper m;
        public MemberBLL(Imembers membersDb)
        {
            
            this.membersDb = membersDb;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.Mapper>();
            });
            m = config.CreateMapper();
        
        }
        public int AddMemberBll(MemberDTO member)
        {
            return membersDb.AddMemberDB(m.Map<MemberDTO, MemberHmo>(member));
        }

        public bool DeleteMemberBll(int id_mem)
        {
            return membersDb.DeleteMemberDB(id_mem);
        }

        public List<MemberDTO> GetAllMemberBll()
        {
            return m.Map<List<MemberHmo>, List<MemberDTO>>(membersDb.GetAllMemberDB());
        }

        public bool UpdateMemberBll(MemberDTO member)
        {
            return membersDb.UpdateMemberDB(m.Map<MemberDTO, MemberHmo>(member));
        }
        //public List<VaccinatedMbrDto> GetAllVaccinatedMbr(int id)
        //{
        //    //List<VaccinatedMbr> list = new List<VaccinatedMbr>();
        //    //MemberHmo mem= membersDb.GetById(id);
        //    //list= vaccintedMbrDb.GetAllVaccintedMbrDB().Where(x=> x.MbrCode==mem.MbrCode).ToList();
        //    ////foreach (VaccinatedMbr item in mem.VaccinatedMbrs.ToList())
        //    ////{
        //    ////    if(item.VmMbrCode==id)
        //    ////        list.Add(item);
        //    ////}
        //    ////mem.VaccinatedMbrs.ToList().ForEach(x => { list.Add(x); });
        //    //return m.Map<List<VaccinatedMbr>, List<VaccinatedMbrDto>>(list);
        //    List<VaccinatedMbrDto> list = new List<VaccinatedMbrDto>();
        //    foreach (var item in m.Map<List<VaccinatedMbr>, List<VaccinatedMbrDto>>(vaccMbrDb.GetAllVaccintedMbrDB()))
        //    {
        //        if (item.MbrCode==id)
        //            list.Add(item);
        //    }
        //    return list;
        //}
    }
}
