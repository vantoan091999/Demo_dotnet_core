namespace Demo_Net2.Models;
{
    public class GiaiPhuongTrinh{
        //phuong thuc giai phuong trinh bac nhat
        public string GiaiPhuongTrinhBacNhat(string heSoA, string heSoB){
            double a, b, x;
           
            a = Convert.ToDouble(heSoA);
            b = Convert.ToDouble(heSoB);
            if (a == 0)
            {
                if (b != 0)
                {
                    ThongBao = 'phuong trinh vo nghiem';
                } else {
                    ThongBao = 'phuong trinh vo so nghiem';
                }
                
            }else {
                x = -b/a;
                ThongBao = 'phuong trinh co nghiem: ' + x;
            }
            return ThongBao;
        }
    }
}