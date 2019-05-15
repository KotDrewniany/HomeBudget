using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budzet_domowy
{
    public class GetOperationWithCategoryDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string FullName => Name + " " + Surname;

        public string Nazwa { get; set; }

        public int? Id_nad { get; set; }

        public string Typ { get; set; }

        public decimal Kwota { get; set; }

        public DateTime Data { get; set; }
    }
}
