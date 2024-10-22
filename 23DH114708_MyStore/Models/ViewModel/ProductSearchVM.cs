﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _23DH114708_MyStore.Models.ViewModel
{
    public class ProductSearchVM
    {
        // Tiêu chí để search theo tên, mô tả sp hoặc loại sản phẩm
        public string SearchTerm { get; set; }

        // Các tiêu chí để search theo giá
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        // Thứ tự sắp xếp
        public string SortOrder { get; set; }

        // Các thuộc tính hỗ trợ phân trang
        public int PageNumber { get; set; }  // Trang hiện tại 
        public int PageSize { get; set; } = 10; // Số sản phẩm mỗi trang

        // Danh sách sản phẩm đã phân trang 
        public List<Product> Products { get; set; }

        // Constructor để khởi tạo danh sách sản phẩm
        public ProductSearchVM()
        {
            Products = new List<Product>();
        }
    }
}