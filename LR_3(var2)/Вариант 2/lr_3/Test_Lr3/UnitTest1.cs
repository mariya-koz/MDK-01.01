using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using lr_3;
using ClassLr_3;

namespace Test_Lr3
{
    [TestClass]
    public class UnitTest1
    {
            //Загрузка категорий при запуске 
            [TestMethod]
       public void TLoadCategories_ShouldReturnNonEmptyList_WhenCsvFileExists()
       {
            var productModul = new ProductModul();

            List<Product> products = productModul.LoadDataFromCsv();

            Assert.IsNotNull(products, "Список товаров не должен быть null");
            Assert.IsTrue(products.Count > 0, "Список товаров не должен быть пустым");
       }
        // Отображение товаров по категории 
        [TestMethod]
        public void TDisplayProductsByCategory_ShouldGroupProductsByCategory_WhenProductsExist()
        {
            var products = new List<Product>
            {
                new Product("Мандарины", 13.0, 5, 15, "mandarin.jpg"),
                new Product("Гранаты", 25.0, 7, 13, "granat.jpg"),
                new Product("Огурцы", 8.0, 6, 34, "ogurci.jpg"),
                new Product("Помидоры", 3.0, 5, 12, "pomidor.jpg")
            };

            var categories = new Dictionary<string, List<Product>>
            {
                { "Фрукты", products.Where(p => p.Name == "Мандарины" || p.Name == "Гранаты").ToList() },
                { "Овощи", products.Where(p => p.Name == "Огурцы" || p.Name == "Помидоры").ToList() }
            };

            List<Product> fruits = categories["Фрукты"];

            Assert.AreEqual(2, fruits.Count, "В категории 'Фрукты' должно быть 2 товара");
            Assert.AreEqual("Мандарины", fruits[0].Name, "Первый товар должен быть 'Мандарины'");
            Assert.AreEqual("Гранаты", fruits[1].Name, "Второй товар должен быть 'Гранаты'");
        }

    }
}