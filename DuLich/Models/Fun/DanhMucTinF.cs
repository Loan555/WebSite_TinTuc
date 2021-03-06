﻿using DuLich.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuLich.Models.Fun
{
    public class DanhMucTinF
    {
        WebDuLich db = null;
        public DanhMucTinF()
        {
            db = new WebDuLich();
        }
        public List<BanTin> ListAll()
        {
            return db.BanTins.ToList();
        }
        public List<BanTin> DMTin(long id)
        {
            var danhmuctin = db.DanhMucs.Find(id);
            return db.BanTins.Where(x => x.IDDanhMuc == danhmuctin.IDDanhMuc).ToList();
        }     
        public BanTin ChiTietTin (long id)
        {
            var tin = db.BanTins.Find(id);
            return db.BanTins.Single(x => x.IDBanTin == tin.IDBanTin);
        }
        public List<BanTin> TimKiem(string Search)
        {
            return db.BanTins.Where(x => x.DanhMuc.TenDanhMuc.Contains(Search) || x.TieuDe.Contains(Search) || x.ViTri.Contains(Search)).ToList();
        }
        public List<BanTin> TinHot(int top)
        {
            return db.BanTins.OrderByDescending(x => x.SoLuotXem).Take(top).ToList();
        }
        public List<BanTin> VN (int top) 
        {
            return db.BanTins.Take(top).ToList();
        }
        public List<BanTin> ListDiaDiemHot(int top)
        {         
            return db.BanTins.Take(top).ToList();
        }
        public List<BanTin> TinMoi(int top)
        {
            return db.BanTins.OrderByDescending(x => x.IDBanTin).Take(top).ToList();
        }
    }
}