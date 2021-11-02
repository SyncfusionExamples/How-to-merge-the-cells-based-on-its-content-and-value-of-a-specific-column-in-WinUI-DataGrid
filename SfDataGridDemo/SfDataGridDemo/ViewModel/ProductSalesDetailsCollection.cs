#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SfDataGridDemo
{
    /// <summary>
    /// Represents a class that contains the product sales details collection.
    /// </summary>
    public class ProductSalesDetailsCollection
    {
        /// <summary>
        /// It contains the ObservableCollection of product sales details.
        /// </summary>
        private ObservableCollection<ProductSalesDetails> _productInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSalesDetailsCollection"/> class.
        /// </summary>
        public ProductSalesDetailsCollection()
        {
            ProductInfo = this.GetSalesInfo();
        }

        /// <summary>
        /// Gets or sets the sales info.
        /// </summary>
        /// <value>The sales info.</value>
        public ObservableCollection<ProductSalesDetails> ProductInfo
        {
            get
            {
                return _productInfo;
            }
            set
            {
                _productInfo = value;
            }
        }

        /// <summary>
        /// Gets the sales info.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<ProductSalesDetails> GetSalesInfo()
        {
            /// Geography
            string[] countries = new string[] { "Australia", "Canada", "France", "Germany", "United States" };
            string[] ausStates = new string[] { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" };
            string[] canadaStates = new string[] { "Alberta", "British Columbia", "Brunswick", "Manitoba", "Ontario", "Quebec" };
            string[] franceStates = new string[] { "Charente-Maritime", "Essonne", "Garonne (Haute)", "Gers", };
            string[] germanyStates = new string[] { "Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein-Westfalen", "Saarland" };

            string[] ussStates = new string[] { "New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina" };

            /// Products
            string[] products = new string[] { "Bike", "Car", "Truck", "Van", "BiCycle" };
            Random r = new Random(0);

            int numberOfRecords = 10;
            ObservableCollection<ProductSalesDetails> listOfProductSales = new ObservableCollection<ProductSalesDetails>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                ProductSalesDetails sales = new ProductSalesDetails();
                sales.Country = countries[r.Next(1, countries.GetLength(0))];
                sales.Quantity = r.Next(1, 12);
                sales.Discount = r.Next(1, 15);
                sales.Amount = (30000 * sales.Quantity);
                sales.Product = products[r.Next(r.Next(products.GetLength(0) + 1))];
                switch (sales.Country)
                {
                    case "Australia":
                        {
                            sales.State = ausStates[r.Next(ausStates.GetLength(0))];
                            break;
                        }
                    case "Canada":
                        {
                            sales.State = canadaStates[r.Next(canadaStates.GetLength(0))];
                            break;
                        }
                    case "France":
                        {
                            sales.State = franceStates[r.Next(franceStates.GetLength(0))];
                            break;
                        }
                    case "Germany":
                        {
                            sales.State = germanyStates[r.Next(germanyStates.GetLength(0))];
                            break;
                        }
                    case "United States":
                        {
                            sales.State = ussStates[r.Next(ussStates.GetLength(0))];
                            break;
                        }
                }

                listOfProductSales.Add(sales);
            }

            return listOfProductSales;
        }
    }
}
