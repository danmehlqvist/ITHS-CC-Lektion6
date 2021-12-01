## DEPENDENCY INVERSION

Problemet är nu att vi har kod som är väldigt hårt kopplat. Om vi skulle vilja ändra på t.ex. rabatten
som styrs av ProductDiscount så det kan bli svårigheter att implementera förändringar eller tillägg. Vi kanske
vill ha en speciell julrabbatt?

Vi vill nu koppla isär dessas hårdkodade delar av detta mini-system. Vi har tyvärr att 
ProductService har ett hårt kopplat beroende till både ProductDiscount och ProductRepo. Det vill vi 
bygga bort genom att använda Dependency INJECTION.

# Första steget

1. Skapa abstraktioner för ProductDiscount och ProductRepo => IProductDiscount och IProductRepo

2. Låt ProductDiscount och ProductRepo implementera de nya interfacen.

3. Vi uppdaterar Product.AdjustPrice så att den tar emot IProductDiscount

4. Vi uppdaterar nu ProductService
	- Ändra de privata variablerna så de är av interfacens typer
	- Vi lägger in interfacen i konstruktorn.

5.	I program får vi nu skicka in två parametrar till ProductService(...).

# Andra steget

Vi kommer på att det skulle vara trevligt att kanske kunda använda olika rabattstrategier samtidigt.
Det är snart jul och vi är lite generösa så vi vill implementera en strategi som skänker bort produkterna.
Vi skapar en FreeProductDiscount som implmeneterar IProductDiscount. Men sen då?

Vi skulle kunna dra igång en ny ProductService där vi kör in denna strategin med namn freeProductService.

Ett annat alternativ är att vi injektar inte strategin direkt i konstruktorn. Vi injectar den in i AdjustPrice istället.
Vi behöver nu inte dra igång en ny ProductService om vi vill byta rabatt.
Detta är en annan typ av DI som kallas för method injection.

