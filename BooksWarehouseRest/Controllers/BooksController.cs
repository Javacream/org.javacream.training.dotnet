using Microsoft.AspNetCore.Mvc;
using System;
using Javacream.BooksWarehouse.Api;
using System.Collections.Generic;
//using Javacream.BooksWarehouse;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase{
    private IBooksModel _model;// = ApplicationContext.Model;

    public BooksController(IBooksModel model){
        _model = model;
    }

    [HttpGet]
    public List<Book> FindAll(){
        return _model.FindAll();
    }
    [HttpGet("{isbn}")]
    public Book FindByIsbn(string isbn){
        return _model.FindByIsbn(isbn);
    }

    [HttpPost("{title}")]
    public string Create(string title){
        return _model.Create(title);
    }
    [HttpDelete("{isbn}")]
    public void DeleteByIsbn(string isbn){
        _model.DeleteByIsbn(isbn);
    }

    [HttpPut("{isbn}/pages/{pages}")]
    public void UpdatePrice(string isbn, int pages){
        Book b = FindByIsbn(isbn);
        b.Pages = pages;
        _model.Update(b);
    }

    [HttpPut("{isbn}/price/{price}")]
    public void UpdatePrice(string isbn, double price){
        Book b = FindByIsbn(isbn);
        b.Price = price;
        _model.Update(b);
    }
    [HttpPut("{isbn}/available/{available}")]
    public void UpdateAvailability(string isbn, bool available){
        Book b = FindByIsbn(isbn);
        b.Available = available;
        _model.Update(b);
    }


}