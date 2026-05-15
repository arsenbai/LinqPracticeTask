//using LinqPracticeTask.Model;

//List<Product> products = new List<Product>() {};

//List<string> names = new List<string>() { "PC", "Earphones", "Laptop", "Captain America", "Batman", "Joker", "Batman", "Mario", "Hat", "Handwatches", "Gloves", "Mario" };
//List<string> categories = new List<string>() { "Electronics", "Electronics", "Electronics", "Toys", "Toys", "Toys", "Game", "Game", "Accessories", "Accessories", "Accessories", "Beverage" };
//List<decimal> prices = new List<decimal>() { 1227.99m, 200m, 1999m, 44m, 54m, 88m, 70m, 65m, 30m, 300m, 50m, 0.99m };
//List<bool> inStockParamList = new List<bool>() { true, false, true, true, false, true, false, true, true, false, true, true };

//for (int i = 0; i < names.Count; i++)
//{
//    products.Add(new Product(i + 1, names[i], categories[i], prices[i], inStockParamList[i]));
//}

////1.Get names of products cheaper than 100.
//var productsCheaperThanHundred = products.FindAll(p => p.Price < 100m).Select(p => p.Name);

////foreach (var item in productsCheaperThanHundred)
////{
////    Console.WriteLine(item);
////}


////2. Get top 5 most expensive products.
//var topFiveMostExpensiveProducts = products.OrderByDescending(p => p.Price).Take(5);

////foreach (var item in topFiveMostExpensiveProducts)
////{
////    Console.WriteLine(item.Name);
////}


////3. Group products by category and return category with its items.
//var groupOfProducts = products.GroupBy(p => p.Category);

////foreach (var group in groupOfProducts)
////{
////    Console.WriteLine($"GROUP: {group.Key}");
////    foreach (var product in group)
////    {
////        Console.WriteLine($" - PRODUCT: {product.Name}");
////    }
////    Console.WriteLine("---------------");
////}


////4. Find duplicate product names.
//var duplicateProductNames = products.GroupBy(p => p.Name).Where(g => g.Count() > 1).Select(g => g.Key);

////Console.WriteLine("Duplicates:");
////foreach (var (index, duplicateName) in duplicateProductNames.Index())
////{
////    Console.WriteLine($"index({index}): - {duplicateName}");
////}


////5. Get products in 'Electronics' category with price > 500 and in stock.
//var filteredProducts = products.Where(p => p.Category == "Electronics" && p.Price > 500);

////foreach (var electronicProdCheaperThanFiveHundred in filteredProducts)
////{
////    Console.WriteLine(electronicProdCheaperThanFiveHundred.Name);
////}


////6. Get a product by Id safely. Consider what happens if it does not exist.
//var productItem1 = products.FirstOrDefault(p => p.Id == 2);
//var productItem2 = products.FirstOrDefault(p => p.Id == 0);

////if (productItem1 is not null)
////{
////    Console.WriteLine(productItem1.Name);
////}
////else
////{
////    Console.WriteLine("PRODUCT NOT FOUND.");
////}

////if (productItem2 is not null)
////{
////    Console.WriteLine(productItem2.Name);
////}
////else
////{
////    Console.WriteLine("PRODUCT NOT FOUND.");
////}



////7. Convert product list into a dictionary using Id as key.
//var productDict = products.ToDictionary(p => p.Id);

////foreach (var item in productDict)
////{
////    Console.Write($"KEY: {item.Key} | ");
////    Console.WriteLine($"VALUE: {item.Value.Name}");
////}


////8.Find top 3 categories by average product price.

//var topThreeCategoriesByAvgProductPrice = products
//    .GroupBy(p => p.Category)
//    .Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.Price) })
//    .OrderByDescending(i => i.AvgPrice)
//    .Take(3);

////foreach (var item in topThreeCategoriesByAvgProductPrice)
////{
////    Console.Write($"CATEG: {item.Category} | AvgPrice=");
////    Console.WriteLine(item.AvgPrice);
////}



//List<int> _dataTask = new List<int> { 3, 13, 12, 157, 14, 77, 75, 13, 200, 156, 14, 21 };

//var result = _dataTask.Where(i => i % 2 != 0).Distinct();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//List<string> _dataTask = new List<string> { "asdf", "Rew", "trafa", "nadf", "Slos", "At", "new" };

//var res = _dataTask.Select(s => s[0]).Reverse().ToList();

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}

using LinqPracticeTask.Model;

List <Customer> _dataTask = new List<Customer>
        {
            new Customer {Id = 1, Year = 2019, Month = 10, OverallTrainingTime = 30 },
            new Customer {Id = 2, Year = 2019, Month = 11, OverallTrainingTime = 35 },
            new Customer {Id = 3, Year = 2019, Month = 11, OverallTrainingTime = 36 },
            new Customer {Id = 4, Year = 2019, Month = 12, OverallTrainingTime = 30 },
        };

var res = _dataTask.Where(c => c.OverallTrainingTime == _dataTask.Min(x => x.OverallTrainingTime))
    .Select(c => $"{c.Id} / {c.Year} / {c.Month} / {c.OverallTrainingTime}").Last();

Console.WriteLine(res);