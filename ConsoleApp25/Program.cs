using Mouselist1;


Mouselist list = new Mouselist();

// Добавление //
list.Insert(new Mouse { Id = 1, Make = "Razer", Model = "DeathAdder Elite", Year = 2019, Color = "Black" });
list.Insert(new Mouse { Id = 2, Make = "Logitech", Model = "G Pro Wireless Mouse", Year = 2022, Color = "White" });
list.Insert(new Mouse { Id = 3, Make = "BenQ", Model = "Zowie EC2-A", Year = 2021, Color = "Black" });
list.Insert(new Mouse { Id = 4, Make = "ASUS", Model = "ROG Gladius II Core", Year = 2022, Color = "Black" });
list.Insert(new Mouse { Id = 5, Make = "HyperX ", Model = "Pulsefire Haste", Year = 2022, Color = "Black" });

// Все id //
List<Mouse> allMouses = list.GetAll();
Console.WriteLine("Все мышки:");
foreach (Mouse Mouse in allMouses)
{
    Console.WriteLine($"Id: {Mouse.Id}, Make: {Mouse.Make}, Model: {Mouse.Model}, Year: {Mouse.Year}, Color: {Mouse.Color}");
}

// Поиск по id //
Mouse MouseById = list.GetById(2);
Console.WriteLine("Мышка Топ 2:");
Console.WriteLine($"Make: {MouseById.Make}, Model: {MouseById.Model}, Year: {MouseById.Year}, Color: {MouseById.Color}");

// Замена //
Mouse updatedMouse = new Mouse { Make = "BenQ", Model = "Zowie EC1-A", Year = 2021, Color = "Silver" };
list.Update(2, updatedMouse);
Mouse MouseAfterUpdate = list.GetById(2);
Console.WriteLine("Обновляем Топ 2:");
Console.WriteLine($"Make: {MouseAfterUpdate.Make}, Model: {MouseAfterUpdate.Model}, Year: {MouseAfterUpdate.Year}, Color: {MouseAfterUpdate.Color}");

// Убираем //
Console.WriteLine("Меняем Топ 1");
list.Delete(1);
Console.WriteLine("Топ 1 обновлён:");
foreach (Mouse Mouse in allMouses)
{
    Console.WriteLine($"Id: {Mouse.Id}, Make: {Mouse.Make}, Model: {Mouse.Model}, Year: {Mouse.Year}, Color: {Mouse.Color}");
}