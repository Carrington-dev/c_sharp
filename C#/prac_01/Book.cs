class Book{
    public string title;
    public string author;
    public int pages;

    public Book(string t, string a, int p){
        this.title = t;
        this.author = a;
        this.pages = p;
    }


    public void print(){
        Console.WriteLine("This book is titled \"" + this.title  + "\"\n");
        Console.WriteLine("It has " + this.pages  + " pages\n");
        Console.WriteLine("It was written by " + this.author  + "\n");
    }
}