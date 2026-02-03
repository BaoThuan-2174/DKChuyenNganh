using DkiChuyenNganh.Models;
using Microsoft.AspNetCore.Mvc;

namespace DkiChuyenNganh.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> RegisterStudents = new List<Student>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowKQ(Student student)
        {
            //Thêm sinh viên vào danh sách đăng ký
            RegisterStudents.Add(student);

            //Đếm số lượng sinh viên đăng ký cùng chuyên ngành
            int sameMaforCount = RegisterStudents.FindAll(s => s.ChuyenNganh == student.ChuyenNganh).Count;

            //Truyền dữ liệu sang View
            ViewBag.MSSV = student.MSSV;
            ViewBag.HoTen = student.HoTen;
            ViewBag.ChuyenNganh = student.ChuyenNganh;
            ViewBag.sameMaforCount = sameMaforCount;

            return View();
        }
    }
}
