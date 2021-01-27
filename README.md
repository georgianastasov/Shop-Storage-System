# Shop-Storage-System Система за инвентаризация, разплащане и логистика

## :page_facing_up: Въведение
**Известно** е в световен мащаб, че днешния пазар е изключително забързан и динамичен. Развиват се множество малки и средни фирми, които се занимават с търговия, а по-големите преосперират все повече. От друга страна изискването на клиентите расте с всяка изминала година, те искат нещата да се случват бързо и лесно. Известно е в световен мащаб, че днешния пазар е изключително забързан и динамичен. Развиват се множество малки и средни фирми, които се занимават с търговия, а по-големите преосперират все повече. От друга страна изискването на клиентите расте с всяка изминала година, те искат нещата да се случват бързо и лесно. 

**Софтуерът**, който създаваме е насочен към малки и средни магазини, складове и онлайн магазини с различна област в предлагането на стоки и продукти. Целта на софтуера е лесна организация на обекта, по-добро разпределение и по-достъпна информация за наличните продукти. Добра инвентаризация и проследяване на всички артикули в обекта. Възможност за лесно и бързо разплащане и проследяване на транзакциите и логистиката. Това ще е от полза както на управителите на обекта така и на служителите за по-бързи реакции и улеснение на работата.


## :pushpin: Цели и изисквания – приложение
**Функционални изисквания:**
* •	Разпределяне на работата между служители и управители в два модула (модул служител, модул администратор)
* •	Лесна и бърза организация на обекта(служители и администратори)
* •	Разпределяне на продуктите (артикулите) в различни категории
* •	Добавяне, премахване, търсене и управление на продуктите
* •	Проследяване на наличните продукти на склад и техните спецификации
* •	Лесно и бързо разплащане и отпечатване на касови бележки 
* •	Възлагане и обработка на доставки (логистика)
* •	Проследяване на транзакциите и логистичните операции
* •	По-добро разпределение и инвентаризация(преглеждане на склада)
* •	По-добра достъпност на информацията(модули с възможност за разделяне на информацията според спецификации)
* •	Преглеждане на архиви за по добра отчетност


## :electric_plug: Начин на стартиране на системата
1. Изтегляне и инсталиране на програмата Visual Studio 2019.
2. Клониране на проекта на локално репозитори.
3. Инсталиране на локалния сървър SQL Express 2019.
4. Изтегляне и инсталиране на програмата SQL Managment Studio 2019.
5. Стартиране на програма SQL MS 2019 и свързване към локалния сървър на компютъра.
6. Импортиране на базата данни (storedatabase), която е в директорията на клонираното репозитори.
7. Стартиране на програмата VS 2019 и зареждане на проекта.
8. Отварян не раздела Server Explorer->(right click)Data Connection->Add Connection пише се името на вашият локален сървър, което може да се види в SQl Managment Studio в раздела отдясно.
9. След което се добавя базата данни (storedatabase). 
10. Отваря се app.config файла и срещу 'connectionString="Data Source=' се записва името на локалния ви сървър.
11. Стартира се системата.
12. Като админ се влиза с user= admin, password= admin. Като потребител се влиза user= user, password= user.


## :wrench: Използвани инструменти
* • C## 
* • Windows Forms
* • Visual Studio 2019
* • SQL Express 2019
* • SQL Managment Studio 2019
* • GitHub
* • Notepad++


## :chart_with_upwards_trend: Перспектива на продукта
**Системата** за разплащане, инвентаризация и логистика има голяма преспективав близкото и далечното бъдеще. Търговията заедно с информационните системи се разиват с високи темпове, взаймодействието и зависимостта между тях става вся по-голяма. Затова подобен вид системи ще продължат да навлизат, да се развиват и да се подобряват в тези сфери. Ако основните ползватели на системата подържа добре приложнието, зарежда го с различни стоки, актуализира неговото съдържание и го използват ефективно за работния процес, то тогава този софтуер никога няма да бъде извън употреба. Едно от важните качества на този вид системи са достъпността и използваемостта, тъй като те са достъпни и могат да се използват от всеки един служител от компютър или таблет.


## :computer: Технически изисквания
**Софтуерът** е изцяло информационен и компютърно ориентиран, затова техническите изисквания към даденият обект, който ще използва софтуерът ще бъде наличието на добра информационна мрежа дали било то локална или интернет, наличието на компютри като с времето софтуерът може да се прехвърли и на таблети. Важно е и наличието на добро захранване и компютърна грамотност при служителите. 




# Shop-Storage-System Inventory, payment and logistics system

## :page_facing_up: Introduction
**It** is known worldwide that the daily market is extremely fast and dynamic. Many small and medium-sized companies are developing, which are engaged in trade, and larger ones are operating more and more. On the other hand, customer demand grows with each fiction year, look for things to use quickly and easily. It is known worldwide that the daily market is extremely fast and dynamic. Many small and medium-sized companies are developing, which are engaged in trade, and larger ones are operating more and more. On the other hand, customer demand grows with each fiction year, look for things to use quickly and easily.

**Software** that creates guidelines for small and medium-sized stores, warehouses and online stores with different areas in the supply of goods and products. The purpose of the software is easy organization of the site, better distribution and access to information about available products. Make an inventory and track of all items in the site. Ability to easily and quickly pay and track transactions and logistics. This will benefit both site managers and employees for quick response and ease of work.


## :pushpin: Objectives and requirements - application
**Functional requirements:**
* • Distribution of work between employees and managers in two modules (employee module, administrator module)
* • Easy and fast organization of the site (employees and administrators)
* • Distribution of products (articles) in different categories
* • Add, remove, search and manage products
* • Tracking of available products in stock and their specifications
* • Easy and fast payment and printing of receipts
* • Assignment and processing of supplies (logistics)
* • Tracking of transactions and logistics operations
* • Better distribution and inventory (warehouse inspection)
* • Better availability of information (modules with the ability to divide information according to specifications)
* • View archives for better reporting


## :electric_plug: How to start the system
1. Download and install the program Visual Studio 2019.
2. Cloning the project to local repositories.
3. Installing the local SQL Express 2019 server.
4. Download and install the program SQL Managment Studio 2019.
5. Start the SQL MS 2019 program and connect to the local server of the computer.
6. Import the database (storedatabase), which is in the directory of cloned repositories.
7. Starting the VS 2019 program and loading the project.
8. Open tab Server Explorer -> (right click) Data Connection-> Add Connection write the name of your local server, which can be seen in SQl Managment Studio in the tab on the right.
9. Then add the database (storedatabase).
10. Open the app.config file and write the name of your local server against 'connectionString = "Data Source ='.
11. The system starts.
12. Log in as user with user = admin, password = admin. User = user, password = user is entered as user.


## :wrench: Tools used
* • C ##
* • Windows Forms
* • Visual Studio 2019
* • SQL Express 2019
* • SQL Management Studio 2019
* • GitHub
* • Notepad++


## :chart_with_upwards_trend: Product perspective
**The payment**, inventory and logistics system has great prospects for the near and distant future. Trade together with information systems is developing at a high pace, the interaction and dependence between them is growing. Therefore, such systems will continue to enter, develop and improve in these areas. If the main users of the system maintain the application well, load it with various goods, update its content and use it effectively for the workflow, then this software will never be out of use. One of the important qualities of this type of systems is accessibility and usability, as they are accessible and can be used by any employee from a computer or tablet.


## :computer: Technical requirements
**The** software is entirely information and computer oriented, so the technical requirements for the object that will use the software will be the presence of a good information network whether local or Internet, the presence of computers and over time the software can be transferred to tablets. It is also important to have good power supply and computer literacy among employees.


