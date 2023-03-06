using KiemTra6_3.Models;

namespace KiemTra6_3.Repository
{
    public class CLoaiSpRepository : ILoaiSpRepository
    {
        private readonly QlbanVaLiContext _context; 
        public CLoaiSpRepository(QlbanVaLiContext context)
        {
            _context = context;
        }

        public THangSx Add(THangSx HangSx)
        {
            _context.THangSxes.Add(HangSx);
            _context.SaveChanges();
            return HangSx;
        }

        public THangSx Delete(string MaHangSx)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<THangSx> GetAllLoaiSp()
        {
            return _context.THangSxes;
        }

        public THangSx GetLoaiSp(string MaHangSx)
        {
            return _context.THangSxes.Find(MaHangSx);
        }

        public THangSx Update(THangSx HangSx)
        {
            _context.Update(HangSx);
            _context.SaveChanges();
            return HangSx;
        }
    }
}
