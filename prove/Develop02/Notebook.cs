public class Notebook{
    public List<Page> _pages = new List<Page>();

    public void display(){

        foreach(Page page in _pages){
            page.displayPage();
        }
   
    }
}
