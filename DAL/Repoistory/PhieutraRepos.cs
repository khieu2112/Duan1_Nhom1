using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository;
using DAL.Models;

namespace DAL.Repoistory
{
    public class PhieutraRepos: IPhieuTraRepos
    {
        QLTHUVIENContext _context= new QLTHUVIENContext();
        public PhieutraRepos()
        {

        }
        public PhieutraRepos(QLTHUVIENContext context)
        {
            _context = context;
        }
        public bool AddHoaDon(Phieutra pm)
        {
            _context.Phieutras.Add(pm);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteHoaDon(string id)
        {
            var a = _context.Phieutras.FirstOrDefault(x => x.Matra == id);
            var b = _context.Phieutracts.FirstOrDefault(x => x.Matra == id);
            if (a != null)
            {
                if (b != null)
                {
                    _context.Phieutras.Remove(a);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    _context.Phieutracts.RemoveRange(b);
                    _context.Phieutras.Remove(a);
                    _context.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public List<Phieutra> GetAllPhieutra()
        {
            return _context.Phieutras.ToList();
        }

        public List<Phieutra> GetByIDPhieutra(string id)
        {
            return _context.Phieutras.Where(x => x.Matra == id).ToList();
        }

        public bool UpdateHoaDon(string id, Phieutra ct)
        {
            var a = _context.Phieutras.FirstOrDefault(x => x.Matra == id);
            if (a != null)
            {
                a.Tenkh = ct.Tenkh;
                a.Cccd = ct.Cccd;
                _context.Phieutras.Update(a);
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
