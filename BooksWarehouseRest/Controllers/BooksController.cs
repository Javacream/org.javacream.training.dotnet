using Microsoft.AspNetCore.Mvc;
using System;
using Javacream.BooksWarehouse.Api;
//using Javacream.BooksWarehouse;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase{
    private IBooksModel _model;// = ApplicationContext.Model;

    public BooksController(IBooksModel model){
        _model = model;
    }


}