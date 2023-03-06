using KiemTra6_3.Models;
namespace KiemTra6_3.Repository
{
    public interface ILoaiSpRepository
    {
        THangSx Add(THangSx HangSx);
        THangSx Update(THangSx HangSx);
        THangSx Delete(String MaHangSx);
        THangSx GetLoaiSp(String MaHangSx);

        IEnumerable<THangSx> GetAllLoaiSp();
    }
}
