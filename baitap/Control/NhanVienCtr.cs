﻿using baitap.Model;
using baitap.Object;
using System;
using System.Data;

namespace baitap.Control
{
    internal class NhanVienCtr
    {
        NhanVienMod nvMod = new NhanVienMod();
        public string ErrorMessage { get; private set; }

        public DataTable GetData()
        {
            try
            {
                return nvMod.LayDuLieuNhanVien();
            }
            catch (Exception ex)
            {
                ErrorMessage = "Lỗi khi lấy dữ liệu: " + ex.Message;
                return null;
            }
        }

        public bool AddData(NhanvienObj nvobj)
        {
            try
            {
                return nvMod.ThemDuLieuNhanVien(nvobj);
            }
            catch (Exception ex)
            {
                ErrorMessage = "Lỗi khi thêm dữ liệu: " + ex.Message;
                return false;
            }
        }

        public bool DelData(string id)
        {
            try
            {
                return nvMod.XoaDuLieuNhanVien(id);
            }
            catch (Exception ex)
            {
                ErrorMessage = "Lỗi khi xóa dữ liệu: " + ex.Message;
                return false;
            }
        }
    }
}