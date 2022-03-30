using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    //Модель подробного адреса для клиентов и договоров
    public class AddressReq
    {
        //Область, регион
        public string Territory { get; set; }
        //Город
        public string City { get; set; }
        //Улица
        public string Street { get; set; }
        //Номер дома
        public string HomeNum { get; set; }
        //Дополнительная информация в виде номера квартиры, подьезда и т.д.
        public string AddInfo { get; set; }
    }
}
