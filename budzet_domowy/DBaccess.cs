using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budzet_domowy
{
    public class DBaccess
    {
        static DataClasses2DataContext db = new DataClasses2DataContext();

        public static IEnumerable<GetOperationWithCategoryDTO> GetOperationWithCategory()
        {

            return from o in db.operacje
                   join category in db.kategoria on o.id_kategoria equals category.id_kategoria
                   select new GetOperationWithCategoryDTO()
                   {
                       Id = category.id_kategoria,
                       Nazwa = category.nazwa,
                       Id_nad = category.id_nadkategoria,
                       Typ = category.typ,
                       Kwota = o.kwota,
                       Data = o.data,
                       UserId = o.id_uzytkownika,
                   };
        }
        public static IEnumerable<GetOperationWithCategoryDTO> GetOperationWithCategory(List<DateTime> chk_daty, List<string> chk_kategorie, List<int> chk_uzytkownicy)
        {

            return from o in db.operacje
                join k_pod in db.kategoria on o.id_kategoria equals k_pod.id_kategoria
                where chk_kategorie.Contains(k_pod.nazwa)
                      && chk_daty.Contains(o.data.Date)
                      && chk_uzytkownicy.Contains(o.id_uzytkownika)
                   select new GetOperationWithCategoryDTO()
                {
                    Id = k_pod.id_kategoria,
                    Nazwa = k_pod.nazwa,
                    Id_nad = k_pod.id_nadkategoria,
                    Typ = k_pod.kategoria1.typ,
                    Kwota = o.kwota,
                    Data = o.data,
                    UserId = o.id_uzytkownika,
                };

        }

        public static IEnumerable<OperationDto> GetOperationToList()
        {
            return from o in db.operacje
                   join u in db.uzytkownicy on o.id_uzytkownika equals u.id_uzytkownika
                   join fp in db.forma_platnosci on o.id_forma_platnosci equals fp.id_forma_platnosci
                   join k_nad in db.kategoria on o.id_kategoria equals k_nad.id_kategoria
                   join k_pod in db.kategoria on o.id_kategoria equals k_pod.id_kategoria
                   //join k_pod in db.kategoria on o.id_kategoria equals k_pod.id_nadkategoria

                   select new OperationDto
                   {
                       Id = o.id_operacji,
                       Data = o.data,
                       Category = k_nad.id_nadkategoria == null ? k_nad.nazwa : null,

                       Podcategory = null, // k_pod.id_nadkategoria == k_nad.id_nadkategoria ? null : k_pod.nazwa,

                       Price = o.kwota,
                       Description = o.opis,
                       PaymentForm = fp.nazwa,
                       Type = k_nad.typ,
                       UserId = u.id_uzytkownika,
                       Name = u.imie,
                       Surname = u.nazwisko,
                   };
        }

        public static IEnumerable<OperationDto> GetOperationToList(List<DateTime> chk_daty, List<string> chk_kategorie, List<int> chk_uzytkownicy)
        {

            return from o in db.operacje
                join u in db.uzytkownicy on o.id_uzytkownika equals u.id_uzytkownika
                join fp in db.forma_platnosci on o.id_forma_platnosci equals fp.id_forma_platnosci
                join k_pod in db.kategoria on o.id_kategoria equals k_pod.id_kategoria
                join k_nad in db.kategoria on k_pod.id_nadkategoria equals k_nad.id_kategoria
                where chk_kategorie.Contains(k_pod.nazwa)
                      && chk_daty.Contains(o.data.Date)
                      && chk_uzytkownicy.Contains(o.id_uzytkownika)
                   select new OperationDto
                {
                    Id = o.id_operacji,
                    Data = o.data,
                    //CategoryId = k_nad.id_kategoria,
                    Category = k_nad.nazwa,
                    //Podcategory = k_pod.typ == null && k_pod.id_nadkategoria == k_nad.id_kategoria ? k_nad.nazwa : null,
                    Podcategory = k_pod.nazwa,
                    Price = o.kwota,
                    Description = o.opis,
                    PaymentForm = fp.nazwa,
                    Type = k_nad.typ,
                    UserId = u.id_uzytkownika,
                    Name = u.imie,
                    Surname = u.nazwisko,
                };

        }
    }
}
