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
            _productInfo = new ObservableCollection<ProductSalesDetails>();
            _productInfo.Add(new ProductSalesDetails("Bike", "Germany", "Bayern", 9, 12, 25000));
            _productInfo.Add(new ProductSalesDetails("Bike", "Germany", "Brandenburg", 8, 14, 36000));
            _productInfo.Add(new ProductSalesDetails("Bike", "Germany", "Hamburg", 5, 8, 40040));
            _productInfo.Add(new ProductSalesDetails("Car", "Germany", "Hessen", 3, 10, 10700));
            _productInfo.Add(new ProductSalesDetails("Car", "Germany", "Bayern", 8, 13, 20300));
            _productInfo.Add(new ProductSalesDetails("Truck", "Australia", "Queensland", 5, 7, 50700));
            _productInfo.Add(new ProductSalesDetails("Van", "Canada", "Alberta", 6, 8, 80100));
            _productInfo.Add(new ProductSalesDetails("BiCycle", "Canada", "Brunswick", 2, 6, 35000));
            _productInfo.Add(new ProductSalesDetails("Car", "France", "Essonne", 4, 8, 20030));
            _productInfo.Add(new ProductSalesDetails("Bike", "United States", "New York", 3, 7, 54000));

            return _productInfo;
        }
    }
}
