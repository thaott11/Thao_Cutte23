﻿
using Du_An_1_Caffe.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_1_Caffe.DAL.Repstory
{
    public class HoaDonRep
    {
        DB_QuanLy_CaffeeContext db = new DB_QuanLy_CaffeeContext();

        // lấy ra tất cả hóa đơn
        public List<HoaDon> GetallHoaDon()
        {
            return db.HoaDons.ToList();
        }
        // lấy ra hóa đơn chi tiết
        public List<HoaDonChiTiet> GetAllHoadonChiTiet()
        {
            return db.HoaDonChiTiets.ToList();
        }
        // lấy ra tất cả nhân viên

        public List<NhanVien> GetAllNhanVien()
        {
            return db.NhanViens.ToList();
        }
        // lấy ra all sản phẩm 

        public List<SanPham> GetAllSanPham()
        {
            return db.SanPhams.ToList();
        }
        // lấy ra id san phẩm
        public List<SanPham> SeachSanPham(int id)
        {
            return db.SanPhams.Where(x => x.Id == id).ToList();
        }
        // update sản phẩm 
        public bool UpdateSanPham(SanPham sp)
        {
            var update = db.SanPhams.First(x => x.Id == sp.Id);
            update.SoLuong = sp.SoLuong;
            db.SanPhams.Update(update);
            db.SaveChanges();   
            return true;
        }

        // update trang thái hóa đơn
        public bool UpdateHoaDon(int id, HoaDon hd)
        {
            var update = db.HoaDons.First(x => x.IdHd == id);
            update.TrangThai = hd.TrangThai;
            db.HoaDons.Update(update);
            db.SaveChanges();
            return true;
        }

        // lấy ra id sản phẩm 
        public List<HoaDonChiTiet> Seachidsanpham(int id)
        {
            return db.HoaDonChiTiets.Where(x => x.IdSanPham == id).ToList();
        }
        // tìm kiếm theo mã 
        public List<HoaDon> SeachMaHoaDon(string ma)
        {
            return db.HoaDons.Where(x => x.MaHd == ma).ToList();
        }

        // tìm kiếm theo ngay
        public List<HoaDon> SeachNgayHoaDon(DateTime ngay)
        {
            return db.HoaDons.Where(x => x.NgayMuaHang == ngay).ToList();
        }

        // tìm kiếm theo trạng thái
        public List<HoaDon> SeachTrangThaiHoaDon(string trangthai)
        {
            return db.HoaDons.Where(x => x.TrangThai == trangthai).ToList();
        }

        public List<HoaDon> SeachNguoiTaoHoaDon(string NguoiTao)
        {
            return db.HoaDons.Where(x => x.NguoiTao == NguoiTao).ToList();
        }

        // thêm hóa đơn 
        public bool AddHoaDon(HoaDon hd)
        {
            db.HoaDons.Add(hd);
            db.SaveChanges();
            return true;
        }

        // lấy ra tất cả khách hàng

        public List<KhachHang> GetAllKhachHang()
        {
            return db.KhachHangs.ToList();
        }

        // xóa hóa đơn
        public bool RemoveHoaDon(int id, HoaDon dh)
        {
            var remove = db.HoaDons.First(x => x.IdHd == id);
            db.HoaDons.Remove(remove);
            db.SaveChanges();
            return true;
        }

        // thêm khách hàng
        public bool AddKhachHang(KhachHang kh)
        {
            db.KhachHangs.Add(kh);
            db.SaveChanges();
            return true;
        }

        // thêm hóa đơn chi tiết

        public bool AddHoaDonChiTiet(HoaDonChiTiet hdct)
        {
            db.HoaDonChiTiets.Add(hdct);
            db.SaveChanges();
            return true;
        }
    }
}
