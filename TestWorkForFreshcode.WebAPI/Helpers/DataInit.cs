using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWorkForFreshcode.WebAPI.Contexts;
using TestWorkForFreshcode.WebAPI.Models;

namespace TestWorkForFreshcode.WebAPI.Helpers
{
    public static class DataInit
    {
        //Инициализация базы данных
        public static void Initialize(LibraryContext context)
        {
            //Добавляем авторов, если их нет.
            if (!context.Authors.Any())
            {
                Author BernardShow = new Author
                {
                    Name = "Джордж",
                    Surname = "Бернард Шоу"
                };
                Author Kleyson = new Author
                {
                    Name = "Джордж",
                    Surname = "Клейсон"
                    };
                Author Menson = new Author
                {
                    Name = "Марк",
                    Surname = "Мэнсон"
                };
                Author Carnegy = new Author
                {
                    Name = "Дейл",
                    Surname = "Карнеги"
                };
                Author Orvel = new Author
                {
                    Name = "Джордж ",
                    Surname = "Орвел"
                };
                Author Hill = new Author
                {
                    Name = "Наполеон",
                    Surname = "Хилл"
                };
                Author Joanne = new Author
                {
                    Name = "Джоан",
                    Surname = "Кэтлин Роулинг"
                };

                context.Authors.AddRange(
                    BernardShow,
                    Kleyson,
                    Menson,
                    Carnegy,
                    Orvel,
                    Hill,
                    Joanne
                );
                context.SaveChanges();

                //Добавляем книги, если их нет.
                if (!context.Books.Any())
                {
                    Book Vavilon = new Book
                    {
                        Name = "Сфмый богатый человек в Вавилоне",
                        PageCount = 134,
                        Published = DateTime.Parse("01.01.2001"),
                        Language = "Руский",
                        Redaction = "Рипол Классик",
                        AuthorId = Kleyson.Id
                    };
                    Book Pofigizm = new Book
                    {
                        Name = "Тонкое искуство пофогизма",
                        PageCount = 189,
                        Published = DateTime.Parse("02.02.2002"),
                        Language = "Руский",
                        Redaction = "Аьпина Паблишер",
                        AuthorId = Menson.Id
                    };
                    Book Pigmalion = new Book
                    {
                        Name = "Пігмаліон",
                        PageCount = 156,
                        Published = DateTime.Parse("03.03.2003"),
                        Language = "Український",
                        Redaction = "Букшеф",
                        AuthorId = BernardShow.Id
                    };
                    Book Life = new Book
                    {
                        Name = "Как перестать беспоиться и начать жыть",
                        PageCount = 413,
                        Published = DateTime.Parse("14.09.2014"),
                        Language = "Руский",
                        Redaction = "Поппури",
                        AuthorId = Carnegy.Id
                    };
                    Book One984 = new Book
                    {
                        Name = "1984",
                        PageCount = 366,
                        Published = DateTime.Parse("15.10.2015"),
                        Language = "Український",
                        Redaction = "Букшеф",
                        AuthorId = Orvel.Id
                    };
                    Book Dumay = new Book
                    {
                        Name = "Думай и богатей",
                        PageCount = 378,
                        Published = DateTime.Parse("16.11.2016"),
                        Language = "Руский",
                        Redaction = "Поппури",
                        AuthorId = Hill.Id
                    };
                    Book Harry1 = new Book
                    {
                        Name = "Гаррі поттер і філософський камінь",
                        PageCount = 123,
                        Published = DateTime.Parse("07.07.2007"),
                        Language = "Український",
                        Redaction = "Абабагаламага",
                        AuthorId = Joanne.Id
                    };
                    Book Harry2 = new Book
                    {
                        Name = "Гаррі поттер і таємна кімната",
                        PageCount = 123,
                        Published = DateTime.Parse("07.07.2007"),
                        Language = "Український",
                        Redaction = "Абабагаламага",
                        AuthorId = Joanne.Id
                    };
                    Book Harry3 = new Book
                    {
                        Name = "Гаррі поттер і вязень аскабана",
                        PageCount = 123,
                        Published = DateTime.Parse("07.07.2007"),
                        Language = "Український",
                        Redaction = "Абабагаламага",
                        AuthorId = Joanne.Id
                    };

                    context.Books.AddRange(
                        Vavilon,
                        Pofigizm,
                        Pigmalion,
                        Life,
                        One984,
                        Dumay,
                        Harry1,
                        Harry2,
                        Harry3
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
