using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository;
using DAL.Models;

namespace DAL.Repoistory
{
    public class PhieutraCTRepos:IPhieuTraCTRepos
    {
        QLTHUVIENContext _context= new QLTHUVIENContext();
        public PhieutraCTRepos()
        {

        }
        public PhieutraCTRepos(QLTHUVIENContext context)
        {
            _context = context;
        }
        public bool AddHoaDonCT(string id, Phieutract ct)
        {
            _context.Phieutracts.Add(ct);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteCT(int id)
        {
            var a = _context.Phieutracts.FirstOrDefault(x => x.Matract == id);
            if (a != null)
            {
                _context.Phieutracts.Remove(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Phieutract> GetAll()
        {
            return _context.Phieutracts.ToList();
        }

        public List<Phieutract> GetByPhieutraCT(string id)
        {
            return _context.Phieutracts.Where(x => x.Matra == id).ToList();
        }

        public bool UpdateCT(int id, Phieutract ct)
        {
            var a = _context.Phieutracts.FirstOrDefault(x => x.Matract == id);
            if (a != null)
            {
                a.Masach = ct.Masach;
                a.Soluong = ct.Soluong;
                a.Ngaymuon = ct.Ngaymuon;
                a.Ngaytra = ct.Ngaytra;
                _context.Phieutracts.Remove(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
