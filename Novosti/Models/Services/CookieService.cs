﻿namespace Models.Services;
using System.Collections.Generic;
using System.Linq;

public class CookieService
{
    private List<Cookie> cookies = new List<Cookie>
    {
        new Cookie { Id = 1, Name = "Печенье с шоколадом",  Price = 99.6m, ImageUrl = "images/cookie_basic.png" },
        new Cookie { Id = 2, Name = "Шоколадное печенье",  Price = 79.9m, ImageUrl = "images/dark_cookie.png" },
        // Добавь больше печений здесь
    };

    public List<Cookie> GetCookies() => cookies;
    
    // Логика для корзины
    private List<Cookie> cart = new List<Cookie>();

    public void AddToCart(Cookie cookie) => cart.Add(cookie);

    public List<Cookie> GetCart() => cart;

    public void ClearCart() => cart.Clear();
}
