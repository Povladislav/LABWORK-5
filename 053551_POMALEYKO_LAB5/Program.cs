Catalog catalog = new Catalog();
ClientInterract interract = new ClientInterract();
Catalog.onChoose += DisplayInfoAboutChosenProduct;
catalog.Display();
void DisplayInfoAboutChosenProduct(Product p)
{
    Console.Clear();
    Console.WriteLine($"Ваш товар : {p.Name}");
    Catalog.collection.Remove(p);
    interract.Interraction(p);



}
