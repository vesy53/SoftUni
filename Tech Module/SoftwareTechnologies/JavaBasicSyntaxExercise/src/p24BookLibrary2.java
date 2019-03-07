import java.awt.print.Book;
import java.util.ArrayList;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.*;
import java.util.stream.Collectors;

public class p24BookLibrary2 {
    public static void main(String[] args) {
        ArrayList<Book> books = getBooks();
        Map<String, Double> salesByAuthor = calcSalesByAuthor(books);
        List<String> orderedAuthors = salesByAuthor.entrySet().stream().sorted((Map.Entry<String, Double> o1, Map.Entry<String, Double> o2) -> {
            return o1.getValue().equals(o2.getValue()) ?
                    o1.getKey().compareTo(o2.getKey())
                    : o2.getValue().compareTo(o1.getValue());

        }).map(e -> e.getKey()).collect(Collectors.toList());

        printSalesByAuthorOrdered(orderedAuthors, salesByAuthor);
    }

    private static void printSalesByAuthorOrdered(List<String> authors, Map<String, Double> salesByAuthor)
    {
        for (String author : authors) {
            System.out.printf("%s -> %.2f\n", author, salesByAuthor.get(author));
        }
    }

    private static  Map<String, Double> calcSalesByAuthor(ArrayList<Book> books)
    {
        Map<String, Double> salesByAuthor = new HashMap<>();

        for (Book book : books)
        {
            if (!salesByAuthor.containsKey(book.author))
                salesByAuthor.put(book.author, 0d);

            salesByAuthor.put(book.author, salesByAuthor.get(book.author) + book.price);
        }

        return salesByAuthor;
    }

    private static ArrayList<Book> getBooks()
    {
        Scanner input = new Scanner(System.in);
        int count = Integer.parseInt(input.nextLine());
        ArrayList<Book> books = new ArrayList<>();

        for (int i = 0; i < count; i++)
        {
            String[] bookData = input.nextLine().split("\\s");
            SimpleDateFormat formatter = new SimpleDateFormat("dd.MM.yyyy");
            Date date = null;

            try
            {
                date = formatter.parse(bookData[3]);
            }
            catch (ParseException e)
            {
                e.printStackTrace();
            }

            books.add(new Book(bookData[0], bookData[1], bookData[2], date, bookData[4], Double.parseDouble(bookData[5])));
        }
        return books;
    }

    static class Book {
        private String title;
        private String author;
        private String publisher;
        private Date releaseDate;
        private String isbn;
        private Double price;

        private Book(String title, String author, String publisher, Date releaseDate, String isbn, Double price) {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.releaseDate = releaseDate;
            this.isbn = isbn;
            this.price = price;
        }
    }
}
