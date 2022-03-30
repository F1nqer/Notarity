using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    //Модель клиентов, как доверители, доверенные, модель у них одна по факту
    public class ClientReq
    {
        //Айдишник
        public int ClientId { get; set; }
        //Тип клиента, список типов составим позже, сюда относятся типы: Доверитель - 0, Доверенный - 1
        public string ClientType { get; set; }
        //ИИНБИН
        public string IINBIN { get; set; }
        //ФИО
        public string LastName { get; set; }
        public string FirstName { get; set; }
        //Отчество
        public string Patronymic { get; set; }
        //Дата рождения
        public DateTime BirthDate { get; set; }
        //Место рождения
        public AddressReq BirthAddress { get; set; }
        //Место проживания
        public AddressReq HomeAddress { get; set; }
    }
}
