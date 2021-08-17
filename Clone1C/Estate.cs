using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone1C
{
    //класс имущества
    class Estate
    {
        public int Id { get; set; }
        public string NameEstate { get; set; }
        // Балансовая стоимтость
        public string BookValue { get; set; }
        // Сумма амортизации
        public string AmountOfDepreciation { get; set; }
        // Дата ввода в эксплуатацию
        public DateTime CommissioningDate { get; set; }
        // Дата принятия к учету
        public DateTime DateOfAcceptanceForRegistration { get; set; }
        // Дата списания
        public DateTime WriteOffDate { get; set; }
        // Дата сведений
        public DateTime DateOfInformation { get; set; }
        // id отдела
        public int DepartmentId { get; set; }
        // id ответственного
        public int ResponsibleId { get; set; }
    }
}
