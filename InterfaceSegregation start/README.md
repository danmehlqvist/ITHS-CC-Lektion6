## Interface Segregation exempel

Interfacet som djuren implementerar innehåller metoderna Walk(), Swim() och Jump().

Funkar bra sålänge vi tittar på hunder och katter och många andra djur. Börja vi titta på andra djur så 
är kanske implementationerna inte lika självklara. En landsköldpadda kan till exempel varken hoppa eller simma.

Lösningen är att vi bryter upp IAnimal till mindre interfaces.

1.	Skapa interfacen IWalkableAnimal, ISwimmableAnimal och IJumpableAnimal som bara innehåller en metod var.

2.	Nu lägger vi till interfacen som passar per djur. Till exempel får JellyFish implementera ISwimmable, men inga andra interfaces.

3.	Nu tar vi bort de metoder i djurklasserna som inte längre behövs för att implementera de interfaces som djuren har.

4.	Vi får nu modifiera Program litegrann. Alla djuren kan ju faktiskt inte simma.

Vi har nu sett till att vi inte längre har djur som har varit tvingade av den ursprungliga IAnimal att implementera metoder som 
inte alls passar sig för djuren. 

Vi kommer alltså inte längre kunna tvinga landsköldpaddan att försöka simma.