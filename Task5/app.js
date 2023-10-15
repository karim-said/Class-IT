class Reader {
  constructor(fullName, cardNumber, faculty, birthDate, phoneNumber) {
    this.fullName = fullName;
    this.cardNumber = cardNumber;
    this.faculty = faculty;
    this.birthDate = birthDate;
    this.phoneNumber = phoneNumber;
  }

  takeBooksByCount(bookCount) {
    console.log(`${this.fullName} взял ${bookCount} книги`);
  }

  takeBooksByNames(...bookNames) {
    console.log(`${this.fullName} взял книги: ${bookNames.join(", ")}`);
  }

  takeBooksByObjects(...books) {
    const bookTitles = books.map((book) => {
      if (book instanceof Book) {
        return `${book.title} ${book.author}`;
      }
      return "";
    });
    console.log(`${this.fullName} взял книги: ${bookTitles.join(", ")}`);
  }

  returnBooksByCount(bookCount) {
    console.log(`${this.fullName} вернул ${bookCount} книги`);
  }

  returnBooksByNames(...bookNames) {
    console.log(`${this.fullName} вернул книги: ${bookNames.join(", ")}`);
  }

  returnBooksByObjects(...books) {
    const bookTitles = books.map((book) => {
      if (book instanceof Book) {
        return `${book.title} ${book.author}`;
      }
      return "";
    });
    console.log(`${this.fullName} вернул книги: ${bookTitles.join(", ")}`);
  }
}

class Book {
  constructor(title, author) {
    this.title = title;
    this.author = author;
  }
}

const reader1 = new Reader(
  "Каримзода Ардамехр",
  123456,
  "ТИК",
  "10.10.2002",
  "000331000"
);
const reader2 = new Reader(
  "Давлятов Фарход Дилшодович",
  654321,
  "ТИК",
  "20.02.2001",
  "917163390"
);
const reader3 = new Reader(
  "Ахматов Абдусаттор Абдумаликович",
  765432,
  "ТИК",
  "12.06.2003",
  "917733743"
);

const book1 = new Book("Приключения:", "Иванов Иван");
const book2 = new Book("Словарь:", "Петров Петр");
const book3 = new Book("Энциклопедия:", "Сидоров Сидор");

reader1.takeBooksByCount(3);
reader1.takeBooksByNames("Приключения", "Словарь", "Энциклопедия");
reader1.takeBooksByObjects(book1, book2, book3);

reader2.returnBooksByCount(2);
reader2.returnBooksByNames("Приключения", "Словарь");
reader2.returnBooksByObjects(book1, book2);

reader3.returnBooksByCount(1);
reader3.returnBooksByNames("Словарь");
reader3.returnBooksByObjects(book2);
