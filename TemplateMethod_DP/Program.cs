using System;

namespace TemplateMethod_DP
{
    //-Template method
    //  +Định nghĩa ra một bộ khung (template)
    //  +Cho phép lớp con định nghĩa lại cách thực hiện của thuật toán, mà không phải thay đổi cấu truc của thuật toán  
    //-Lợi ích
    //  + Tái sử dụng,trách trùng code, đưa phần trùng vào lớp cha
    //  + Cho phép người dùng override chỉ một số thành phần 
    //-Sử dụng khi: 
    //  + Muốn triển khai duy nhất 1 phương thức trừu tượng duy nhất
    //  + Mong muốn xử lý ở các lớp con được đặt ở một lớp chung 
    public abstract class WebTemplate
    {
        static void ShowHeader()
        {
            Console.WriteLine("-------Header-------");
        }
        static void ShowNav()
        {
            Console.WriteLine("-------Nav-------");
        }
        static void ShowFooter()
        {
            Console.WriteLine("-------Footer-------");
        }

        protected abstract void ShowBody();
        
        public void ShowWeb()
        {
            ShowHeader();
            ShowNav();
            ShowBody();
            ShowFooter();
        }
    }
    public class HomePage : WebTemplate
    {
        protected override void ShowBody()
        {
            Console.WriteLine("Content home page ");
            Console.WriteLine("abc ");
        }
    }
    public class DetailPage : WebTemplate
    {
        protected override void ShowBody()
        {
            Console.WriteLine("Content detail  ");
            Console.WriteLine("xyz ");
        }
    }
    public class ContactPage : WebTemplate
    {
        protected override void ShowBody()
        {
            Console.WriteLine("Content contact page ");
            Console.WriteLine("0123456 ");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            WebTemplate homepage = new HomePage();
            homepage.ShowWeb();
            Console.WriteLine("---------------------------------------------------------------");
            WebTemplate detailpage = new DetailPage();
            detailpage.ShowWeb();
            Console.WriteLine("---------------------------------------------------------------");
            WebTemplate contactpage = new ContactPage();
            contactpage.ShowWeb();
        }
    }
}
