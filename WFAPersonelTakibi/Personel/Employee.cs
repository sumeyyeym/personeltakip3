using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPersonelTakibi.Personel
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public Department Department { get; set; }
        public string ImgURL { get; set; }
    }

    public enum Gender { Male, Female, Random }
    public enum Department { Finans, İK, Hukuk, Pazarlama, Satış, ARGE, Operasyon, Yönetim, GenelSekreterlik };
}
