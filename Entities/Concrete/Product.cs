using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Product:IEntity//Diğer katmanların bu class a ulaşabilmesi için public yaptık,internal ise default eişim belirleyicisidir ,sadece Entities erişebilir demektir
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }//small int,Northwith de small int olarak tutulur buradaki karşılığı shorttur
        public decimal UnitPrice { get; set; }
    }
}
