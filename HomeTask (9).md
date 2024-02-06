### Task 1

Create a C# program that implements an IVehicle interface with two methods:
- `Drive`: type `void`
- `Refuel`: type `bool`
 
The `Refuel` method should accept an integer parameter indicating the amount of gasoline to refuel.

Next, create a `Car` class with a constructor that takes the car's starting gasoline amount as a parameter.                                   
The `Car` class should implement the `Drive` and `Refuel` methods.                                    

The `Drive` method should print "Driving" to the screen if the amount of gasoline is greater than 0.

The `Refuel` method should increase the car's gasoline and return `true`.

To test the program, create an object of type `Car` with 0 gasoline in the `Main` method.                                        
Prompt the user for the amount of gasoline to refuel, and then execute the `Drive` method of the car.         

### Интерфейсы
Создайте программу C#, реализующую интерфейс IVehicle с двумя методами:
- `Диск`: введите `void`
- `Дозаправка`: введите `bool`
 
Метод Refuel должен принимать целочисленный параметр, указывающий количество бензина для заправки.

Затем создайте класс Car с конструктором, который принимает в качестве параметра стартовый объем бензина автомобиля.
Класс Car должен реализовывать методы Drive и Refuel.

Метод `Drive` должен выводить на экран надпись "Вождение", если количество бензина больше 0.

Метод `Refuel` должен увеличивать количество бензина в автомобиле и возвращать `true`.

Для тестирования программы создайте объект типа «Автомобиль» с 0 бензином в методе «Main».
Запросите у пользователя количество бензина для заправки, а затем выполните метод «Драйв» автомобиля.

**Input:**
```
50
```
```
Driving
```
------------------------------------------------------------------------
### Task 2

Create a C# program that implements an abstract class `Animal` that has a `Name` property of type `string` and three methods:                                                 
`SetName(string name)`,                  
`GetName()`, and `Eat()`.                      
The `Eat()` method will be an abstract method of type `void`.

You will also need to create a `Dog` class that implements the above `Animal` class and overrides the `Eat()` method to print `"the dog is Eating"`.

To test the program, ask the user for a dog name. Create a new `Dog` object from the `Main` method of the program,                        
give the `Dog` object a name, and then execute the `GetName()` and `Eat()` methods.

### Абстрактные классы
Создайте программу C#, реализующую абстрактный класс `Animal`, имеющий свойство `Name` текстового типа и три метода: 
`SetName(string name)`, 
`GetName()` и `Eat()`. 
Метод `Eat()` будет абстрактным методом типа `void`.                              

Вам также потребуется создать класс `Dog`, реализующий указанный выше класс `Animal`, и метод `Eat()`, который сообщает, что собака ест.

Чтобы протестировать программу, запросите у пользователя имя собаки и создайте новый объект типа `Dog` из `Main` программы,                            
дайте объекту `Dog` имя, а затем выполните методы `GetName()` и `Eat()`.                      

**Input**
```
Tobby
```

**Output**
```
Tobby
Eating
```
-----------

### Task 3 

You are developing a library management application.
You need to create a `Book` class that will represent a book in the library.
In addition, you have two interfaces: `Readable` and `Borrowable`.

Each book must have the following properties:

- `Title` (string) - the title of the book.
- `Author` (string) - the author of the book.

The `Readable` interface must contain the following method:

- `void Read()`, which will display a message that the book is being read.

The `Borrowable` interface must contain the following methods:

- `void Borrow()`, which will display a message indicating that the book has been borrowed.
- `void ReturnBook()`, which will print a message indicating that the book has been returned.

Your task:

1. Create an abstract class `AbstractBook`, which will contain the fields `Title` and `Author`, as well as methods for getting and setting the values of these fields.
2. Implement the `Readable` interface in the `AbstractBook` class and define a `Read()` method.
3. Create a class `Book` based on the abstract class `AbstractBook`.
4. Implement the `Borrowable` interface in the `Book` class and define the `Borrow()` and `ReturnBook()` methods.
5. Create an instance of the `Book` class, give it a name and author, and call the `Read()`, `Borrow()` and `ReturnBook()` methods.


Вы разрабатываете приложение для управления библиотекой.
Вам необходимо создать класс `Book`, который будет представлять книгу в библиотеке. 
Кроме того, у вас есть два интерфейса: `Readable` («читаемость») и `Borrowable` («возможность взять в аренду»).

Каждая книга должна иметь следующие свойства:

- `Title` (строка) - название книги.
- `Author` (строка) - автор книги.

Интерфейс `Readable` должен содержать следующий метод:

- `void Read()`, который будет выводить сообщение о том, что книга читается.

Интерфейс `Borrowable` должен содержать следующие методы:

- `void Borrow()`, который будет выводить сообщение о том, что книга была взята в аренду.
- `void ReturnBook()`, который будет выводить сообщение о том, что книга была возвращена.

Ваша задача:

1. Создайте абстрактный класс `AbstractBook`, который будет содержать поля `Title` и `Author`,
    а также методы для получения и установки значений этих полей.
2. Реализуйте интерфейс `Readable` в классе `AbstractBook` и определите метод `Read()`.
3. Создайте класс `Book` на основе абстрактного класса `AbstractBook`.
4. Реализуйте интерфейс `Borrowable` в классе `Book` и определите методы `Borrow()` и `ReturnBook()`.
5. Создайте экземпляр класса `Book`, присвойте ему название и автора, и вызовите методы `Read()`, `Borrow()` и `ReturnBook()`.

----------------------------------------------------------------------------------------------------------------













