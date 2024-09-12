# Tech evolution - TDD

# Case: Bookstore
En vanlig tisdagsmorgon sitter Emelie och dricker kaffe vid sitt skrivbord när Bokus business manager kommer. Hen utropar glatt "Vi ska ha bokrea!". Vi har märkt att kunderna är helt galna i Harry Potter-böckerna just nu. Vi har räknat lite och tänker oss någon typ av trappa där man får 
1.	5% rabatt om man köper 2 olika böcker
2.	10% om man köper 3 olika böcker
3.	20% om det är 4 olika böcker 
4.	25% rabatt om man köper minst 5 olika böcker

Orginalpris oavsett bok är 8 EUR. 
Rabatterna gäller dock endast om man köper olika böcker i serien. Exempel: om en kund köper 4 böcker, där 3 böcker är av olika titlar, så får hen 10% rabatt på dom tre som är en del av serien och den fjärde för orginalpriset.

(källa: https://codingdojo.org/kata/Potter/)

# Uppgift
Implementera en lösning för den nya bokkampanjen som räknar ut slutpriset i EUR för ett köp av böcker. Tänk testdrivet. Hur kan vi bryta ner problemet i mindre beståndsdelar och testa del för del?

# Beräkningsexempel
Vad blir slutpriset i EUR för föjande varukorg med harry-p böcker?

2 kopior av första boken
2 kopior av andra boken
2 kopior av tredje boken
1 kopior av fjärde boken
1 kopior av femte boken

(5 * 8€) - 25% * [första boken, andra boken, tredje boken, fjärde boken, femte boken]€ + (3 * 8€) - 10% [första boken, andra boken, tredje boken]€

= (5 * 8€) - 25% * (5 * 8€) + (3 * 8€) - 10% * (3 * 8€)

= 51.6 €