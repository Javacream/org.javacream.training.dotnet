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


}