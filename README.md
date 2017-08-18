# LearnUnitTest
以四則運算(Elementary arithmetic)為例子實作演算法單元測試。

## 1. 專案結構
* ClassLibrary1 : 四則運算函式庫。
* WebApplication1 : 四則運算輸出Web Application，使用MVC輸出。 
* WebApplication1.Tests : 單元測試ClassLibrary1四則運算函式庫。

## 2. 輸出方式
* C#+MVC

## 3. 輸出範例
```cs
 public ActionResult Index()
 {
    var Result = RelArithmeticBase.Addition(1, 1);
    var ResultSecound = RelArithmeticBase.AdditionSecound(2.0, 2.1);
    var ResultThird = RelArithmeticBase.Division(22.0, -7.0);

     ViewData["Result"] = Result;
     ViewData["ResultSecound"] = ResultSecound;
     ViewData["ResultThird"] = ResultThird;

     return View();
}
