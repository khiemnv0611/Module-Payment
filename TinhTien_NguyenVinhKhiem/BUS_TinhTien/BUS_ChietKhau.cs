using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_TinhTien;
using DTO_TinhTien;

namespace BUS_TinhTien
{
    public class BUS_ChietKhau
    {
        DAL_ChietKhau dalChietKhau = new DAL_ChietKhau();
        public DataTable getChietKhau()
        {
            return dalChietKhau.getChietKhau();
        }
        public bool themChietKhau(DTO_ChietKhau ck)
        {
            return dalChietKhau.themChietKhau(ck);
        }
        public bool suaChietKhau(DTO_ChietKhau ck)
        {
            return dalChietKhau.suaChietKhau(ck);
        }
        public bool xoaChietKhau(int maChietKhau)
        {
            return dalChietKhau.xoaChietKhau(maChietKhau);
        }
    }
}
