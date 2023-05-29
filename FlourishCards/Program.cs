// See https://aka.ms/new-console-template for more information

using FlourishCards;
Random random = new Random();
//Card card1 = new Card((Suits)random.Next(4),(Values)random.Next(1,14));
//Card card2 = new Card((Suits)random.Next(4),(Values)random.Next(1,14));
//Card card3 = new Card((Suits)random.Next(4),(Values)random.Next(1,14));
//Card card4 = new Card((Suits)random.Next(4),(Values)random.Next(1,14));
//Card card5 = new Card((Suits)random.Next(4),(Values)random.Next(1,14));

List<Card> cards = new List<Card>();

for (int i = 0; i < 5; i++)
{
    cards.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
}

void PrintCarts(List<Card> cards)
{
    foreach (Card card in cards)
        Console.WriteLine(card.Name);
    Console.WriteLine("\n");
}

PrintCarts(cards);
// creating random cards and displaying them


CardComparer_byValue comparer_ByValue = new CardComparer_byValue();
cards.Sort(comparer_ByValue);

PrintCarts(cards);

Console.ReadKey();