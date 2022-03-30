using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class DocumentReq
    {
        //Идентификатор документа, указывается в правом нижнем углу печатной формы
        public int DocumentId { get; set; }
        //Номер документа
        public int Number { get; set; }
        //Дата заключения/создания
        public DateTime DocDate { get; set; }
        //Дата начала действия
        public DateTime DateBegin { get; set; }
        //Дата окончания действия
        public DateTime DateEnd { get; set; }
        //Область/регион в котором документ стал активен
        public string DocTerritory { get; set; }
        //Основное действие (представлять мои интересы, водить моё авто, предъявлять мои документы, получить наследство)
        //Действия и описание переработаем, как разделим на типы и логику
        public string ActionTitle { get; set; }
        //Более подробное описание действия, что куда и как
        public string ActionDescription { get; set; }
        //Сотрудник(Нотариус) который этим документом управляет
        public EmployeeReq Employee { get; set; }
        //Главная персона, которая задаёт основные правила (инициатор) в нашем случае - доверитель
        public ClientReq MajorPerson { get; set; }
        //Второстепенная персона, которая что-то получает, или просто вторая сторона, в нашем случае - доверенный
        public ClientReq MinorPerson { get; set; }
        //Тип документа (Доверенность, Договор о покупке и т.д.) Доверенность - trust 
        public string Type { get; set; }
        //Подтип (Доверенность на документы и т.д.)
        public string SubType { get; set; }
    }
}
