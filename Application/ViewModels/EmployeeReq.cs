using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class EmployeeReq
    {
        //Покамись кидай рандомы на айди       
        public int EmployeeId { get; set; }
        // ФИО
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Отчество
        public string Patronymic { get; set; }
        //Роль, покамись кидаем "Notarity"
        public string RoleCode { get; set; }
        //Область/регион в котором работает сотрудник
        public string Territory { get; set; }
        //Дата лицензии
        public DateTime LicenseDate { get; set; }
        //Номер лицензии
        public string LicenseNumber { get; set; }
    }
}
